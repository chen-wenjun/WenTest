using System;
using System.Collections.Generic;
using Mi9.Store.ViewModels.Converters;
using Newtonsoft.Json;

namespace Mi9.Store.ViewModels.ViewModels
{
    public class InstallationRequestViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("orderId")]
        public int OrderId { get; set; }

        [JsonProperty("customer")]
        public CustomerViewModel Customer { get; set; }

        [JsonProperty("installType")]
        public string InstallType { get; set; }

        [JsonProperty("status")]
        public InstallationRequestStatusViewModel Status { get; set; }

        [JsonProperty("createdDate")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty("actualStart")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? StartDate { get; set; }

        [JsonProperty("actualEnd")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        [JsonProperty("expectedStart")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? ProgDateStart { get; set; }

        [JsonProperty("expectedEnd")]
        [JsonConverter(typeof(IsoUtcDateTimeConverter))]
        public DateTime? ProgDateEnd { get; set; }

        [JsonProperty("installer")]
        public InstallerViewModelBase Installer { get; set; }

        [JsonProperty("installationPack")]
        public Pack PackOfServices { get; set; }

        [JsonProperty("procSolic")]
        public int ProcSolic { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        [JsonProperty("installationCost")]
        public decimal? InstallationCost { get; set; }

        [JsonProperty("tax")]
        public decimal Tax { get; set; }

        [JsonProperty("reasonOfSuspend")]
        public string ReasonOfSuspend { get; set; }

        [JsonProperty("feedback")]
        public InstallationRequestFeedbackStatusViewModel Feedback { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("description")]
        public string OrderDescription { get; set; }

        [JsonProperty("installerReassignReason")]
        public string InstallerReassignReason { get; set; }

        [JsonProperty("tranDate")]
        public DateTime? TranDate { get; set; }

        [JsonProperty("registerId")]
        public short RegisterId { get; set; }

        [JsonProperty("tranNumber")]
        public int TranNumber { get; set; }

        [JsonProperty("installationRequest")]
        public InstallationRequestViewModel ParentRequestForReturn { get; set; }

        public class Pack
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("departmentId")]
            public short DepartmentId { get; set; }

            [JsonProperty("departmentDesc")]
            public string DepartmentDesc { get; set; }

            [JsonProperty(PropertyName = "classId")]
            public short ClassId { get; set; }

            [JsonProperty("services")]
            public List<Service> Services { get; set; }

            public class Service
            {
                [JsonProperty("id")]
                public int Id { get; set; }

                [JsonProperty("packId")]
                public int PackId { get; set; }

                [JsonProperty("PackSequence")]
                public short PackSequence { get; set; }

                [JsonProperty("description")]
                public string Description { get; set; }

                [JsonProperty("descriptionDet")]
                public string DescriptionDet { get; set; }

                [JsonProperty("price")]
                public decimal Price { get; set; }

                [JsonProperty("cost")]
                public decimal Cost { get; set; }

                [JsonProperty("quantity")]
                public decimal Quantity { get; set; }

                [JsonProperty("uom")]
                public string Uom { get; set; }

                [JsonProperty("comment")]
                public string Comment { get; set; }
            }
        }
    }
}