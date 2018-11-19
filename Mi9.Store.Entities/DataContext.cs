using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Globalization;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.Entities
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=MI9.HDM.Store.BackOffice.Data.DataContext") 
        {
            
        }

        #region POTracking
        //--------------------------POTracking-------------------------------------
        public DbSet<PoTrackingEntryEntity> PoTrackingEntries { get; set; }
        public DbSet<PoTrackingDetailEntity> PoTrackingDetails { get; set; }
        public DbSet<PoTrackingLogEntity> PoTrackingLogs { get; set; }
        public DbSet<PoTrackingEmailAttachmentEntity> PoTrackingEmailAttachments { get; set; }
        public DbSet<PoTrackingStateEntity> PoTrackingStates { get; set; }
        public DbSet<PoTrackingLogTypeEntity> PoTrackingLogTypes { get; set; }
        

        //old tables 
        public DbSet<SpecialOrderEntity> SpecialOrders { get; set; }
        public DbSet<PurchaseOrderStateHistoryStateEntity> PurchaseOrderStateHistoryStates { get; set; }
        public DbSet<PurchaseOrderStateHistoryDetailEntity> PurchaseOrderStateHistoryDetails { get; set; }
        public DbSet<ResaleOrderDetailCancelledPoDetail> ResaleOrderDetailCancelledPoDetails { get; set; }
        //end-----------------------POTracking-------------------------------------
        #endregion

        #region Purchase Order
        //------------------------PurchaseOrder-------------------------------------
        public virtual DbSet<PurchaseOrderEntity> PurchaseOrderEntities { get; set; }
        public virtual DbSet<PurchaseOrderItemEntity> PurchaseOrderItemEntities { get; set; }
        public DbSet<DestinationEntity> Destinations { get; set; }
        public DbSet<PurchaseOrderCancelStatusEntity> PurchaseOrderCancelStatuses { get; set; }
        public DbSet<PurchaseOrderControlEntity> PurchaseOrderControlEntities { get; set; }
        public virtual DbSet<StateEntity> States { get; set; }
        
        //end---------------------PurchaseOrder-------------------------------------
        #endregion

        #region Orders
        public DbSet<OrderEntity> OrderHeaders{ get; set; }
        public DbSet<OrderItemEntity> OrderDetails { get; set; }
        #endregion

        #region Department
        //------------------------Department-----------------------------------------
        public DbSet<DepartmentEntity> Departments { get; set; }

        public DbSet<DepartmentClassEntity> DepartmentClasses { get; set; }

        public DbSet<DepartmentSubClassEntity> DepartmentSubClasses { get; set; }
        //END---------------------Department-----------------------------------------
        #endregion

        #region Discrepancy
        //------------------------Discrepancy-----------------------------------------
        public DbSet<DiscrepancyEntity> Discrepancies { get; set; }

        public DbSet<DiscrepancyDetailEntity> DiscrepancyDetails { get; set; }

        public DbSet<DiscrepancyAttachmentEntity> DiscrepancyAttachments { get; set; }
        //END---------------------Discrepancy-----------------------------------------
        #endregion

        #region Employee
        //------------------------Employee-----------------------------------------
        public DbSet<DepositAggregationEntity> DepositAggregationEntities { get; set; }

        public virtual DbSet<EmployeeEntity> Employees { get; set; }

        public virtual DbSet<EmployeeSalesEntity> EmployeeSales { get; set; }

        public virtual DbSet<EmployeeTimeAttendanceEntity> EmployeeTimeAttendances { get; set; }

        public DbSet<IncidentTypeEntity> IncidentTypes { get; set; }

        public virtual DbSet<JobClassEntity> JobClasses { get; set; }

        public DbSet<ReasonTypeEntity> ReasonTypes { get; set; }

        public virtual DbSet<RequestAbsenceEntity> RequestAbsences { get; set; }

        public virtual DbSet<WeekDayEntity> WeekDays { get; set; }

        public virtual DbSet<EmployeeAreaEntity> EmployeeAreas { get; set; }
        //END---------------------Employee-----------------------------------------
        #endregion

        #region Schedules
        //------------------------Schedules-----------------------------------------
        public DbSet<FixedScheduleEntity> FixedSchedules { get; set; }

        public virtual DbSet<FixedTimeOffEntity> FixedTimeOffs { get; set; }

        public DbSet<GeneratedScheduleEntity> GeneratedSchedules { get; set; }

        public DbSet<SuggestedScheduleEntity> SuggestedSchedules { get; set; }
        //END---------------------Schedules-----------------------------------------
        #endregion

        #region Shipment
        //------------------------Shipment-----------------------------------------
        public virtual DbSet<ShipmentEntity> Shipments { get; set; }

        public virtual DbSet<ShipMethodEntity> ShipMethods { get; set; }

        public virtual DbSet<ShipmentTypeEntity> ShipmentTypes { get; set; }
        //END---------------------Shipment-----------------------------------------
        #endregion

        #region Pallet
        //------------------------Pallet-----------------------------------------
        public virtual DbSet<PalletEntity> Pallets { get; set; }

        public virtual DbSet<PalletItemEntity> PalletItems { get; set; }

        public virtual DbSet<PalletAuditStatusEntity> PalletAuditStatus { get; set; }
        //END---------------------Pallet-----------------------------------------
        #endregion

        #region ReturnToVendor
        //------------------------ReturnToVendor-----------------------------------------
        public virtual DbSet<ReturnToVendorEntity> ReturnToVendors { get; set; }

        public virtual DbSet<ReturnToVendorItemEntity> ReturnToVendorItems { get; set; }

        public virtual DbSet<ReturnToVendorTypeEntity> ReturnToVendorTypes { get; set; }

        public virtual DbSet<ReturnToVendorStatusEntity> ReturnToVendorStatus { get; set; }
        //END---------------------ReturnToVendor-----------------------------------------
        #endregion

        #region Store
        //------------------------Store-----------------------------------------
        public DbSet<DestinationStoreEntity> DestinationStore { get; set; }

        public DbSet<DistrictEntity> Districts { get; set; }

        public virtual DbSet<StoreEntity> Stores { get; set; }

        public virtual DbSet<TaxEntity> Taxes { get; set; }
        //END---------------------Store-----------------------------------------
        #endregion

        #region Transfer
        //------------------------Transfer-----------------------------------------
        public virtual DbSet<TransferEntity> Transfers { get; set; }

        public virtual DbSet<TransferItemEntity> TransferItems { get; set; }
        //END---------------------Transfer-----------------------------------------
        #endregion

        #region Vendor
        //------------------------Vendor-----------------------------------------
        public DbSet<FobTermEntity> FobTerms { get; set; }

        public DbSet<InvoiceTermEntity> InvoiceTerms { get; set; }

        public DbSet<PaymentMethodEntity> PaymentMethods { get; set; }

        public virtual DbSet<VendorEntity> Vendors { get; set; }

        public virtual DbSet<ItemVendorEntity> VendorItems { get; set; }

        public DbSet<VendorRTVConfigurationEntity> VendorRtvConfigurations { get; set; }
        //END---------------------Vendor-----------------------------------------
        #endregion

        #region Voucher
        //------------------------Voucher-----------------------------------------
        public DbSet<VoucherReconcileEntity> VoucherReconciles { get; set; }

        public DbSet<VoucherReconcileDetailsEntity> VoucherReconcileDetails { get; set; }
        //END---------------------Voucher-----------------------------------------
        #endregion

        #region Withdrawal
        //------------------------Withdrawal-----------------------------------------
        public DbSet<WithdrawalEntity> Withdrawals { get; set; }

        public DbSet<WithdrawalDenominationEntity> WithdrawalDenominations { get; set; }

        public DbSet<DenominationEntity> Denominations { get; set; }
        //END---------------------Withdrawal-----------------------------------------
        #endregion
        
        #region Sku
        //----------------------------------Sku-------------------------------
        public virtual DbSet<ItemSkuEntity> ItemPlUs { get; set; }
        public virtual DbSet<LabelTypeEntity> LabelTypes { get; set; }
        public virtual DbSet<BarCodeEntity> BarCodes { get; set; }
        public virtual DbSet<SKULocationEntity> SKULocations { get; set; }
        public DbSet<PricePndHdrEntity> PricePndHdrs { get; set; }
        public virtual DbSet<PricePndDtlEntity> PricePndDtls { get; set; }
        public DbSet<CouponEntity> Coupons { get; set; }
        public DbSet<PromotionEntity> Promotions { get; set; }
        public DbSet<PromotionItemEntity> PromotionItems { get; set; }
        public virtual DbSet<ItemHistoryEntity> ItemHistories { get; set; }
        public virtual DbSet<ItemReplenEntity> ItemReplens { get; set; }

        public DbSet<SkuKitEntity> SkuKits { get; set; }
        public DbSet<SkuKitItemEntity> SkuKitItems { get; set; }
        //end-------------------------------SKU-------------------------------
        #endregion

        #region Physical Inventory
        public virtual DbSet<PhyInvEntity> PhyInv { get; set; }

        public DbSet<PhyInvPreCountSchedEntity> PhyInvPreCountScheds { get; set; }

        public DbSet<InventoryEntity> Inventories { get; set; }

        public DbSet<PhyInvsImportTempEntity> PhyInvsImportTemp { get; set; }
        #endregion

        #region Pack Down
        public virtual DbSet<PackDownEntity> PackDowns { get; set; }
        public virtual DbSet<ZoneEntity> Zones { get; set; }
        public virtual DbSet<BayEntity> Bays { get; set; }
        public virtual DbSet<HoleSKUEntity> HoleSKU { get; set; }
        #endregion
        
        public virtual DbSet<ReasonEntity> Reasons { get; set; }

        public DbSet<SystemLogEntity> SystemLogs { get; set; }

        public DbSet<PosDevCntrlEntity> PosDevCntrls { get; set; }

        #region Pricing Agreement
        public DbSet<PricingAgreementEntity> PricingAgreements { get; set; }
        public DbSet<SccAddressEntity> SccAddress { get; set; }
        public DbSet<SccRequirementEntity> SccRequirement { get; set; }
        public DbSet<ReceivingHoursEntity> ReceivingHours { get; set; }
        public DbSet<SccItemEntity> SccItems { get; set; }
        #endregion

        #region Label Printing
        //--------------------------Label Printing-------------------------------------
        public virtual DbSet<PrintingBatchHeaderEntity> PrintingBatchsHeader { get; set; }
        public virtual DbSet<PrintingBatchDetailEntity> PrintingBatchDetails { get; set; }
        public virtual DbSet<LabelPrintingConfigurationEntity> LabelPrintingConfiguration { get; set; }
        public DbSet<PrinterEntity> Printers { get; set; }
        public DbSet<LabelConfigurationEntity> LabelConfigurations { get; set; }
        // Label Type Dbset is in the SKU area
        //end-----------------------Label Printing-------------------------------------
        #endregion

        #region Installations
        public DbSet<InstallationPackEntity> InstallServiceHeaders { get; set; }

        public DbSet<InstallationPackDetailEntity> InstallServiceDetails { get; set; }

        public DbSet<InstallationRequestEntity> InstallRequests { get; set; }

        public DbSet<InstallationRequestDetailEntity> InstallRequestDetails { get; set; }

        public DbSet<InstallerEntity> Installers { get; set; }

        public DbSet<InstallerInvoiceEntity> InstallerInvoices { get; set; }

        public DbSet<InstallationAlertEntity> InstallationAlerts { get; set; }

        public DbSet<InstallationLogEntity> InstallationLogs { get; set; }

        public DbSet<UnitOfMeasureEntity> UnitsOfMeasure { get; set; }
        #endregion

        #region Customers
        public virtual DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProPriceEntity> ProPrices { get; set; }
        public virtual DbSet<CountryEntity> Countries { get; set; }
        #endregion

        #region Tender
        
        public DbSet<TenderTypeEntity> TenderTypes { get; set; }
        public DbSet<TenderEntity> Tenders { get; set; }
        
        #endregion

        #region Cash Management

        public DbSet<AcctPeriodEntity> AcctPeriod { get; set; }

        #endregion

        #region Cash Safe

        public DbSet<CmControlEntity> CmControl { get; set; }
        public DbSet<CmCurrencyEntity> CmCurrency { get; set; }
        public DbSet<CmSafeEntity> CmSafes { get; set; }
        public DbSet<CmPickupHeaderEntity> CmPickupHeaders { get; set; }
        public DbSet<CmPickupDetailEntity> CmPickupDetails { get; set; }
        public DbSet<CmDenominationEntity> CmDenominations { get; set; }
        public DbSet<CmTenderEntity> CmTenders { get; set; }
        public DbSet<CmTenderCurrencyDenominationEntity> CmTenderCurrencyDenominations { get; set; }
        public DbSet<CmBalanceHdrEntity> CmBalanceHeaders { get; set; }
        public DbSet<CmBalanceDtlEntity> CmBalanceDetails { get; set; }
        public DbSet<CmLoanEntity> CmLoans { get; set; }
        public DbSet<CmAdjustEntity> CmAdjusts { get; set; }
        public DbSet<CmDepositHeaderEntity> CmDepositHeader { get; set; }
        public DbSet<CmDepositDetailEntity> CmDepositDetail { get; set; }
        public DbSet<CmAuditEntity> CmAudit { get; set; }

        #endregion

        #region Labour Management
        public DbSet<LabourEntity> Labours { get; set; }
        #endregion

        #region Labor Schedule
        public virtual DbSet<CustomerServiceDemandEntity> CustomerServiceDemands { get; set; }
        #endregion

        #region EJournal
        public DbSet<EJournalItemEntity> EJournalItemEntities { get; set; }

        public DbSet<EJournalItemTenderEntity> EJournalItemTenderEntities { get; set; }

        public DbSet<EJournalItemTenderDataEntity> EJournalItemtenderDataEntities { get; set; }
        #endregion

        #region ZRead
        public virtual DbSet<ZReadEntity> ZReads { get; set; }

        public virtual DbSet<ZReadTenderTypeEntity> ZReadTenders { get; set; }
        #endregion

        public virtual DbSet<GeneratedScheduleDayEntity> GeneratedScheduleDays { get; set; } 

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<InventoryAdjustmentEntity> InventoryAdjustments { get; set; } // now is use on method CreateInventoryAdjustmentLogEntry in file StoreDataAccessService.PhyInvs.cs in future I will move this to a module

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            PhyInvConfiguration(modelBuilder);
            PhyInvPreCountSchedConfiguration(modelBuilder);
            InventoryConfiguration(modelBuilder);

            #region Pack Down
            ZoneConfiguration(modelBuilder);
            PackDownConfiguration(modelBuilder);
            BayConfiguration(modelBuilder);
            HoleSKUConfiguration(modelBuilder);
            #endregion

            #region POTracking
            //------------------------POTracking-----------------------------------------
            PoTrackingEntryConfiguration(modelBuilder);
            PoTrackingDetailConfiguration(modelBuilder);
            PoTrackingLogConfiguration(modelBuilder);
            PoTrackingEmailAttachmentConfiguration(modelBuilder);
            PoTrackingStateTypeConfiguration(modelBuilder);
            PoTrackingLogTypeConfiguration(modelBuilder);
            ResaleOrderDetailCancelledPoDetailConfiguration(modelBuilder);

            //old tables
            PurchaseOrderStateHistoriesConfiguration(modelBuilder);
            PurchaseOrderStateHistoryStatesConfiguration(modelBuilder);
            PurchaseOrderStateHistoryDetailConfiguration(modelBuilder);
            //end---------------------POTracking-----------------------------------------
            #endregion

            #region Purchase Order
            //------------------------PurchaseOrder-------------------------------------
            PurchaseOrderConfiguration(modelBuilder);
            PurchaseOrderItemConfiguration(modelBuilder);
            DestinationConfiguration(modelBuilder);
            PurchaseOrderCancelStatusConfiguration(modelBuilder);
            StatesConfiguration(modelBuilder);
            //end---------------------PurchaseOrder-------------------------------------
            #endregion

            #region Order
            //----------------------------------Order-------------------------------
            OrderConfiguration(modelBuilder);
            OrderItemConfiguration(modelBuilder);
            //end-------------------------------Order-------------------------------
            #endregion

            #region Sku
            //----------------------------------Sku-------------------------------
            ProductConfiguration(modelBuilder);
            LabelTypeConfiguration(modelBuilder);
            BarCodeConfiguration(modelBuilder);
            SkuLocationConfiguration(modelBuilder);
            PricePndHdrsConfiguration(modelBuilder);
            PricePndDtlsConfiguration(modelBuilder);
            CouponConfiguration(modelBuilder);
            PromotionConfiguration(modelBuilder);
            PromotionItemConfiguration(modelBuilder);
            ItemHistoryConfiguration(modelBuilder);
            ItemReplenConfiguration(modelBuilder);

            SkuKitConfiguration(modelBuilder);
            SkuKitItemConfiguration(modelBuilder);

            //end-------------------------------Sku-------------------------------
            #endregion

            #region Shipment
            //-------------------------------Shipment------------------------
            ShipMethodConfiguration(modelBuilder);
            //end----------------------------Shipment------------------------
            #endregion

            #region Withdrawal
            //------------------------Withdrawal-----------------------------------------
            WithdrawalConfiguration (modelBuilder);

            WithdrawalDenominationConfiguration (modelBuilder);

            DenominationConfiguration(modelBuilder);
        //END---------------------Withdrawal-----------------------------------------
        #endregion

            #region Employee

            DepositAggregationConfiguration(modelBuilder);
            EmployeeConfiguration(modelBuilder);
            EmployeeSalesConfiguration(modelBuilder);
            EmployeeTimeAndAttendanceConfiguration(modelBuilder);
            IncidentTypeConfiguration(modelBuilder);
            JobClassConfiguration(modelBuilder);
            ReasonTypeEntitiesConfiguration(modelBuilder);
            RequestAbsencesConfiguration(modelBuilder);

            #endregion

            DeparmentConfiguration(modelBuilder);
            DestinationStoreEntityConfiguration(modelBuilder);
            DiscrepancyAttachmentConfiguration(modelBuilder);
            DiscrepancyConfiguration(modelBuilder);
            DiscrepancyDetailConfiguration(modelBuilder);
            DistrictConfiguration(modelBuilder);
            FixedScheduleConfiguration(modelBuilder);
            FixedTimeOffConfiguration(modelBuilder);
            FobTermsConfiguration(modelBuilder);
            GeneratedSchedulesConfiguration(modelBuilder);
            InvoiceTermsConfiguration(modelBuilder);
            ItemVendorConfiguration(modelBuilder);
            PalletConfiguration(modelBuilder);
            PalletItemConfiguration(modelBuilder);
            PaymentMethodsConfiguration(modelBuilder);
            ReturnToVendorConfiguration(modelBuilder);
            ReturnToVendorItemConfiguration(modelBuilder);
            ReturnToVendorTypeConfiguration(modelBuilder);
            ReturnToVendorStatusConfiguration(modelBuilder);
            ShipmentConfiguration(modelBuilder);
            ShipmentItemConfiguration(modelBuilder);
            ShipMethodConfiguration(modelBuilder);
            ShipmentTypesConfiguration(modelBuilder);
            StoreConfiguration(modelBuilder);
            TaxesConfiguration(modelBuilder);
            TransferConfiguration(modelBuilder);
            TransferItemConfiguration(modelBuilder);
            VendorConfiguration(modelBuilder);
            VendorRTVConfigurationConfiguration(modelBuilder);
            VoucherReconcileConfiguration(modelBuilder);
            VoucherReconcileDetailsConfiguration(modelBuilder);          
            ReasonConfiguration(modelBuilder);
            SystemLogConfiguration(modelBuilder);
            PosDevCntrlConfiguration(modelBuilder);
            GeneratedScheduleDaysConfiguration(modelBuilder);
            CategoryConfiguration(modelBuilder);
            InventoryAdjustmentsConfiguration(modelBuilder);
            EmployeeAreaConfiguration(modelBuilder);
            
            #region Pricing Agreement
            PriceAgreementConfiguration(modelBuilder);
            SccAddressConfiguration(modelBuilder);
            SccRequirementConfiguration(modelBuilder);
            ReceivingHoursConfiguration(modelBuilder);
            ItemSccConfiguration(modelBuilder);
            #endregion

            #region Label Printing
            //------------------------Label Printing-----------------------------------------
            PrinterConfiguration(modelBuilder);
            LabelConfiguration(modelBuilder);
            PrintingBatchConfiguration(modelBuilder);
            // LabelTypeConfiguration method is in the SKU area
            //end---------------------Label Printing-----------------------------------------
            #endregion           

            #region Installations
            InstallServiceHeadersConfiguration(modelBuilder);
            InstallServiceDetailsConfiguration(modelBuilder);
            InstallRequestConfiguration(modelBuilder);
            InstallRequestDetailConfiguration(modelBuilder);
            InstallerConfiguration(modelBuilder);
            InstallerInvoiceConfiguration(modelBuilder);
            InstallationAlertConfiguration(modelBuilder);
            InstallationLogConfiguration(modelBuilder);
            UnitOfMeasureConfiguration(modelBuilder);
            #endregion

            #region Customers
            AuthrizdSignrConfiguration(modelBuilder);
            CustomerConfiguration(modelBuilder);
            ProPriceConfiguration(modelBuilder);
            CountryConfiguration(modelBuilder);
            #endregion

            #region Tender
            TenderTypeConfiguration(modelBuilder);
            TenderConfiguration (modelBuilder);
            #endregion

            #region Cash Management

            AcctPeriodConfiguration(modelBuilder);
            
           
            #endregion

            #region Physical Inventory

            PhyInvsImportTempConfiguration(modelBuilder);

            #endregion

            #region Labor Management
            
            LabourConfiguration(modelBuilder);
            WeekDaysConfiguration(modelBuilder);
            
            #endregion

            #region Labor Schedule

            CustomerServiceDemandConfiguration(modelBuilder);
            
            #endregion

            #region EJournal
            EJournalItemsConfiguration(modelBuilder);
            EJournalItemsTenderConfiguration(modelBuilder);
            EJournalItemsTenderDataConfiguration(modelBuilder);
            #endregion

            #region Cash Safe

            CmCurrenciesConfiguration(modelBuilder);
            CmSafeConfiguration(modelBuilder);
            CmPickupHeadersConfiguration(modelBuilder);
            CmPickupDetailsConfiguration(modelBuilder);
            CmDenominationsConfiguration(modelBuilder);
            CmTendersConfiguration(modelBuilder);
            CmTenderCurrencyDenominationsConfiguration(modelBuilder);
            CmBalanceHdrConfiguration(modelBuilder);
            CmBalanceDtlConfiguration(modelBuilder);
            CmLoanConfiguration(modelBuilder);
            CmControlConfiguration(modelBuilder);
            CmAdjustConfiguration(modelBuilder);
            CmDepositHeaderConfiguration(modelBuilder);
            CmDepositDetailConfiguration(modelBuilder);
            CmAuditConfiguration(modelBuilder);
            
            #endregion  

            ZReadConfiguration(modelBuilder);
            ZReadTenderTypeConfiguration(modelBuilder);
        }

        public long GenerateIdentity(string tableName)
        {
            var sqlConnection = new SqlConnection(Database.Connection.ConnectionString);
            var cmd = new SqlCommand
            {
                CommandText = "TakeANumber",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };

            cmd.Parameters.AddWithValue("@RecordName", tableName);
            sqlConnection.Open();

            var res = cmd.ExecuteScalar();
            var result = long.Parse(res.ToString(), NumberStyles.Integer);

            sqlConnection.Close();
            return result;
        }
        
    }
}
