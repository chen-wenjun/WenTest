using System;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EmployeeSalesViewModel
    {
        public long Id { get; set; }

        private short? _areaPercent;

        private short? _departmentPercent;

        public EmployeeSalesViewModel()
        {
            SalesActive = "N";
            Divide = false;
            IssueDate = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
            StatusDate = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
        }

        [JsonProperty(PropertyName = "employeeId")]
        public int EmployeeNo { get; set; }

        [JsonProperty(PropertyName = "salesActive")]
        public string SalesActive { get; set; } // "A,N,T,X"

        [JsonProperty(PropertyName = "divide")]
        public bool Divide { get; set; }

        [JsonProperty(PropertyName = "issueDate")]
        public DateTime IssueDate { get; set; }

        [JsonProperty(PropertyName = "statusDate")]
        public DateTime StatusDate { get; set; }

        [JsonProperty(PropertyName = "areaId")]
        public byte? AreaId { get; set; }

        [JsonProperty(PropertyName = "areaPercent")]
        public short? AreaPercent
        {
            get
            {
                return _areaPercent > 0 ? _areaPercent : null;
            }

            set
            {
                _areaPercent = value;
            }
        }

        [JsonProperty(PropertyName = "departmentId")]
        public short? DepartmentId { get; set; }

        [JsonProperty(PropertyName = "departmentPercent")]
        public short? DepartmentPercent
        {
            get
            {
                return _departmentPercent > 0 ? _departmentPercent : null;
            }

            set
            {
                _departmentPercent = value;
            }
        }
    }
}
