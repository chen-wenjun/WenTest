using System;
using System.Collections.Generic;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.Entities.Interfaces
{
    public interface IInterfaceService
    {
        //I018
        void VoucherReconciliation(string action, IEnumerable<VoucherReconcileDetailsEntity> voucherReconcileDetailsEntities);

        //I150
        void AuthorizeVoucherReconcilation(int reconcileVoucherId, string authorizingCashierPayrollNo);

        //I019
        void CaptureAggregatedDepositsForTransport(string action, int aggregationId);

        /// <summary>
        /// Installation Management - I054: Installer Master File
        /// </summary>
        /// <param name="installerId"> Installer.installerID </param>
        void InstallerMasterFile(int installerId);

        //I061
        /// <summary>
        /// Receiving - I061: Send Pallet Evaluation to MMS
        /// </summary>
        /// <param name="shipmentId"></param>
        void SendPalletEvaluationsToMms(string shipmentId);


        /// <summary>
        ///  Receiving - I061: Send Pallet Evaluation to MMS. Report Unexpected Pallet
        /// </summary>
        /// /// <param name="shipmentId"></param>
        /// <param name="palletId"></param>
        void ReportUnexpectedPalletInShipment(string shipmentId, string palletId);

        //I063
        void UpdatePostDatedCheckForDeposit(short registerId, int transactionNumber, DateTime transactionDate,
            DateTime expireDate, DateTime depositDate);

        //I066
        void RequestCommercialAgreement(string action, int sccPriceAgreementsId);

        //IF074
        void StockTransfer(string tranferNumber);

        //I070
        void SendDiscrepancyInfoToMms(long discrepancyNumber);

        //I123
        void StockTransfertoSOM(string tranferNumber);

        //I094
        void CreateUpdateCustomer(string action,long customerId);

        /// <summary>
        /// Special Order - I159: Special Order Bitacora
        /// </summary>
        /// <param name="poNumber">Purchase Order Number</param>
        void CreateSpecialOrderBitacora(string poNumber);

        //------------------------ Receiving Shipment-----------------------------

        /// <summary>
        /// I060: Report Pallet for Audit
        /// </summary>
        /// <param name="palletId"></param>
        void ReporPalletForAudit(string palletId);
        //------------------------ Receiving Shipment-----------------------------

        void UpdatePurchaseOrder(string poNumber,string userId);

    }
}