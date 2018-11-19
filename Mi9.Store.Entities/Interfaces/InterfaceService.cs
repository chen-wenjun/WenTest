using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.Entities.Interfaces
{
    public class InterfaceService : IInterfaceService
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MI9.HDM.Store.BackOffice.Data.DataContext"].ConnectionString;

        
        /// <summary>
        /// Cash Management- I018: RECONCILIATION OF VOUCHERS 
        /// </summary>
        /// <param name="action">  </param>
        /// <param name="voucherReconcileDetailsEntities">The list of voucher reconcile details</param>
        public void VoucherReconciliation(string action, IEnumerable<VoucherReconcileDetailsEntity> voucherReconcileDetailsEntities)
        {
            using (var connection = new SqlConnection(_connectionString))
            {

                var sproc = new SqlCommand("spCbVoucherReconciliationSMS-Fin", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var actionParameter = sproc.Parameters.Add("@Action", SqlDbType.NVarChar, 16);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = action;

                var aggregationIdParameter = sproc.Parameters.Add("@VoucherReconcileDetailId", SqlDbType.Int);
                aggregationIdParameter.Direction = ParameterDirection.Input;

                connection.Open();

                foreach (var voucherReconcileDetailsEntity in voucherReconcileDetailsEntities)
                {
                    aggregationIdParameter.Value = voucherReconcileDetailsEntity.VoucherReconcileDetailId;
                    sproc.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Cash Management- I150: AUTORIZATION RECONCILIATION OF VOUCHERS 
        /// </summary>
        public void AuthorizeVoucherReconcilation(int reconcileVoucherId, string authorizingCashierPayrollNo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spAuthOfVoucherReconciliation", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var actionParameter = sproc.Parameters.Add("@voucherReconcileId", SqlDbType.Int);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = reconcileVoucherId;

                actionParameter = sproc.Parameters.Add("@authorizingCashierPayrollNo", SqlDbType.VarChar, 9);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = authorizingCashierPayrollNo;

                connection.Open();
                sproc.ExecuteNonQuery();
            }
        }

        //I019
        public void CaptureAggregatedDepositsForTransport(string action, int aggregationId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spCbTransportCaptureAggregatedDepositsSMS-Fin", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var actionParameter = sproc.Parameters.Add("@Action", SqlDbType.NVarChar, 16);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = action;

                var aggregationIdParameter = sproc.Parameters.Add("@CashDepId", SqlDbType.BigInt);
                aggregationIdParameter.Direction = ParameterDirection.Input;
                aggregationIdParameter.Value = aggregationId;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Installation Management - I054: Installer Master File
        /// </summary>
        /// <param name="installerId"> Installer.installerID </param>
        public void InstallerMasterFile(int installerId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spInstallerMasterFile", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var actionParameter = sproc.Parameters.Add("@InstallerID", SqlDbType.Int);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = installerId;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        //I061
        /// <summary>
        /// Receiving - I061: Send Pallet Evaluation to MMS
        /// </summary>
        /// <param name="shipmentId"></param>
        public void SendPalletEvaluationsToMms(string shipmentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spPalletEvaluations", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var actionParameter = sproc.Parameters.Add("@ShipmentId", SqlDbType.NVarChar);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = shipmentId;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        //I061
        /// <summary>
        /// Receiving - I061: Send Pallet Evaluation to MMS. Report Unexpected Pallet
        /// </summary>
        /// /// <param name="shipmentId"></param>
        /// <param name="palletId"></param>
        public void ReportUnexpectedPalletInShipment(string shipmentId, string palletId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spReportUnexpectedPalletInShipment", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var actionParameter = sproc.Parameters.Add("@ShipmentId", SqlDbType.NVarChar);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = shipmentId;

                actionParameter = sproc.Parameters.Add("@PalletId", SqlDbType.NVarChar);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = palletId;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        //I063
        public void UpdatePostDatedCheckForDeposit(short registerId, int transactionNumber, DateTime transactionDate, DateTime expireDate, DateTime depositDate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spUpdateCbPostDatedChecksForDeposit", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var registerIdParameter = sproc.Parameters.Add("@RegisterID", SqlDbType.SmallInt);
                registerIdParameter.Direction = ParameterDirection.Input;
                registerIdParameter.Value = registerId;

                var transactionNumberParameter = sproc.Parameters.Add("@TranNumber", SqlDbType.Int);
                transactionNumberParameter.Direction = ParameterDirection.Input;
                transactionNumberParameter.Value = transactionNumber;

                var transactionDateParameter = sproc.Parameters.Add("@TranDate", SqlDbType.Date);
                transactionDateParameter.Direction = ParameterDirection.Input;
                transactionDateParameter.Value = transactionDate;

                var expireDateParameter = sproc.Parameters.Add("@ExpireDate", SqlDbType.Date);
                expireDateParameter.Direction = ParameterDirection.Input;
                expireDateParameter.Value = expireDate;

                var depositDateParameter = sproc.Parameters.Add("@DepositDate", SqlDbType.Date);
                depositDateParameter.Direction = ParameterDirection.Input;
                depositDateParameter.Value = depositDate;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Pro Pricing - I066: Request Commercial Agreement
        /// </summary>
        /// <param name="action"> Create or Update </param>
        /// <param name="sccPriceAgreementsId">The Id of the record in table SccPriceAgreements</param>
        public void RequestCommercialAgreement(string action, int sccPriceAgreementsId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {

                var sproc = new SqlCommand("spPpRequestCommercialAgreement", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var actionParameter = sproc.Parameters.Add("@Action", SqlDbType.NVarChar, 16);
                actionParameter.Direction = ParameterDirection.Input;
                actionParameter.Value = action;

                var idParameter = sproc.Parameters.Add("@Id", SqlDbType.Int);
                idParameter.Direction = ParameterDirection.Input;
                idParameter.Value = sccPriceAgreementsId;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        //I074
        public void StockTransfer(string tranferNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spStockTransfersStoreMerch", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var aggregationIdParameter = sproc.Parameters.Add("@TransferNumber", SqlDbType.NVarChar, 100);
                aggregationIdParameter.Direction = ParameterDirection.Input;
                aggregationIdParameter.Value = tranferNumber;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        //I070
        public void SendDiscrepancyInfoToMms(long discrepancyNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spDiscrepancyInfoStoreMerch", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var aggregationIdParameter = sproc.Parameters.Add("@discrepancyNumber", SqlDbType.BigInt);
                aggregationIdParameter.Direction = ParameterDirection.Input;
                aggregationIdParameter.Value = discrepancyNumber;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        //I123
        public void StockTransfertoSOM(string tranferNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spStockTransfersConfirmationOrRejection", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var aggregationIdParameter = sproc.Parameters.Add("@TransferNo", SqlDbType.NVarChar, 50);
                aggregationIdParameter.Direction = ParameterDirection.Input;
                aggregationIdParameter.Value = tranferNumber;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        //I094
        public void CreateUpdateCustomer(string action, long customerId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spNormalCustomersXML", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var customerIdParam = sproc.Parameters.Add("@CustomerID", SqlDbType.BigInt);
                customerIdParam.Direction = ParameterDirection.Input;
                customerIdParam.Value = customerId;

                var actionParam = sproc.Parameters.Add("@Action", SqlDbType.NVarChar);
                actionParam.Direction = ParameterDirection.Input;
                actionParam.Value = action;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Special Order - I159: Special Order Bitacora
        /// </summary>
        /// <param name="poNumber">Purchase Order Number</param>
        public void CreateSpecialOrderBitacora(string poNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spSoBitacora", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var poNumberParam = sproc.Parameters.Add("@PONumber", SqlDbType.NVarChar);
                poNumberParam.Direction = ParameterDirection.Input;
                poNumberParam.Value = poNumber;

                //var seqnParam = sproc.Parameters.Add("@Seqn", SqlDbType.BigInt);
                //seqnParam.Direction = ParameterDirection.Input;
                //seqnParam.Value = seqn;

                connection.Open();

                sproc.ExecuteNonQuery();
            }
        }

        public void ReporPalletForAudit(string palletId)
        {
            //todo . Right now there is no specs on MMS
        }

        //I003 ARTS
        public void UpdatePurchaseOrder(string poNumber,string userId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sproc = new SqlCommand("spPurchasedOrderDet", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var poUserIdParam = sproc.Parameters.Add("@UserId", SqlDbType.NVarChar);
                poUserIdParam.Direction = ParameterDirection.Input;
                poUserIdParam.Value = poNumber;


                var poNumberParam = sproc.Parameters.Add("@PurchaseOrderId", SqlDbType.NVarChar);
                poNumberParam.Direction = ParameterDirection.Input;
                poNumberParam.Value = poNumber;

                connection.Open();
                sproc.ExecuteNonQuery();
            }
        }
    }
}