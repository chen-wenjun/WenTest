using System;

namespace Mi9.Store.Entities.Entities
{
    public class ReasonEntity
    {
        public ReasonEntity()
        {
            //OrderItems = new List<OrderDetailEntity>();
            //OrdTranDets = new List<OrdTranDet>();
            //TranDetails = new List<TranDetail>();
            //TranFutures = new List<TranFuture>();
            //VndrRtnDtls = new List<VndrRtnDtl>();
            //XferInHdrs = new List<XferInHdr>();
            //XferOutHdrs = new List<XferOutHdr>();

            Description = string.Empty;
            AverageCost = false;
            GLNumber = 0;
            ExemptNoReqd = false;
            DiscountType = "P";
            DiscountAmt = 0;
            CustInfo = "N";
            NonTaxAgri = false;
            RentalDepr = false;
            TransType = 0;

            AdjustType = "R";
            InvAdjMeth = "S";
            Description = "Descr";
            DiscountType = "A";
            TransType = 5;
        }
        
        public byte ReasonCode { get; set; }
        public string AdjustType { get; set; }
        public string Description { get; set; }
        public string InvAdjMeth { get; set; }
        public bool AverageCost { get; set; }
        public int? GLNumber { get; set; }
        public bool? ExemptNoReqd { get; set; }
        public string DiscountType { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string CustInfo { get; set; }
        public bool? NonTaxAgri { get; set; }
        public bool? RentalDepr { get; set; }
        public byte? TransType { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Conversion { get; set; }

        //public virtual ICollection<OrderDetailEntity> OrderItems { get; set; }
        //public virtual ICollection<OrdTranDet> OrdTranDets { get; set; }
        //public virtual ICollection<TranDetail> TranDetails { get; set; }
        //public virtual ICollection<TranFuture> TranFutures { get; set; }
        //public virtual ICollection<VndrRtnDtl> VndrRtnDtls { get; set; }
        //public virtual ICollection<XferInHdr> XferInHdrs { get; set; }
        //public virtual ICollection<XferOutHdr> XferOutHdrs { get; set; }
        //public virtual ICollection<TransferEntity> Transfers { get; set; } 
    }
}