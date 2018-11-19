using System.Collections.Generic;

namespace Mi9.Store.Entities.Entities
{
    public class LabelTypeEntity
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string ShortName { get; set; }

        public bool StoreUse { get; set; }

        public bool WarehouseUse { get; set; }

        public bool Mobile { get; set; }

        public virtual ICollection<LabelConfigurationEntity> LabelConfigurationItems { get; set; }

        public string Label { get; set; }

        public string TemplateZplPrice { get; set; }

        public string TemplateZpl { get; set; }

        public string TemplateHtmlPrice { get; set; }

        public string TemplateHtml { get; set; }

        public string PromotionCode { get; set; }

        public bool HasPrice
        {
            get { return TemplateHtmlPrice != null || TemplateZplPrice != null; }
        }

        public bool EnableHasPrice
        {
            get { return (TemplateHtmlPrice != null && TemplateHtml != null) || (TemplateZplPrice != null && TemplateZpl != null);  }
        }
    }
}