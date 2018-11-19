using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DepartmentClassViewModel : IValidatableObject
    {
        [JsonProperty(PropertyName = "departmentId")]
        public short DepartmentId { get; set; }

        [JsonProperty(PropertyName = "classId")]
        public short ClassId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "department")]
        public DepartmentViewModel Department { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Department == null && this.DepartmentId == 0)
            {
                yield return new ValidationResult("Department is required for this model");
            }

            if (this.Department != null && (this.Department.DepartmentId != this.DepartmentId))
            {
                yield return new ValidationResult("Department model is not consistent");
            }
        }
    }
}
