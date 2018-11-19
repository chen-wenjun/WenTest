using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EmployeeViewModel : IValidatableObject
    {
        [JsonProperty(PropertyName = "id", Order = 1)]        
        public int EmployeeNo { get; set; }

        [JsonProperty(PropertyName = "firstName", Order = 2)]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        [JsonProperty(PropertyName = "lastName", Order = 3)]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1} {2}", FirstName, MiddleName, LastName).Replace("  ", " ").Trim();
            }
        }

        [JsonProperty(PropertyName = "bage", Order = 4)]
        public string TABadge { get; set; }

        [JsonProperty(PropertyName = "jobTitleId", Order = 6)]
        public int? JobClassId { get; set; }

        [JsonProperty(PropertyName = "empStatus")]
        public string EmpStatus { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "postCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "initials")]
        public string Initials { get; set; }

        [JsonProperty(PropertyName = "socialSecurityNumber")]
        public string SocialSecurityNumber { get; set; }

        [JsonProperty(PropertyName = "securityNumber")]
        public byte SecurityNumber { get; set; }

        [JsonProperty(PropertyName = "isSupervisor")]
        public bool IsSupervisor { get; set; }

        [JsonProperty(PropertyName = "employeeCode")]
        public byte JobCode
        {
            get
            {
                return JobClass != null ? JobClass.JobCode : (byte)0;
            }
        }

        [JsonProperty(PropertyName = "cashInDrawer")]
        public decimal? CashInDrawer { get; set; }

        [JsonProperty(PropertyName = "newContract")]
        public bool NewContract { get; set; }

        [JsonProperty(PropertyName = "addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty(PropertyName = "addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty(PropertyName = "job", Order = 5)]
        public JobClassViewModel JobClass { get; set; }

        [JsonProperty(PropertyName = "jobTitle")]
        public string JobDescription { get; set; }

        [JsonProperty(PropertyName = "sales")]
        public ICollection<EmployeeSalesViewModel> Sales { get; set; }

        [JsonProperty(PropertyName = "areas")]
        public ICollection<EmployeeAreaViewModel> Areas { get; set; }

        [JsonProperty(PropertyName = "payrollId")]
        public string PayrollId { get; set; }

        [JsonProperty(PropertyName = "hireDate")]
        public DateTime? HireDate { get; set; }

        [JsonProperty(PropertyName = "termDate")]
        public DateTime? TermDate { get; set; }

        [JsonProperty(PropertyName = "empLocation")]
        public Int16? EmpLocation { get; set; }

        [JsonProperty(PropertyName = "empStatusId")]
        public int EmpStatusId { get; set; }

        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "days")]
        public ICollection<WeekDayViewModel> Days { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            
            if (Sales != null && Sales.Any())
            {
                var percentOfAllAreas = Sales.Where(t => t.AreaPercent.HasValue).Sum(t => t.AreaPercent);
                var percentOfAllDepartments = Sales.Where(t => t.DepartmentPercent.HasValue).Sum(t => t.DepartmentPercent);

                if (Sales.Where(t => t.AreaId.HasValue && t.AreaId > 0).GroupBy(t => t.AreaId).Any(t => t.Count() > 1))
                {
                    yield return new ValidationResult("You can not add the same areas.");
                }

                if (Sales.Where(t => t.DepartmentId.HasValue && t.DepartmentId > 0).GroupBy(t => t.DepartmentId).Any(t => t.Count() > 1))
                {
                    yield return new ValidationResult("You can not add the same departments.");
                }

                if (percentOfAllAreas > 0 && percentOfAllAreas != 100)
                {
                    yield return new ValidationResult("A sum of percents for all areas must be equal to 100.");
                }

                if (percentOfAllDepartments > 0 && percentOfAllDepartments != 100)
                {
                    yield return new ValidationResult("A sum of percents for all departments must be equal to 100.");
                }

                if (Sales.Any(t => t.AreaId.HasValue && !t.AreaPercent.HasValue))
                {
                    yield return new ValidationResult("You can not save area without percents.");
                }

                if (Sales.Any(t => t.DepartmentId.HasValue && !t.DepartmentPercent.HasValue))
                {
                    yield return new ValidationResult("You can not save department without percents.");
                }

                if (Sales.Any(t => !t.AreaId.HasValue && t.AreaPercent.HasValue))
                {
                    yield return new ValidationResult("You can not save percentage without areas.");
                }

                if (Sales.Any(t => !t.DepartmentId.HasValue && t.DepartmentPercent.HasValue))
                {
                    yield return new ValidationResult("You can not save percentage without departments.");
                }
            }
        }
    }
}