using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using Mi9.Store.Entities.Entities;

namespace Mi9.Store.Entities
{
    public partial class DataContext
    {
        #region PackDown
        private static void PackDownConfiguration(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<PackDownEntity>().ToTable("PackDowns");
            modelbuilder.Entity<PackDownEntity>()
                .HasRequired<ItemReplenEntity>(p => p.ItemReplen)
                .WithMany(i => i.PackDowns)
                .HasForeignKey(p => p.SKU);

            modelbuilder.Entity<PackDownEntity>()
                            .HasRequired<BayEntity>(p => p.Bay)
                            .WithMany(b => b.PackDowns)
                            .HasForeignKey(p => p.BayId);
        }
        private static void BayConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BayEntity>().ToTable("Bays");
            modelBuilder.Entity<BayEntity>().HasMany(m => m.SkuLocations);
        }
        private static void ZoneConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZoneEntity>().ToTable("Zones");
            modelBuilder.Entity<ZoneEntity>().HasKey(m => m.Id);
            modelBuilder.Entity<ZoneEntity>().HasMany(m => m.Bays).WithRequired(m => m.Zone).HasForeignKey(m => m.ZoneId);
        }
        private void HoleSKUConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoleSKUEntity>().ToTable("HoleSKU");
            modelBuilder.Entity<HoleSKUEntity>().HasKey(m => m.Id)
                .Property(m => m.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
        #endregion
        
        #region POTracking
        //------------------------POTracking-----------------------------------------
        private static void PoTrackingEntryConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoTrackingEntryEntity>().ToTable("POTrackingEntries");
            modelBuilder.Entity<PoTrackingEntryEntity>().HasKey(m => m.PONumber).Property(m => m.PONumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<PoTrackingEntryEntity>().HasRequired(m => m.PurchaseOrder).WithOptional(m => m.PoTracking);
            modelBuilder.Entity<PoTrackingEntryEntity>().HasMany(m => m.States).WithRequired(m => m.PoTrackingEntry);
            modelBuilder.Entity<PoTrackingEntryEntity>().HasMany(m => m.Logs).WithRequired(m => m.PoTrackingEntry);
            modelBuilder.Entity<PoTrackingEntryEntity>().HasMany(m => m.Attachments).WithRequired(m => m.PoTrackingEntry);
        }
        private static void PoTrackingDetailConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoTrackingDetailEntity>().ToTable("POTrackingDetails");
            modelBuilder.Entity<PoTrackingDetailEntity>().HasKey(m => m.Id).Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<PoTrackingDetailEntity>().HasRequired(m => m.PoTrackingEntry).WithMany(m => m.States).HasForeignKey(m => m.PONumber);
            modelBuilder.Entity<PoTrackingDetailEntity>().HasRequired(m => m.State).WithMany().HasForeignKey(m => m.StateId);
        }
        private static void PoTrackingLogConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoTrackingLogEntity>().ToTable("POTrackingLogs");
            modelBuilder.Entity<PoTrackingLogEntity>().HasKey(m => m.Id).Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<PoTrackingLogEntity>().HasRequired(m => m.PoTrackingEntry).WithMany(m => m.Logs).HasForeignKey(m => m.PONumber);
            modelBuilder.Entity<PoTrackingLogEntity>().HasRequired(m => m.State).WithMany().HasForeignKey(m => m.StateId);
            modelBuilder.Entity<PoTrackingLogEntity>().HasRequired(m => m.LogType).WithMany().HasForeignKey(m => m.TypeId);
        }
        private static void PoTrackingEmailAttachmentConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoTrackingEmailAttachmentEntity>().ToTable("POTrackingEmailAttachments");
            modelBuilder.Entity<PoTrackingEmailAttachmentEntity>().HasKey(m => m.Id).Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<PoTrackingEmailAttachmentEntity>().HasRequired(m => m.PoTrackingEntry).WithMany(m => m.Attachments).HasForeignKey(m => m.PONumber);
        }
        private static void PoTrackingStateTypeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoTrackingStateEntity>().ToTable("POTrackingStates");
            modelBuilder.Entity<PoTrackingStateEntity>().HasKey(m => m.Code).Property(m => m.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
        private static void PoTrackingLogTypeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoTrackingLogTypeEntity>().ToTable("POTrackingLogTypes");
            modelBuilder.Entity<PoTrackingLogTypeEntity>().HasKey(m => m.Code).Property(m => m.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
        
        //old tables
        private void PurchaseOrderStateHistoriesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpecialOrderEntity>().ToTable("potracking");

            modelBuilder.Entity<SpecialOrderEntity>()
               .HasKey(t => t.PurchaseOrderNumber)
               .Property(t => t.PurchaseOrderNumber)
               .HasColumnName("PONumber")
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<SpecialOrderEntity>()
               .Property(t => t.Status)
               .HasColumnName("Estado")
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).IsRequired();
            modelBuilder.Entity<SpecialOrderEntity>()
               .Property(t => t.CancelStatus)
               .HasColumnName("Estado_Alt")
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None).IsRequired();

            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.ConfirmUser).IsRequired();
            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.ReadyUser).IsRequired();
            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.TransitUser).IsRequired();

            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.ConfirmName).IsRequired();
            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.ReadyName).IsRequired();
            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.TransitName).IsRequired();
            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.ReceiveName).IsRequired();
            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.DeliveryName).IsRequired();

            modelBuilder.Entity<SpecialOrderEntity>().Property(t => t.Comment).IsRequired();
        }

        private void PurchaseOrderStateHistoryStatesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrderStateHistoryStateEntity>().ToTable("STORE_POStates");
            modelBuilder.Entity<PurchaseOrderStateHistoryStateEntity>().HasKey(t => t.Id);
            
            modelBuilder.Entity<PurchaseOrderStateHistoryStateEntity>()
                .HasMany(t => t.PurchaseOrderStateHistories)
                .WithOptional(t => t.State)
                .HasForeignKey(t => t.StateId);
        }

        private void PurchaseOrderStateHistoryDetailConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>().ToTable("bitracking");
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>().Property(t => t.PurchaseNumber).HasColumnName("PONumber");
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>().Property(t => t.Step).HasColumnName("Seqn");
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>().Property(t => t.Status).HasColumnName("Estado");
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>().Property(t => t.Type).HasColumnName("Tipo");
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>().Property(t => t.Title).HasColumnName("Nombre");
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>().HasKey(t => new { t.PurchaseNumber, t.Step });
            modelBuilder.Entity<PurchaseOrderStateHistoryDetailEntity>()
                .HasOptional(t => t.State)
                .WithMany(t => t.PurchaseOrderStateHistoryDetails)
                .HasForeignKey(t => t.StateId);
        }

        private static void ResaleOrderDetailCancelledPoDetailConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResaleOrderDetailCancelledPoDetail>().ToTable("ResaleOrderDetailCancelledPoDetails");
            modelBuilder.Entity<ResaleOrderDetailCancelledPoDetail>().HasKey(t => new { t.OrderNumber, t.PONumber, t.Sku });
            modelBuilder.Entity<ResaleOrderDetailCancelledPoDetail>().Property(t => t.OrderNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<ResaleOrderDetailCancelledPoDetail>().Property(t => t.PONumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<ResaleOrderDetailCancelledPoDetail>().Property(t => t.Sku).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        //end---------------------POTracking-----------------------------------------
        #endregion

        #region Orders
        //----------------------------------Order-------------------------------
        private static void OrderConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>().ToTable("OrderHeader");
            modelBuilder.Entity<OrderEntity>().HasKey(t => t.OrderNumber).Property(t => t.OrderNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<OrderEntity>().Ignore(t => t.WasValidatedAtPOS);
            modelBuilder.Entity<OrderEntity>().Ignore(t => t.LastValidationDate);

            modelBuilder.Entity<OrderEntity>().HasRequired(t => t.Employee).WithMany().HasForeignKey(t => t.EmployeeNo);
            modelBuilder.Entity<OrderEntity>().HasRequired(t => t.CommEmployee).WithMany().HasForeignKey(t => t.CommissEmp);
            modelBuilder.Entity<OrderEntity>().HasMany(t => t.OrderItems).WithRequired(t => t.Order).HasForeignKey(t => t.OrderNumber);
            modelBuilder.Entity<OrderEntity>().HasRequired(t => t.Customer).WithMany(t => t.Orders).HasForeignKey(t => new { t.AccountNo, t.SubAccount });
            modelBuilder.Entity<OrderEntity>().HasOptional(t => t.DeliveryCustomer).WithMany(t => t.DeliveryOrders).HasForeignKey(t => new { t.DeliveryAccountNo, t.DeliverySubAccount });
            modelBuilder.Entity<OrderEntity>().HasOptional(t => t.OrderDefinition).WithMany(t => t.Orders).HasForeignKey(t => t.DefinitionId);
            modelBuilder.Entity<OrderEntity>().HasOptional(t => t.PricingAgreement).WithMany(t => t.Orders).HasForeignKey(t => t.SccId);
            modelBuilder.Entity<OrderEntity>().HasOptional(t => t.ShipToState).WithMany(t => t.ShipOrders).HasForeignKey(t => t.ShipToStateId);
            modelBuilder.Entity<OrderEntity>().HasOptional(t => t.SoldToState).WithMany(t => t.SoldOrders).HasForeignKey(t => t.SoldToStateId);

            modelBuilder.Entity<OrderEntity>().Property(t => t.Cobertura).HasColumnName("ChequeValidationNumber").HasMaxLength(6);
            modelBuilder.Entity<OrderEntity>().Property(t => t.PreCheckoutCardNumber).HasColumnName("PreCheckoutCardNo").HasMaxLength(19).IsRequired();
            modelBuilder.Entity<OrderEntity>().Property(t => t.ShipToStateId).HasColumnName("ShipToState").HasMaxLength(3);
            modelBuilder.Entity<OrderEntity>().Property(t => t.SoldToStateId).HasColumnName("SoldToState").HasMaxLength(3);
            OrderHeaderIgnore(modelBuilder);
        }

        private static void OrderHeaderIgnore(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEntity>().Ignore(t => t.WasValidatedAtPOS);
            modelBuilder.Entity<OrderEntity>().Ignore(t => t.LastValidationDate);
        }

        private static void OrderItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItemEntity>().ToTable("OrderDetail");
            modelBuilder.Entity<OrderItemEntity>().HasKey(t => new { t.OrderNumber, t.OrdSeqNumber });
            modelBuilder.Entity<OrderItemEntity>().Property(t => t.FeeCode).HasColumnName("MiscAcct");
            modelBuilder.Entity<OrderItemEntity>().Property(t => t.InstallationPackId).HasColumnName("ServhdrID");
            modelBuilder.Entity<OrderItemEntity>().Property(t => t.InstallationPackServiceSequence).HasColumnName("ServSeq");
            modelBuilder.Entity<OrderItemEntity>().Property(t => t.InstallationServiceId).HasColumnName("ServiceID");
            modelBuilder.Entity<OrderItemEntity>().Property(t => t.TaxRate).HasPrecision(5, 3);

            modelBuilder.Entity<OrderItemEntity>()
                .HasOptional(t => t.ItemSku)
                .WithMany(t => t.OrderItems)
                .HasForeignKey(t => t.SKU);

            modelBuilder.Entity<OrderItemEntity>()
              .HasOptional(t => t.Fee)
              .WithMany(t => t.OrderItems)
              .HasForeignKey(t => t.FeeCode);

            modelBuilder.Entity<OrderItemEntity>()
              .HasOptional(t => t.InstallationPackDetail)
              .WithMany(t => t.OrderItems)
              .HasForeignKey(t => new { t.InstallationPackId, t.InstallationPackServiceSequence });

            modelBuilder.Entity<OrderItemEntity>()
                        .HasOptional(t => t.RefundedInstallationRequest)
                        .WithMany()
                        .HasForeignKey(s => s.RefundedRequestId);


            OrderDetailIgnore(modelBuilder);
        }

        private static void OrderDetailIgnore(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItemEntity>().Ignore(t => t.DumpAdjustType);
        }

        //end-------------------------------Order-------------------------------
        #endregion

        #region Purchase Order
        //------------------------PurchaseOrder-------------------------------------
        private static void PurchaseOrderConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrderEntity>().ToTable("POHeader");
            modelBuilder.Entity<PurchaseOrderEntity>().HasKey(m => m.PurchaseOrderNumber).Property(m => m.PurchaseOrderNumber).HasColumnName("PONumber").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<PurchaseOrderEntity>().HasMany(m => m.PurchaseOrderItems).WithRequired(m => m.PurchaseOrder).HasForeignKey(m => m.PurchaseOrderNumber);
            modelBuilder.Entity<PurchaseOrderEntity>().HasMany(m => m.Shipments).WithOptional(m => m.PurchaseOrder).HasForeignKey(m => m.PurchaseOrderNumber);
            modelBuilder.Entity<PurchaseOrderEntity>().HasMany(m => m.Discrepancies).WithOptional(m => m.PurchaseOrder).HasForeignKey(m => m.PONumber);

            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.PoTracking).WithRequired(m => m.PurchaseOrder);
            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.Vendor).WithMany(m => m.PurchaseOrders).HasForeignKey(m => new { m.VendorId, m.VendorSuffix });
            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.Destination).WithMany(m => m.PurchaseOrders).HasForeignKey(m => m.DestinationCode);
            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.Department).WithMany(m => m.PurchaseOrders).HasForeignKey(m => m.DepartmentId);
            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.Employee).WithMany(m => m.PurchaseOrders).HasForeignKey(m => m.BuyingDiv);
            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.SettlementTerm).WithMany(m => m.PurchaseOrders).HasForeignKey(m => m.SettlementTermId);
            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.PaymentMethod).WithMany().HasForeignKey(m => m.PaymentMethodId);
            modelBuilder.Entity<PurchaseOrderEntity>().HasOptional(m => m.CustomerOrder);

            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.DepartmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.DestinationCode).HasColumnName("Destcode");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.CancellationDate).HasColumnName("ExpectDate");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.CreatedDate).HasColumnName("CreateDate");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.OrderDate).HasColumnName("TransmitDate");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.CountryState).HasColumnName("State");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.VendorId).HasColumnName("VendorID");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.ShippingInstructions).HasColumnName("ShipInst");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.Type).HasColumnName("POType").HasMaxLength(1);
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.Status).HasColumnName("POStatus").HasMaxLength(1);
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.PaymentMethodId).HasColumnName("PayMethodCode").HasMaxLength(4);
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.SettlementTermId).HasColumnName("SettleTermCode").HasMaxLength(4);
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.PoTypeId).HasColumnName("POTypeCode");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.FobTermId).HasColumnName("FOBCode").HasMaxLength(4);
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.SpecialInstructions1).HasColumnName("SpecInst1").HasMaxLength(82);
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.SpecialInstructions2).HasColumnName("SpecInst2").HasMaxLength(82);
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.ShipVia).HasColumnName("OrderInst");
            modelBuilder.Entity<PurchaseOrderEntity>().Property(m => m.DeliveryDate).HasColumnName("ShpToArvDate");
        }

        private static void PurchaseOrderItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrderItemEntity>().ToTable("PODetail");
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.PurchaseOrderNumber).HasColumnName("PONumber").HasMaxLength(11);
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.PurchaseOrderSeqNumber).HasColumnName("SeqNo");
            modelBuilder.Entity<PurchaseOrderItemEntity>().HasKey(m => new { m.PurchaseOrderNumber, m.PurchaseOrderSeqNumber });

            modelBuilder.Entity<PurchaseOrderItemEntity>().HasRequired(m => m.PurchaseOrder).WithMany(m => m.PurchaseOrderItems).HasForeignKey(m =>  m.PurchaseOrderNumber);
            modelBuilder.Entity<PurchaseOrderItemEntity>().HasRequired(m => m.ItemSku).WithMany(m => m.PurchaseOrderItems).HasForeignKey(m => m.SKU);
            modelBuilder.Entity<PurchaseOrderItemEntity>().HasOptional(m => m.Category).WithMany(m => m.PurchaseOrderItems).HasForeignKey(m => new { m.DepartmentId, m.ClassId, m.SubClass });
            modelBuilder.Entity<PurchaseOrderItemEntity>().HasOptional(m => m.Pallet).WithMany().HasForeignKey(m => m.PalletID);

            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.Description).HasColumnName("ItemDesc").HasMaxLength(35);
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.VendorUOM).HasColumnName("VendUOM").HasMaxLength(4);
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.UnitCost).HasColumnName("UnitCost").HasPrecision(11, 4);
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.CollectCost).HasColumnName("CollectCost").HasPrecision(11, 4);
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.PrepaidCost).HasColumnName("PrepaidCost").HasPrecision(11, 4);
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.UnitFreight).HasColumnName("UnitFreight").HasPrecision(11, 4);
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.DepartmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<PurchaseOrderItemEntity>().Property(m => m.ClassId).HasColumnName("ClassNo");
        }
        private static void DestinationConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationEntity>().ToTable("Destiny");
            modelBuilder.Entity<DestinationEntity>().HasKey(m => m.DestinationCode).Property(m => m.DestinationCode).HasColumnName("Destcode").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<DestinationEntity>().HasMany(m => m.PurchaseOrders).WithOptional(m => m.Destination).HasForeignKey(m => m.DestinationCode);

            modelBuilder.Entity<DestinationEntity>().Property(t => t.Zip).HasMaxLength(10);
            modelBuilder.Entity<DestinationEntity>().Property(t => t.State).HasMaxLength(3);
        }

        private static void PurchaseOrderCancelStatusConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrderCancelStatusEntity>().ToTable("POTrackingCancelStatuses");
            modelBuilder.Entity<PurchaseOrderCancelStatusEntity>().HasKey(m => m.Code).Property(m => m.Code).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        private void StatesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateEntity>().ToTable("state");
            modelBuilder.Entity<StateEntity>().HasKey(t => t.Id).Property(t => t.Id).HasColumnName("State").HasMaxLength(3);
            modelBuilder.Entity<StateEntity>().Property(t => t.StateName).HasMaxLength(15);
        }

        //end---------------------PurchaseOrder-------------------------------------
        #endregion

        #region Department
        //------------------------Department-----------------------------------------       
        private void DeparmentConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentEntity>().ToTable("Dept");
            modelBuilder.Entity<DepartmentEntity>()
                        .HasKey(t => t.DepartmentId)
                        .Property(t => t.DepartmentId)
                        .HasColumnName("DeptNo");
            modelBuilder.Entity<DepartmentEntity>().Property(t => t.Description).IsRequired().HasMaxLength(20);

            modelBuilder.Entity<DepartmentClassEntity>().ToTable("DeptClass");
            modelBuilder.Entity<DepartmentClassEntity>().Property(t => t.ClassId).HasColumnName("ClassNo");
            modelBuilder.Entity<DepartmentClassEntity>().Property(t => t.DepartmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<DepartmentClassEntity>().Property(t => t.Description).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<DepartmentClassEntity>().HasKey(t => new { t.DepartmentId, t.ClassId });
            modelBuilder.Entity<DepartmentClassEntity>()
                        .HasRequired(t => t.Department)
                        .WithMany(t => t.DepartmentClasses)
                        .HasForeignKey(t => t.DepartmentId);
            modelBuilder.Entity<DepartmentClassEntity>()
                        .HasMany(s => s.InstallationPacks)
                        .WithRequired(s => s.DepartmentClass)
                        .HasForeignKey(s => new { s.DepartmentId, s.ClassId });
            modelBuilder.Entity<DepartmentClassEntity>()
                        .HasMany(t => t.EligibleInstallers)
                        .WithMany(s => s.DepartmentClasses)
                        .Map(x =>
                        {
                            x.ToTable("InstClass");
                            x.MapLeftKey("DeptNo", "ClassNo");
                            x.MapRightKey("installerID");
                        });

            modelBuilder.Entity<DepartmentSubClassEntity>().ToTable("DeptSubClass");
            modelBuilder.Entity<DepartmentSubClassEntity>().Property(t => t.ClassId).HasColumnName("ClassNo");
            modelBuilder.Entity<DepartmentSubClassEntity>().Property(t => t.DepartmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<DepartmentSubClassEntity>().Property(t => t.SubClassId).HasColumnName("SubClass");
            modelBuilder.Entity<DepartmentSubClassEntity>().Property(t => t.Description).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<DepartmentSubClassEntity>().HasKey(t => new { t.DepartmentId, t.ClassId, t.SubClassId });
            modelBuilder.Entity<DepartmentSubClassEntity>()
                        .HasRequired(t => t.Department)
                        .WithMany(t => t.DepartmentSubClasses)
                        .HasForeignKey(t => t.DepartmentId);
            modelBuilder.Entity<DepartmentSubClassEntity>()
                        .HasRequired(t => t.DeparmentClass)
                        .WithMany(t => t.DepartmentSubClasses)
                        .HasForeignKey(t => new { t.DepartmentId, t.ClassId }).WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemKeyWordEntity>().ToTable("ItemKeyWord");
            modelBuilder.Entity<ItemKeyWordEntity>()
                        .HasKey(t => t.UserLookup)
                        .Property(t => t.UserLookup)
                        .HasMaxLength(15);
            modelBuilder.Entity<ItemKeyWordEntity>().Property(t => t.DeparmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<ItemKeyWordEntity>()
                        .HasRequired(t => t.Deparment)
                        .WithMany(t => t.KeyWords)
                        .HasForeignKey(t => t.DeparmentId);
        }

        //END---------------------Department-----------------------------------------
        #endregion

        #region Discrepancy
        //------------------------Discrepancy-----------------------------------------
        private static void DiscrepancyAttachmentConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscrepancyAttachmentEntity>()
                .ToTable("DiscrepancyAttachments")
                .HasKey(m => m.Id)
                .HasRequired(m => m.DiscrepancyDetail).WithMany(m => m.Attachments)
                .HasForeignKey(d => d.DiscrepancyDetailId);

            modelBuilder.Entity<DiscrepancyAttachmentEntity>().HasKey(m => m.Id).Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }

        private void DiscrepancyConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscrepancyEntity>()
                .ToTable("Discrepancies")
                .HasKey(m => m.DiscrepancyNumber)
                .Property(m => m.DiscrepancyNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<DiscrepancyEntity>()
                .HasOptional(d => d.PurchaseOrder).WithMany(p => p.Discrepancies)
                .HasForeignKey(d => d.PONumber);

            modelBuilder.Entity<DiscrepancyEntity>()
                .HasOptional(d => d.Shipment).WithMany(s => s.Discrepancies)
                .HasForeignKey(d => d.ShipmentNumber);

            modelBuilder.Entity<DiscrepancyEntity>()
                .HasOptional(d => d.Transfer).WithMany(t => t.Discrepancies)
                .HasForeignKey(d => d.TransferNumber);

        }

        private static void DiscrepancyDetailConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscrepancyDetailEntity>()
                .ToTable("DiscrepancyLines")
                .HasKey(m => m.Id)
                .HasRequired(m => m.Discrepancy).WithMany(m => m.Details)
                .HasForeignKey(d => d.DiscrepancyNumber);

            modelBuilder.Entity<DiscrepancyDetailEntity>().HasKey(m => m.Id).Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<DiscrepancyDetailEntity>()
                .HasRequired(d => d.ItemSkuEntity)
                .WithMany()
                .HasForeignKey(d => d.SKU);

            modelBuilder.Entity<DiscrepancyDetailEntity>()
                .HasOptional(d => d.Pallet)
                .WithMany()
                .HasForeignKey(d => d.PalletId);
        }
        //END---------------------Discrepancy-----------------------------------------
        #endregion

        #region Employee
        //------------------------Employee-----------------------------------------
        private void DepositAggregationConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepositAggregationEntity>().ToTable("STORE_DepositAggregations");
            modelBuilder.Entity<DepositAggregationEntity>().HasKey(s => s.AggregationId);
            modelBuilder.Entity<DepositAggregationEntity>().Property(s => s.Amount).HasPrecision(19, 2);
            modelBuilder.Entity<DepositAggregationEntity>().Property(s => s.Comment).HasMaxLength(255);

            modelBuilder.Entity<DepositAggregationEntity>()
                        .HasRequired(s => s.Employee)
                        .WithMany(s => s.DepositAggregations)
                        .HasForeignKey(s => s.EmployeeNo);

            modelBuilder.Entity<DepositAggregationEntity>()
                        .HasOptional(s => s.Carrier)
                        .WithMany(s => s.DepositAggregations)
                        .HasForeignKey(s => s.CarrierId);

            modelBuilder.Entity<DepositAggregationEntity>()
                        .HasOptional(s => s.Tender)
                        .WithMany(s => s.DepositAggregations)
                        .HasForeignKey(s => s.TenderId);

            modelBuilder.Entity<DepositAggregationEntity>()
                        .HasRequired(s => s.TenderType)
                        .WithMany(s => s.DepositAggregations)
                        .HasForeignKey(s => s.TenderCode);
        }

        private void EmployeeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeEntity>().ToTable("Employee");
            modelBuilder.Entity<EmployeeEntity>().HasKey(t => t.EmployeeNo);
            modelBuilder.Entity<EmployeeEntity>().HasOptional(t => t.JobClass).WithMany(t => t.Employees).HasForeignKey(t => t.JobClassId);
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.EmployeeNo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<EmployeeEntity>().HasMany(t => t.Days).WithRequired(t => t.Employee).HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<EmployeeEntity>().HasMany(t => t.RequestAbsences).WithRequired(t => t.Employee).HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<EmployeeEntity>().HasMany(t => t.EmployeeAreas).WithRequired(t => t.Employee).HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<EmployeeEntity>().HasMany(t => t.EmployeeSales).WithRequired(t => t.Employee).HasForeignKey(t => t.EmployeeNo);
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.JobClassId).HasColumnName("JobClass");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.FirstName).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.MiddleName).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.LastName).HasMaxLength(15).IsRequired();
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.TABadge).IsRequired().HasMaxLength(11);
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.Status).HasColumnName("EmpStatus");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.PostalCode).HasColumnName("Zip");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.Phone).HasColumnName("HomePhone");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.Initials).HasColumnName("Initials");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.SocialSecurityNumber).HasColumnName("SocialSec");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.NewContract).HasColumnName("NewHire");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.AddressLine1).HasColumnName("Addr1");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.AddressLine2).HasColumnName("Addr2");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.SecurityNumber).HasColumnName("Security");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.IsSupervisor).HasColumnName("OnCommission");
            modelBuilder.Entity<EmployeeEntity>().Property(t => t.CashInDrawer).HasColumnName("CashInDrawer");
        }

        public void EmployeeSalesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeSalesEntity>().ToTable("EmployeeSales");
            modelBuilder.Entity<EmployeeSalesEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<EmployeeSalesEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<EmployeeSalesEntity>().HasRequired(t => t.Employee).WithMany(t => t.EmployeeSales).HasForeignKey(t => t.EmployeeNo);
            modelBuilder.Entity<EmployeeSalesEntity>().Property(t => t.SalesActive).HasColumnName("SalesAcctFlg").HasMaxLength(1).IsFixedLength().IsUnicode(false);
            modelBuilder.Entity<EmployeeSalesEntity>().Property(t => t.Divide).HasColumnName("DividedFlag");

            modelBuilder.Entity<EmployeeSalesEntity>().Property(t => t.AreaId).HasColumnName("AreaAssigned");
            modelBuilder.Entity<EmployeeSalesEntity>().Property(t => t.AreaPercent).HasColumnName("AreaPercent");
            modelBuilder.Entity<EmployeeSalesEntity>().Property(t => t.DepartmentId).HasColumnName("GLDeptAssign");
            modelBuilder.Entity<EmployeeSalesEntity>().Property(t => t.DepartmentPercent).HasColumnName("GLDeptPcnt");
        }

        private void EmployeeTimeAndAttendanceConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeTimeAttendanceEntity>().ToTable("STORE_EmployeeTimeAttendances");
            modelBuilder.Entity<EmployeeTimeAttendanceEntity>().HasKey(t => t.AttendanceId);
            modelBuilder.Entity<EmployeeTimeAttendanceEntity>().Property(t => t.TABadge).HasMaxLength(11);
        }

        private void IncidentTypeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncidentTypeEntity>().ToTable("STORE_IncidentTypes");
            modelBuilder.Entity<IncidentTypeEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<IncidentTypeEntity>().Property(t => t.Name).IsRequired();
            modelBuilder.Entity<IncidentTypeEntity>().Property(x => x.Description).HasMaxLength(50);
        }

        private void JobClassConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobClassEntity>().ToTable("jobclass");
            modelBuilder.Entity<JobClassEntity>().HasKey(t => t.JobClassId).Property(t => t.JobClassId).HasColumnName("JobClass");
            modelBuilder.Entity<JobClassEntity>().Property(t => t.JobDescription).HasColumnName("JobDesc").HasMaxLength(25);
            modelBuilder.Entity<JobClassEntity>().Property(t => t.JobCode).HasColumnName("JobCode");
            modelBuilder.Entity<JobClassEntity>().Property(t => t.JobType).HasColumnName("JobType").HasMaxLength(1);
        }

        private void ReasonTypeEntitiesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReasonTypeEntity>().ToTable("STORE_Reasons");
            modelBuilder.Entity<ReasonTypeEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<ReasonTypeEntity>().Property(t => t.Name).IsRequired();
            modelBuilder.Entity<ReasonTypeEntity>().HasMany(t => t.RequestAbsences).WithRequired(t => t.ReasonType).HasForeignKey(t => t.ReasonId);
        }

        private void RequestAbsencesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestAbsenceEntity>().ToTable("STORE_EventRequests");
            modelBuilder.Entity<RequestAbsenceEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<RequestAbsenceEntity>().HasRequired(t => t.Employee).WithMany(t => t.RequestAbsences).HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<RequestAbsenceEntity>().HasRequired(t => t.ReasonType).WithMany(t => t.RequestAbsences).HasForeignKey(t => t.ReasonId);
        }

        private void WeekDaysConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeekDayEntity>().ToTable("STORE_Incidents");
            modelBuilder.Entity<WeekDayEntity>().HasKey(t => new { t.EmployeeId, t.Date });
            modelBuilder.Entity<WeekDayEntity>().HasRequired(t => t.Employee).WithMany(t => t.Days).HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<WeekDayEntity>().HasOptional(t => t.IncidentType).WithMany(t => t.Days).HasForeignKey(t => t.IncidentId);
        }

        public void EmployeeAreaConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeAreaEntity>().ToTable("Area");
            modelBuilder.Entity<EmployeeAreaEntity>().HasKey(t => t.Id).Property(t => t.Id).HasColumnName("AreaNo");
            modelBuilder.Entity<EmployeeAreaEntity>().HasRequired(t => t.Employee).WithMany(t => t.EmployeeAreas).HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.Description).HasColumnName("AreaDesc");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.Type).HasColumnName("AreaType").HasMaxLength(1).IsFixedLength().IsUnicode(false);
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.EmployeeId).HasColumnName("AreaDSM");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.OriginalAreaId).HasColumnName("OrigAreaNo");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea1).HasColumnName("DeptInArea__1");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea2).HasColumnName("DeptInArea__2");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea3).HasColumnName("DeptInArea__3");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea4).HasColumnName("DeptInArea__4");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea5).HasColumnName("DeptInArea__5");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea6).HasColumnName("DeptInArea__6");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea7).HasColumnName("DeptInArea__7");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea8).HasColumnName("DeptInArea__8");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea9).HasColumnName("DeptInArea__9");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea10).HasColumnName("DeptInArea__10");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea11).HasColumnName("DeptInArea__11");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea12).HasColumnName("DeptInArea__12");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea13).HasColumnName("DeptInArea__13");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea14).HasColumnName("DeptInArea__14");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea15).HasColumnName("DeptInArea__15");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea16).HasColumnName("DeptInArea__16");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea17).HasColumnName("DeptInArea__17");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea18).HasColumnName("DeptInArea__18");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea19).HasColumnName("DeptInArea__19");
            modelBuilder.Entity<EmployeeAreaEntity>().Property(t => t.DepartmentInArea20).HasColumnName("DeptInArea__20");
        }
        //END---------------------Employee-----------------------------------------
        #endregion

        #region Schedules
        //------------------------Schedules-----------------------------------------
        private void FixedScheduleConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FixedScheduleEntity>().ToTable("STORE_FixedSchedules");
            modelBuilder.Entity<FixedScheduleEntity>().HasKey(t => new { t.EmployeeId, t.DayOfWeek, t.HourOfDay });
            modelBuilder.Entity<FixedScheduleEntity>()
                .HasRequired(t => t.Employee)
                .WithMany(t => t.FixedSchedule)
                .HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<FixedScheduleEntity>()
                .HasOptional(t => t.ReasonType)
                .WithMany(t => t.FixedSchedules)
                .HasForeignKey(t => t.ReasonId);
        }

        private void FixedTimeOffConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FixedTimeOffEntity>().ToTable("STORE_FixedTimeOffs");
            modelBuilder.Entity<FixedTimeOffEntity>().HasKey(t => new { t.EmployeeId, t.DayOfWeek });

            modelBuilder.Entity<FixedTimeOffEntity>()
              .HasRequired(t => t.Employee)
              .WithMany(t => t.TimeOffs)
              .HasForeignKey(t => t.EmployeeId);
        }

        private void GeneratedSchedulesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeneratedScheduleEntity>().ToTable("STORE_GeneratedSchedules");
            modelBuilder.Entity<GeneratedScheduleEntity>().HasKey(t => new { t.EmployeeId, t.Date, t.HourOfDay });
            modelBuilder.Entity<GeneratedScheduleEntity>()
                .HasOptional(t => t.ReasonType)
                .WithMany(t => t.GeneratedSchedules)
                .HasForeignKey(t => t.ReasonId);
            modelBuilder.Entity<GeneratedScheduleEntity>()
                .HasRequired(t => t.Employee)
                .WithMany(t => t.GeneratedSchedules)
                .HasForeignKey(t => t.EmployeeId);

            modelBuilder.Entity<SuggestedScheduleEntity>().ToTable("STORE_GeneratedSchedulesSuggested");
            modelBuilder.Entity<SuggestedScheduleEntity>().HasKey(g => new { g.EmployeeId, g.Date, g.HourOfDay });
        }
        //END---------------------Schedules-----------------------------------------
        #endregion

        #region Shipment
        //------------------------Shipment-----------------------------------------
        private void ShipmentConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipmentEntity>().ToTable("ShipmentHeader");
            modelBuilder.Entity<ShipmentEntity>().HasKey(x => x.ShipmentNumber);

            modelBuilder.Entity<ShipmentEntity>().Property(x => x.ShipmentNumber).HasMaxLength(11);
            modelBuilder.Entity<ShipmentEntity>().Property(x => x.Status).HasMaxLength(1);
            modelBuilder.Entity<ShipmentEntity>().Property(x => x.AuditStatus).HasMaxLength(1);
            modelBuilder.Entity<ShipmentEntity>().Property(x => x.TransferNumber).HasMaxLength(11);
            modelBuilder.Entity<ShipmentEntity>().Property(x => x.PurchaseOrderNumber).HasMaxLength(11);
            modelBuilder.Entity<ShipmentEntity>().Property(x => x.VendorId).HasMaxLength(12);
            modelBuilder.Entity<ShipmentEntity>().Property(x => x.Notes).HasMaxLength(200);

            modelBuilder.Entity<ShipmentEntity>().Property(x => x.VendorId).HasColumnName("VendorID");
            modelBuilder.Entity<ShipmentEntity>().Property(x => x.PurchaseOrderNumber).HasColumnName("PONumber");

            modelBuilder.Entity<ShipmentEntity>()
                .HasRequired(x => x.Vendor)
                .WithMany(x => x.Shipments)
                .HasForeignKey(x => new { x.VendorId, x.VendorSuffix });

            modelBuilder.Entity<ShipmentEntity>()
                .HasOptional(x => x.PurchaseOrder)
                .WithMany(x => x.Shipments)
                .HasForeignKey(x => x.PurchaseOrderNumber);

            modelBuilder.Entity<ShipmentEntity>()
                .HasOptional(x => x.Transfer)
                .WithMany(x => x.Shipments)
                .HasForeignKey(x => x.TransferNumber);

            modelBuilder.Entity<ShipmentEntity>().HasRequired(x => x.CreatedBy).WithMany(x => x.CreatedShipments).HasForeignKey(x => x.CreatedById);
            modelBuilder.Entity<ShipmentEntity>().HasOptional(x => x.UpdatedBy).WithMany(x => x.UpdatedShipments).HasForeignKey(x => x.UpdatedById);
            modelBuilder.Entity<ShipmentEntity>().HasOptional(x => x.ConfirmedBy).WithMany(x => x.ConfirmedShipments).HasForeignKey(x => x.ConfirmedById);
        }

        private void ShipMethodConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipMethodEntity>().ToTable("ShipMethod");
            modelBuilder.Entity<ShipMethodEntity>().HasKey(m => m.Id)
                .Property(m => m.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

        private void ShipmentItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipmentItemEntity>().ToTable("ShipmentDetail");
            modelBuilder.Entity<ShipmentItemEntity>().HasKey(x => new { x.ShipmentNumber, x.SKU });

            modelBuilder.Entity<ShipmentItemEntity>().Property(x => x.ShipmentNumber).HasMaxLength(11);

            modelBuilder.Entity<ShipmentItemEntity>().Property(x => x.DamagedQuantity).HasColumnName("QtyDamaged");
            modelBuilder.Entity<ShipmentItemEntity>().Property(x => x.DamagedQuantity).HasPrecision(7, 3);
            modelBuilder.Entity<ShipmentItemEntity>().Property(x => x.ReceivedQuantity).HasColumnName("QtyReceived");
            modelBuilder.Entity<ShipmentItemEntity>().Property(x => x.ReceivedQuantity).HasPrecision(7, 3);
            modelBuilder.Entity<ShipmentItemEntity>().Property(x => x.Quantity).HasPrecision(7, 3);

            modelBuilder.Entity<ShipmentItemEntity>()
                .HasRequired(x => x.Shipment)
                .WithMany(x => x.ShipmentItems)
                .HasForeignKey(x => x.ShipmentNumber);

            modelBuilder.Entity<ShipmentItemEntity>()
                .HasRequired(x => x.ItemSku)
                .WithMany(x => x.ShipmentItems)
                .HasForeignKey(x => x.SKU);
        }

        private void ShipmentTypesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShipmentTypeEntity>().ToTable("ShipmentTypes");
            modelBuilder.Entity<ShipmentTypeEntity>().HasKey(m => m.Id).Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
        //END---------------------Shipment-----------------------------------------
        #endregion

        #region Pallet
        //------------------------Pallet-----------------------------------------
        private void PalletConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalletAuditStatusEntity>().ToTable("PalletAuditStatus");
            modelBuilder.Entity<PalletAuditStatusEntity>().Property(pas => pas.Code).HasColumnName("Code");
            modelBuilder.Entity<PalletAuditStatusEntity>().Property(pas => pas.Description).HasColumnName("Description");
            modelBuilder.Entity<PalletAuditStatusEntity>().HasKey(pas => pas.Code);

            modelBuilder.Entity<PalletEntity>().ToTable("PalletHeader");
            modelBuilder.Entity<PalletEntity>().Property(x => x.PalletId).HasColumnName("PalletID");
            modelBuilder.Entity<PalletEntity>().Property(x => x.PalletId).HasMaxLength(16);
            modelBuilder.Entity<PalletEntity>().HasKey(x => x.PalletId);
            modelBuilder.Entity<PalletEntity>().Property(x => x.ShipmentNumber).HasMaxLength(16);
            modelBuilder.Entity<PalletEntity>().Property(x => x.Type).HasMaxLength(10);
            modelBuilder.Entity<PalletEntity>().Property(x => x.MasterLabel).HasMaxLength(8);
            modelBuilder.Entity<PalletEntity>().Property(x => x.Notes).HasMaxLength(50);
            modelBuilder.Entity<PalletEntity>().Property(x => x.StatusPS).HasMaxLength(32);
            modelBuilder.Entity<PalletEntity>().HasRequired(x => x.CreatedBy).WithMany(x => x.CreatedPallets).HasForeignKey(x => x.CreatedById);
            modelBuilder.Entity<PalletEntity>().HasOptional(x => x.UpdatedBy).WithMany(x => x.UpdatedPallets).HasForeignKey(x => x.UpdatedById);
            modelBuilder.Entity<PalletEntity>().HasOptional(x => x.ConfirmedBy).WithMany(x => x.ConfirmedPallets).HasForeignKey(x => x.ConfirmedById);
            modelBuilder.Entity<PalletEntity>().HasRequired(x => x.Shipment).WithMany(x => x.Pallets).HasForeignKey(x => x.ShipmentNumber);
            modelBuilder.Entity<PalletEntity>().Property(x => x.AuditStatus).HasColumnName("AuditStatus").HasMaxLength(1).IsRequired();
        }

        private void PalletItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalletItemEntity>().ToTable("PalletDetail");
            modelBuilder.Entity<PalletItemEntity>().HasKey(x => new { x.PalletId, x.SKU });

            modelBuilder.Entity<PalletItemEntity>().Property(x => x.PalletId).HasColumnName("PalletID");
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.VelocityCode).HasColumnName("CV");
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.PalletId).HasMaxLength(16);
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.VelocityCode).HasMaxLength(1);
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.Remarks).HasMaxLength(10);
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.Quantity).HasPrecision(7, 3);
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.QtyReceived).HasPrecision(7, 3);
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.QtyDamaged).HasPrecision(7, 3);
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.MasterLabel).HasMaxLength(8);
            modelBuilder.Entity<PalletItemEntity>().Property(x => x.Comments).HasMaxLength(50);

            modelBuilder.Entity<PalletItemEntity>()
                .HasRequired(x => x.Pallet)
                .WithMany(x => x.Items)
                .HasForeignKey(x => new { x.PalletId });
            modelBuilder.Entity<PalletItemEntity>()
                .HasRequired(x => x.SkuItem)
                .WithMany(x => x.PalletItems)
                .HasForeignKey(x => x.SKU);
        }
        //END---------------------Pallet-----------------------------------------
        #endregion

        #region ReturnToVendor
        //------------------------ReturnToVendor-----------------------------------------
        private void ReturnToVendorConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReturnToVendorEntity>().ToTable("VndrRtnHdr");
            modelBuilder.Entity<ReturnToVendorEntity>().HasKey(x => x.RTVNumber);
            modelBuilder.Entity<ReturnToVendorEntity>().Property(x => x.RTVNumber).HasColumnName("RefNumber");
            modelBuilder.Entity<ReturnToVendorEntity>()
                .Property(x => x.RTVNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);      //0g05122015 make identity
            modelBuilder.Entity<ReturnToVendorEntity>().Property(x => x.TypeId).HasColumnName("RtnType");
            modelBuilder.Entity<ReturnToVendorEntity>()
                .HasRequired(x => x.Type)
                .WithMany(x => x.ReturnToVendors)
                .HasForeignKey(x => x.TypeId);
            modelBuilder.Entity<ReturnToVendorEntity>()
                .HasRequired(x => x.Vendor)
                .WithMany(x => x.ReturnToVendors)
                .HasForeignKey(x => new { x.VendorID, x.VendorSuffix });
        }

        private void ReturnToVendorItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReturnToVendorItemEntity>().ToTable("VndrRtnDtl");
            modelBuilder.Entity<ReturnToVendorItemEntity>().HasKey(x => new { x.RTVNumber, x.SKU });
            modelBuilder.Entity<ReturnToVendorItemEntity>().Property(x => x.RTVNumber).HasColumnName("RefNumber");
            modelBuilder.Entity<ReturnToVendorItemEntity>()
                .HasRequired(x => x.ReturnToVendor)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.RTVNumber);
            modelBuilder.Entity<ReturnToVendorItemEntity>()
                .HasRequired(x => x.ItemSku)
                .WithMany(x => x.ReturnToVendorItems)
                .HasForeignKey(x => x.SKU);
        }

        private void ReturnToVendorTypeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReturnToVendorTypeEntity>().ToTable("DispInstruc");
            modelBuilder.Entity<ReturnToVendorTypeEntity>().HasKey(x => x.DispCode);
            modelBuilder.Entity<ReturnToVendorTypeEntity>().Property(x => x.Instructions).HasMaxLength(60);
            modelBuilder.Entity<ReturnToVendorTypeEntity>().Property(x => x.RGANumber).HasMaxLength(20);
        }

        private void ReturnToVendorStatusConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReturnToVendorStatusEntity>().ToTable("VndrRtnStatus");//new table
            modelBuilder.Entity<ReturnToVendorStatusEntity>().HasKey(x => x.Id);
            modelBuilder.Entity<ReturnToVendorStatusEntity>().Property(x => x.Code).HasMaxLength(1);
            modelBuilder.Entity<ReturnToVendorStatusEntity>().Property(x => x.Description).HasMaxLength(50);
            modelBuilder.Entity<ReturnToVendorStatusEntity>().Property(x => x.Tag).HasMaxLength(50);
        }
        //END---------------------ReturnToVendor-----------------------------------------
        #endregion

        #region Store
        //------------------------Store-----------------------------------------
        private void DestinationStoreEntityConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationStoreEntity>().ToTable("XferFromStore");
            modelBuilder.Entity<DestinationStoreEntity>().HasKey(x => new { x.RequestStoreId, x.SourceStoreId });
            modelBuilder.Entity<DestinationStoreEntity>().Property(x => x.RequestStoreId).HasColumnName("RequestStoreId");
            modelBuilder.Entity<DestinationStoreEntity>().Property(x => x.SourceStoreId).HasColumnName("SourceStoreId");
            modelBuilder.Entity<DestinationStoreEntity>()
                .HasRequired<StoreEntity>(x => x.RequestStore)
                .WithMany(x => x.DestinationStoreRequested)
                .HasForeignKey(x => new { x.RequestStoreId });
            modelBuilder.Entity<DestinationStoreEntity>()
                .HasRequired<StoreEntity>(x => x.SourceStore)
                .WithMany(x => x.DestinationStoreSourced)
                .HasForeignKey(x => new { x.SourceStoreId });
        }

        private void DistrictConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DistrictEntity>().ToTable("District");
            modelBuilder.Entity<DistrictEntity>().HasKey(x => x.DistrictCode);

            modelBuilder.Entity<DistrictEntity>().Property(t => t.DistrictCode).HasMaxLength(10);
            modelBuilder.Entity<DistrictEntity>().Property(t => t.DistrictName).HasMaxLength(50);
        }

        private void StoreConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoreEntity>().ToTable("Store");
            modelBuilder.Entity<StoreEntity>().HasKey(t => new { t.StoreNumber });

            modelBuilder.Entity<StoreEntity>().Property(t => t.StoreName)
                .HasColumnName("Name")
                .HasMaxLength(25)
                .IsRequired();
            modelBuilder.Entity<StoreEntity>().Property(t => t.ManagerName).HasMaxLength(25);
            modelBuilder.Entity<StoreEntity>().Property(t => t.TaxCode).HasMaxLength(12);
            modelBuilder.Entity<StoreEntity>().Property(t => t.DistrictCode).HasMaxLength(12);
            modelBuilder.Entity<StoreEntity>().Property(t => t.Address1).HasColumnName("Addr1");
            modelBuilder.Entity<StoreEntity>().Property(t => t.Address2).HasColumnName("Addr2");
            modelBuilder.Entity<StoreEntity>().Property(t => t.StateCode).HasColumnName("State");

            modelBuilder.Entity<StoreEntity>()
                .HasOptional(x => x.District)
                .WithMany(x => x.Stores)
                .HasForeignKey(x => x.DistrictCode);
            modelBuilder.Entity<StoreEntity>()
                .HasRequired(x => x.State)
                .WithMany(x => x.Stores)
                .HasForeignKey(x => x.StateCode);
            modelBuilder.Entity<StoreEntity>()
                .HasOptional(s => s.Tax)
                .WithMany()
                .HasForeignKey(s => s.TaxCode);
        }

        private void TaxesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaxEntity>().ToTable("Tax");
            modelBuilder.Entity<TaxEntity>().HasKey(t => t.TaxCode).Property(t => t.TaxCode).HasMaxLength(12);
            modelBuilder.Entity<TaxEntity>().Property(t => t.TaxName).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<TaxEntity>().Property(t => t.TaxRate).HasColumnName("Rate");
            modelBuilder.Entity<TaxEntity>().Property(t => t.IsTaxIncluded).HasColumnName("TaxInclusion");
        }
        //END---------------------Store-----------------------------------------
        #endregion

        #region Transfer
        //------------------------Transfer-----------------------------------------
        private void TransferConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferEntity>().ToTable("TransferHeader");
            modelBuilder.Entity<TransferEntity>().HasKey(x => x.TransferNumber);

            modelBuilder.Entity<TransferEntity>().Property(x => x.TransferNumber).HasMaxLength(11);
            modelBuilder.Entity<TransferEntity>().Property(x => x.Status).HasMaxLength(1);
            modelBuilder.Entity<TransferEntity>().Property(x => x.Note).HasMaxLength(200);
            modelBuilder.Entity<TransferEntity>().Property(x => x.ShipMethod).HasMaxLength(20);
            modelBuilder.Entity<TransferEntity>().Property(x => x.DriverRef).HasMaxLength(40);
            modelBuilder.Entity<TransferEntity>().Property(x => x.TruckNumber).HasMaxLength(40);

            modelBuilder.Entity<TransferEntity>()
                .HasRequired(x => x.StoreSourceEntity).WithMany().HasForeignKey(x => x.SourceStore);
            modelBuilder.Entity<TransferEntity>()
                .HasRequired(x => x.StoreRequestEntity).WithMany().HasForeignKey(x => x.RequestStore);
        }

        private void TransferItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransferItemEntity>().ToTable("TransferDetail");
            modelBuilder.Entity<TransferItemEntity>().HasKey(x => new { x.TransferNumber, x.SKU });

            modelBuilder.Entity<TransferItemEntity>().Property(x => x.TransferNumber).HasMaxLength(11);
            modelBuilder.Entity<TransferItemEntity>().Property(x => x.ProductStatus).HasMaxLength(1);

            modelBuilder.Entity<TransferItemEntity>()
                .HasRequired(x => x.Transfer)
                .WithMany(x => x.TransferItems)
                .HasForeignKey(x => x.TransferNumber);
            modelBuilder.Entity<TransferItemEntity>()
                .HasRequired(x => x.ItemSku)
                .WithMany()
                .HasForeignKey(x => x.SKU);
            modelBuilder.Entity<TransferItemEntity>()
                .HasRequired<StoreEntity>(x => x.Store)
                .WithMany()
                .HasForeignKey(x => new { x.SourceStore });

        }
        //END---------------------Transfer-----------------------------------------
        #endregion

        #region Vendor
        //------------------------Vendor-----------------------------------------
        private void FobTermsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FobTermEntity>().ToTable("FOB");
            modelBuilder.Entity<FobTermEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<FobTermEntity>().Property(t => t.Id).HasColumnName("Code");

            modelBuilder.Entity<FobTermEntity>().Property(t => t.Id).HasMaxLength(4);
            modelBuilder.Entity<FobTermEntity>().Property(t => t.Description).HasMaxLength(30);

            modelBuilder.Entity<VendorEntity>()
                .HasOptional(t => t.FobTerm)
                .WithMany(t => t.Vendors)
                .HasForeignKey(t => t.FOBCode);
        }

        private void InvoiceTermsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceTermEntity>().ToTable("SettleTerm");
            modelBuilder.Entity<InvoiceTermEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<InvoiceTermEntity>().Property(t => t.Id).HasColumnName("Code");

            modelBuilder.Entity<InvoiceTermEntity>().Property(t => t.Id).HasMaxLength(4);
            modelBuilder.Entity<InvoiceTermEntity>().Property(t => t.Description).HasMaxLength(30);

            modelBuilder.Entity<VendorEntity>()
                .HasOptional(t => t.InvoiceTerms)
                .WithMany(t => t.Vendors)
                .HasForeignKey(t => t.SettleTermCode);
        }

        public void PaymentMethodsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentMethodEntity>().ToTable("PayMethod");
            modelBuilder.Entity<PaymentMethodEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<PaymentMethodEntity>().Property(t => t.Id).HasColumnName("Code");

            modelBuilder.Entity<PaymentMethodEntity>().Property(t => t.Id).HasMaxLength(4);
            modelBuilder.Entity<PaymentMethodEntity>().Property(t => t.Description).HasMaxLength(30);

            modelBuilder.Entity<VendorEntity>()
                .HasOptional(t => t.PaymentMethod)
                .WithMany(t => t.Vendors)
                .HasForeignKey(t => t.PayMethodCode);
        }

        private void VendorConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendorEntity>().ToTable("Vendor");
            modelBuilder.Entity<VendorEntity>()
                        .Property(t => t.VendorId)
                        .HasMaxLength(12)
                        .HasColumnName("VendorID");
            modelBuilder.Entity<VendorEntity>().Property(t => t.VendorSuffix);
            modelBuilder.Entity<VendorEntity>().HasKey(t => new { t.VendorId, t.VendorSuffix });

            modelBuilder.Entity<VendorEntity>().Property(t => t.VendorName).IsRequired().HasMaxLength(35);
            modelBuilder.Entity<VendorEntity>().Property(t => t.ContactPosition).HasMaxLength(30);
            modelBuilder.Entity<VendorEntity>().Property(t => t.SalesmanPosition).HasMaxLength(30);
            modelBuilder.Entity<VendorEntity>().Property(t => t.SalesmanEmailAddr).HasMaxLength(60);
            modelBuilder.Entity<VendorEntity>().Property(t => t.SpecInst1).HasMaxLength(82);
            modelBuilder.Entity<VendorEntity>().Property(t => t.SpecInst2).HasMaxLength(82);
            modelBuilder.Entity<VendorEntity>().Property(t => t.PayMethodCode).HasMaxLength(4);
            modelBuilder.Entity<VendorEntity>().Property(t => t.SettleTermCode).HasMaxLength(4);
            modelBuilder.Entity<VendorEntity>().Property(t => t.FOBCode).HasMaxLength(4);
            modelBuilder.Entity<VendorEntity>().Property(t => t.DepartmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<VendorEntity>().Property(t => t.SpecificationsRequired).HasColumnName("SpecRequired");

            modelBuilder.Entity<VendorEntity>()
                .HasOptional(t => t.Department)
                .WithMany(t => t.Vendors)
                .HasForeignKey(t => t.DepartmentId);

            modelBuilder.Entity<VendorEntity>()
                .HasMany(t => t.PurchaseOrders)
                .WithOptional(t => t.Vendor)
                .HasForeignKey(t => new { t.VendorId, t.VendorSuffix });

            modelBuilder.Entity<VendorEntity>()
                .HasOptional(v => v.RTVConfiguration)
                .WithRequired();

            //TODO: Check correctness of this config
            modelBuilder.Entity<VendorEntity>()
                .HasOptional(t => t.Employee)
                .WithMany()
                .HasForeignKey(t => t.EmployeeNo);
        }

        private void ItemVendorConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemVendorEntity>().ToTable("ItemVendor");

            modelBuilder.Entity<ItemVendorEntity>().HasKey(s => new { s.Sku, s.VendorId, s.VendorSku });
            modelBuilder.Entity<ItemVendorEntity>().Property(s => s.VendUom).HasColumnName("VendUOM");
            modelBuilder.Entity<ItemVendorEntity>()
                        .HasRequired(s => s.Vendor)
                        .WithMany(s => s.VendorItems)
                        .HasForeignKey(s => new { s.VendorId, s.VendorSuffix });

            modelBuilder.Entity<ItemVendorEntity>()
                        .HasRequired(s => s.ItemSku)
                        .WithMany(s => s.VendorItems)
                        .HasForeignKey(s => s.Sku);
        }

        private void VendorRTVConfigurationConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VendorRTVConfigurationEntity>().ToTable("VendorRTVConfiguration");
            modelBuilder.Entity<VendorRTVConfigurationEntity>().HasKey(t => new { t.VendorId, t.VendorSuffix });
        }
        //END---------------------Vendor-----------------------------------------
        #endregion

        #region Voucher
        //------------------------Voucher-----------------------------------------
        private void VoucherReconcileConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VoucherReconcileEntity>().ToTable("STORE_VoucherReconcile");
            modelBuilder.Entity<VoucherReconcileEntity>().HasKey(s => s.VoucherReconcileId);
            modelBuilder.Entity<VoucherReconcileEntity>()
                        .Property(s => s.Date)
                        .HasColumnType("date")
                        .HasColumnAnnotation(
                            "Index",
                            new IndexAnnotation(
                                new IndexAttribute("UX_STORE_VoucherReconcile_dateAndTenderId", 1) { IsUnique = true }));

            modelBuilder.Entity<VoucherReconcileEntity>()
                        .Property(s => s.TenderId)
                        .HasColumnAnnotation(
                            "Index",
                            new IndexAnnotation(
                                new IndexAttribute("UX_STORE_VoucherReconcile_dateAndTenderId", 2) { IsUnique = true }));

            modelBuilder.Entity<VoucherReconcileEntity>()
                         .HasRequired(s => s.Employee)
                         .WithMany(s => s.VoucherReconciles)
                         .HasForeignKey(s => s.EmployeeNo);

            modelBuilder.Entity<VoucherReconcileEntity>()
                        .HasRequired(s => s.Tender)
                        .WithMany(s => s.VoucherReconciles)
                        .HasForeignKey(s => s.TenderId).WillCascadeOnDelete(false);
        }

        private void VoucherReconcileDetailsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VoucherReconcileDetailsEntity>().ToTable("STORE_VoucherReconcileDetails");
            modelBuilder.Entity<VoucherReconcileDetailsEntity>().HasKey(s => s.VoucherReconcileDetailId);
            modelBuilder.Entity<VoucherReconcileDetailsEntity>().Property(s => s.TotalPrice).HasPrecision(19, 2);

            modelBuilder.Entity<VoucherReconcileDetailsEntity>()
                        .HasRequired(s => s.VoucherReconcile)
                        .WithMany(s => s.Details)
                        .HasForeignKey(s => s.VoucherReconcileId);

            modelBuilder.Entity<VoucherReconcileDetailsEntity>()
                        .HasRequired(s => s.Denomination)
                        .WithMany(s => s.VoucherReconcileDetails)
                        .HasForeignKey(s => s.DenominationId);
        }
        //END---------------------Voucher-----------------------------------------
        #endregion

        #region Withdrawal
        //------------------------Withdrawal-----------------------------------------
        private static void WithdrawalDenominationConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WithdrawalDenominationEntity>().ToTable("STORE_WithdrawalDenominations");
            modelBuilder.Entity<WithdrawalDenominationEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<WithdrawalDenominationEntity>().Property(s => s.TotalPrice).HasPrecision(19, 8);
            modelBuilder.Entity<WithdrawalDenominationEntity>().Property(s => s.Description).HasMaxLength(255);

            modelBuilder.Entity<WithdrawalDenominationEntity>()
                        .HasRequired(t => t.Withdrawal)
                        .WithMany(t => t.WithdrawalDenominations)
                        .HasForeignKey(t => t.WithdrawalId);

            modelBuilder.Entity<WithdrawalDenominationEntity>()
                        .HasRequired(t => t.Denomination)
                        .WithMany(t => t.WithdrawalDenominations)
                        .HasForeignKey(t => t.DenominationId);
        }

        private static void WithdrawalConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WithdrawalEntity>().ToTable("STORE_Withdrawals");
            modelBuilder.Entity<WithdrawalEntity>().HasKey(t => t.WithdrawalId);
            modelBuilder.Entity<WithdrawalEntity>().Property(s => s.Status).HasMaxLength(8);
            modelBuilder.Entity<WithdrawalEntity>().Property(s => s.DocumentType).HasMaxLength(7);
            modelBuilder.Entity<WithdrawalEntity>().Property(s => s.Comment).HasMaxLength(255);

            modelBuilder.Entity<WithdrawalEntity>()
                        .HasRequired(t => t.Employee)
                        .WithMany(t => t.Withdrawals)
                        .HasForeignKey(t => t.EmployeeNo);

            modelBuilder.Entity<WithdrawalEntity>().Ignore(s => s.BalanceStatus);
        }

        private void DenominationConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DenominationEntity>().ToTable("STORE_Denominations");
            modelBuilder.Entity<DenominationEntity>().HasKey(t => t.DenominationId);
            modelBuilder.Entity<DenominationEntity>().Property(s => s.Description).HasMaxLength(255);
            modelBuilder.Entity<DenominationEntity>().Property(s => s.Price).HasPrecision(9, 2);

            modelBuilder.Entity<DenominationEntity>()
                        .HasOptional(t => t.Tender)
                        .WithMany(t => t.Denominations)
                        .HasForeignKey(t => t.TenderId);

            modelBuilder.Entity<DenominationEntity>()
                        .HasRequired(t => t.TenderType)
                        .WithMany(t => t.Denominations)
                        .HasForeignKey(t => t.TenderCode);
        }

        //END---------------------Withdrawal-----------------------------------------
        #endregion

        #region Sku
        //----------------------------------sku-------------------------------

        private static void ProductConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemSkuEntity>().ToTable("ItemPLU");
            modelBuilder.Entity<ItemSkuEntity>().HasKey(t => t.Sku).Property(t => t.Sku).HasColumnName("SKU");

            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.SubSku).HasColumnName("SubSKU");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.PromoStartDate).HasColumnName("PromoStart");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.PromoEndDate).HasColumnName("PromoEnd");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.PromoStartTime).HasColumnName("PromoTime");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.PromoEndTime).HasColumnName("PromoETime");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.PromoPrice).HasColumnName("PromoPrc");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.Description).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.DepatmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.ClassId).HasColumnName("ClassNo");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.SubClassId).HasColumnName("SubClass");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.VendorId).HasColumnName("VendorID");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.ItemType).HasMaxLength(1);
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.Type).HasMaxLength(1);
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.AlphaKey).HasMaxLength(10);
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.StatusCode).IsRequired().HasMaxLength(1);
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.FeeId).HasColumnName("EnvironmentFee");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.Cost).HasColumnName("AvgCost");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.SpecialItemType).HasColumnName("UniqItmCode").HasMaxLength(1);
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.IsGenericItem).HasColumnName("Generic");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.IsSpecialItem).HasColumnName("SpecialOrder");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.TaxCode).HasMaxLength(12);
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc1).HasColumnName("XMerchLoc__1");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc2).HasColumnName("XMerchLoc__2");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc3).HasColumnName("XMerchLoc__3");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc4).HasColumnName("XMerchLoc__4");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc5).HasColumnName("XMerchLoc__5");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc6).HasColumnName("XMerchLoc__6");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc7).HasColumnName("XMerchLoc__7");
            modelBuilder.Entity<ItemSkuEntity>().Property(t => t.XMerchLoc8).HasColumnName("XMerchLoc__8");

            modelBuilder.Entity<ItemSkuEntity>().HasRequired(t => t.ItemReplen).WithRequiredPrincipal(t => t.ItemSku);
            modelBuilder.Entity<ItemSkuEntity>().HasMany(t => t.Promotions).WithRequired(t => t.ItemSku).HasForeignKey(t => t.Sku);
            modelBuilder.Entity<ItemSkuEntity>().HasMany(t => t.BarCodes).WithRequired(t => t.ItemSKU).HasForeignKey(t => t.SKUId);
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(t => t.Vendor).WithMany(t => t.ItemSkus).HasForeignKey(t => new { t.VendorId, t.VendorSuffix });
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(t => t.Department).WithMany(t => t.ItemSkus).HasForeignKey(t => t.DepatmentId);
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(t => t.DepartmentClass).WithMany(t => t.ItemSkus).HasForeignKey(t => new { t.DepatmentId, t.ClassId });
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(t => t.DepartmentSubClass).WithMany(t => t.ItemSkus).HasForeignKey(t => new { t.DepatmentId, t.ClassId, t.SubClassId });
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(t => t.Fee).WithMany(t => t.ItemSkuEntities).HasForeignKey(t => t.FeeId);
            modelBuilder.Entity<ItemSkuEntity>().HasMany(t => t.ProPrices).WithRequired(t => t.ItemSku).HasForeignKey(t => t.SkuId);
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(t => t.UnitOfMeasure).WithMany(t => t.SkuItems).HasForeignKey(t => t.Uom);
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(t => t.Tax).WithMany().HasForeignKey(t => t.TaxCode);
            modelBuilder.Entity<ItemSkuEntity>().HasOptional(s => s.KitHeader).WithMany().HasForeignKey(s => s.SubSku);

            modelBuilder.Entity<ItemSkuEntity>().Ignore(t => t.Margin);
            modelBuilder.Entity<ItemSkuEntity>().Ignore(t => t.MarginAbs);
            modelBuilder.Entity<ItemSkuEntity>().Ignore(t => t.IsRegularItem);
            modelBuilder.Entity<ItemSkuEntity>().Ignore(t => t.NeedPriceRecalcualate);
            modelBuilder.Entity<ItemSkuEntity>().Ignore(t => t.PriceWithoutTaxes);
        }

        private static void BarCodeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BarCodeEntity>().ToTable("ItemXref");
            modelBuilder.Entity<BarCodeEntity>().HasKey(t => t.Id).Property(t => t.Id).HasColumnName("VendorUPC").HasMaxLength(16);
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.IsSystemGenerated).HasColumnName("SystemGenerated");
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.POSDescription).HasColumnName("POSDesc").HasMaxLength(20);
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.AtForQuantity).HasColumnName("AtForQty");
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.AddedDate).HasColumnName("Added");
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.LastActivityDate).HasColumnName("LastActivity");
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.AmountOffPct).HasColumnName("AmtOffPct");
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.SKUId).HasColumnName("SKU");
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.UPCOrigin).HasMaxLength(1);
            modelBuilder.Entity<BarCodeEntity>().Property(t => t.UomType).HasMaxLength(1);
        }

        private static void SkuLocationConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SKULocationEntity>().ToTable("SkuLocations");
            modelBuilder.Entity<SKULocationEntity>().HasKey(m => m.Id).Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }

        private static void PricePndHdrsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PricePndHdrEntity>().ToTable("PricePndHdr");
            modelBuilder.Entity<PricePndHdrEntity>().HasKey(x => new { x.BatchNumber, x.SequenceNo });
        }

        private static void PricePndDtlsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PricePndDtlEntity>().ToTable("PricePndDtl");
            modelBuilder.Entity<PricePndDtlEntity>().HasKey(x => new { x.BatchNumber, x.Sku, x.DeptNo, x.ClassNo });
            modelBuilder.Entity<PricePndDtlEntity>().Property(x => x.Sku).HasColumnName("SKU");

            modelBuilder.Entity<PricePndDtlEntity>().HasRequired<PricePndHdrEntity>(p => p.PricePndHeader).WithMany(b => b.PricePndDetail).HasForeignKey(p => new { p.BatchNumber, p.SequenceNo });
        }

        private static void CouponConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CouponEntity>().ToTable("Coupon");
            modelBuilder.Entity<CouponEntity>().HasKey(t => t.CouponId);
        }

        private static void PromotionConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromotionEntity>().ToTable("PromoHeader");
            modelBuilder.Entity<PromotionEntity>().HasKey(t => new { t.PromotionId, t.SequenceNumber });
            modelBuilder.Entity<PromotionEntity>().Property(t => t.PromotionId).HasColumnName("BatchNumber");
            modelBuilder.Entity<PromotionEntity>().Property(t => t.StartDate).HasColumnName("BeginDate");
            modelBuilder.Entity<PromotionEntity>().Property(t => t.StartTime).HasColumnName("BeginTime");
            modelBuilder.Entity<PromotionEntity>().Property(t => t.SequenceNumber).HasColumnName("SequenceNo");
        }

        private static void PromotionItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromotionItemEntity>().ToTable("PromoDetail");
            modelBuilder.Entity<PromotionItemEntity>().HasKey(t => new { t.PromotionId, t.Sku });

            modelBuilder.Entity<PromotionItemEntity>().Property(t => t.PromotionId).HasColumnName("BatchNumber");
            modelBuilder.Entity<PromotionItemEntity>().Property(t => t.Sku).HasColumnName("SKU");
            modelBuilder.Entity<PromotionItemEntity>().Property(t => t.SequenceNumber).HasColumnName("SequenceNo");
            
            modelBuilder.Entity<PromotionItemEntity>().HasRequired(t => t.Promotion).WithMany(t => t.PromitionItems).HasForeignKey(t => new { t.PromotionId, t.SequenceNumber });
        }

        private static void ItemHistoryConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemHistoryEntity>().ToTable("ItemHist");
            modelBuilder.Entity<ItemHistoryEntity>().HasKey(x => x.SKU).Property(m => m.SKU).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<ItemHistoryEntity>().Property(x => x.YearToDateQuantity).HasColumnName("YTDQty");
            modelBuilder.Entity<ItemHistoryEntity>().HasRequired(x => x.ItemSku).WithOptional(x => x.ItemHistory);
        }

        private static void ItemReplenConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemReplenEntity>().ToTable("ItemReplen");
            modelBuilder.Entity<ItemReplenEntity>().HasKey(t => t.Sku).Property(t => t.Sku).HasColumnName("SKU").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.QuantityOnHand).HasColumnName("CurQOH");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.QuantityOnHand).HasPrecision(7, 3);
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.QuantityReserved).HasColumnName("QtyReserved");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.QuatityOnHold).HasColumnName("QtyOnHold");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.QuantityOnOrder).HasColumnName("OnOrderQty");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.SeasonId).HasColumnName("SeasonCode");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.QuantityOnXDock).HasColumnName("DCOrdMin");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.QuantityInTransit).HasColumnName("InTransitQty");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.DisplayQty).HasColumnName("DisplayQty");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.LabelType).HasColumnName("LabelType");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.VelocityCode).HasColumnName("ABCAnal");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales1).HasColumnName("PrevWkSlsQty__1");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales2).HasColumnName("PrevWkSlsQty__2");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales3).HasColumnName("PrevWkSlsQty__3");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales4).HasColumnName("PrevWkSlsQty__4");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales5).HasColumnName("PrevWkSlsQty__5");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales6).HasColumnName("PrevWkSlsQty__6");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales7).HasColumnName("PrevWkSlsQty__7");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales8).HasColumnName("PrevWkSlsQty__8");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales9).HasColumnName("PrevWkSlsQty__9");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales10).HasColumnName("PrevWkSlsQty__10");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales11).HasColumnName("PrevWkSlsQty__11");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales12).HasColumnName("PrevWkSlsQty__12");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales13).HasColumnName("PrevWkSlsQty__13");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales14).HasColumnName("PrevWkSlsQty__14");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales15).HasColumnName("PrevWkSlsQty__15");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.WeekSales16).HasColumnName("PrevWkSlsQty__16");

            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.LabelFeature3).HasColumnName("LabelFeature__3");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.LabelFeature4).HasColumnName("LabelFeature__4");
            modelBuilder.Entity<ItemReplenEntity>().Property(t => t.LabelFeature5).HasColumnName("LabelFeature__5");
        }

        private static void SkuKitConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkuKitEntity>().ToTable("ItemKitHdr");
            modelBuilder.Entity<SkuKitEntity>().HasKey(t => t.KitNumber);
            modelBuilder.Entity<SkuKitEntity>().Property(t => t.KitNumber).HasColumnName("KitNum");
            modelBuilder.Entity<SkuKitEntity>().Property(t => t.SetupDate).HasColumnName("Setup");

            modelBuilder.Entity<SkuKitEntity>()
                .HasMany(h => h.KitItems)
                .WithRequired(k => k.KitHeader)
                .HasForeignKey(k => k.KitNumber);
        }

        private static void SkuKitItemConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkuKitItemEntity>().ToTable("ItemKitDtl");
            modelBuilder.Entity<SkuKitItemEntity>().HasKey(t => new { t.KitNumber, t.SKU });
            modelBuilder.Entity<SkuKitItemEntity>().Property(t => t.KitNumber).HasColumnName("KitNum");
            modelBuilder.Entity<SkuKitItemEntity>().Property(t => t.SKU).HasColumnName("SKU");
            modelBuilder.Entity<SkuKitItemEntity>().Property(t => t.Quantity).HasColumnName("KitQty");
            modelBuilder.Entity<SkuKitItemEntity>().Property(t => t.Price).HasColumnName("KitPricComp");
        }

        //end-------------------------------sku-------------------------------
        #endregion 

        private static void ReasonConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReasonEntity>().ToTable("Reason");
            modelBuilder.Entity<ReasonEntity>().HasKey(t => new { t.ReasonCode, t.AdjustType });
        }

        private static void SystemLogConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemLogEntity>().ToTable("SystemLog");
            modelBuilder.Entity<SystemLogEntity>().HasKey(t => new { t.LogType, t.LogDate, t.LogTime, t.AutoIncrement });
            modelBuilder.Entity<SystemLogEntity>().Property(t => t.AutoIncrement).HasColumnName("AutoSequence").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<SystemLogEntity>().Property(t => t.LogDate).HasColumnType("date");
            modelBuilder.Entity<SystemLogEntity>().Property(t => t.LogTime).HasColumnType("time").HasPrecision(0);
            modelBuilder.Entity<SystemLogEntity>().Property(t => t.LogType).HasColumnName("Type");
            modelBuilder.Entity<SystemLogEntity>().Property(t => t.EmployeeId).HasColumnName("EmployeeNo");
            modelBuilder.Entity<SystemLogEntity>().Property(t => t.ProgName).HasMaxLength(256).IsRequired();
            modelBuilder.Entity<SystemLogEntity>().Property(t => t.LogMessage).HasMaxLength(2000).IsRequired();
            modelBuilder.Entity<SystemLogEntity>().Property(t => t.Category).HasMaxLength(3).IsRequired();

        }

        private static void PosDevCntrlConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PosDevCntrlEntity>().ToTable("POSDevCntrl");
            modelBuilder.Entity<PosDevCntrlEntity>().HasKey(t => new {t.StoreNumber, t.DeviceNo});

            modelBuilder.Entity<PosDevCntrlEntity>().Property(t => t.Description).HasMaxLength(20).IsRequired();
        }
        
        #region Pricing agreement
        private void PriceAgreementConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PricingAgreementEntity>().ToTable("STORE_SccPriceAgreements");
            modelBuilder.Entity<PricingAgreementEntity>().HasKey(t => t.Id);
            //modelBuilder.Entity<PricingAgreementEntity>().Property(t => t.Id).HasColumnName("id");
            //modelBuilder.Entity<PricingAgreementEntity>()
            //    .Property(t => t.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); 

            modelBuilder.Entity<PricingAgreementEntity>()
                .HasMany(t => t.SccItems)
                .WithRequired(t => t.PricingAgreement)
                .HasForeignKey(t => t.AgreementId);

            modelBuilder.Entity<PricingAgreementEntity>().Property(t => t.ConsumptionStartDate).HasColumnType("datetime2");
            modelBuilder.Entity<PricingAgreementEntity>().Property(t => t.EstimatedEndDate).HasColumnType("datetime2");
            modelBuilder.Entity<PricingAgreementEntity>().Property(t => t.EstimatedStartDate).HasColumnType("datetime2");
            modelBuilder.Entity<PricingAgreementEntity>().Property(t => t.QuatationDate).HasColumnType("datetime2");

            modelBuilder.Entity<PricingAgreementEntity>()
                .HasRequired(t => t.Address)
                .WithRequiredPrincipal(t => t.Agreement);

            modelBuilder.Entity<PricingAgreementEntity>()
                .HasRequired(t => t.Requirement)
                .WithRequiredPrincipal(t => t.Agreement);

            modelBuilder.Entity<PricingAgreementEntity>()
               .HasRequired(t => t.ReceivingHours)
               .WithRequiredPrincipal(t => t.Agreement);

            modelBuilder.Entity<PricingAgreementEntity>()
                .HasRequired(t => t.Customer)
                .WithMany(t => t.Agreements)
                .HasForeignKey(t => new { t.CustomerId, t.SubKey });

            modelBuilder.Entity<PricingAgreementEntity>().Property(t => t.Created).IsRequired();
            modelBuilder.Entity<PricingAgreementEntity>().Property(t => t.Updated).IsRequired();
        }

        private void SccAddressConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SccAddressEntity>().ToTable("STORE_SccAddresses");
            modelBuilder.Entity<SccAddressEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<SccAddressEntity>().Property(x => x.StateId).HasColumnName("State");
            modelBuilder.Entity<SccAddressEntity>()
                .HasRequired<StateEntity>(a => a.State)
                .WithMany(s => s.Adresses)
                .HasForeignKey(t => t.StateId);
        }

        private void SccRequirementConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SccRequirementEntity>().ToTable("STORE_SccRequirements");
            modelBuilder.Entity<SccRequirementEntity>().HasKey(t => t.Id);
        }

        private void ReceivingHoursConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceivingHoursEntity>().ToTable("STORE_SccReceivingHours");
            modelBuilder.Entity<ReceivingHoursEntity>().HasKey(t => t.Id);
        }

        private void ItemSccConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SccItemEntity>().ToTable("STORE_SccItems");
            modelBuilder.Entity<SccItemEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<SccItemEntity>()
                .HasRequired(t => t.ItemSKU)
                .WithMany(t => t.SccItems)
                .HasForeignKey(t => t.SkuId);
            modelBuilder.Entity<SccItemEntity>()
                .HasOptional(t => t.ProposalItemSku)
                .WithMany(t => t.ProposalSccItems)
                .HasForeignKey(t => t.ProposalSkuId);
            modelBuilder.Entity<SccItemEntity>()
                .HasMany(t => t.Competitors)
                .WithRequired(t => t.SccItem)
                .HasForeignKey(t => t.SccItemId);
        }
        #endregion

        #region Label Printing
        //------------------------Label Printing-----------------------------------------
        private void PrinterConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrinterEntity>().ToTable("Printer");
        }
        private static void LabelTypeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabelTypeEntity>().ToTable("LabelType");
            modelBuilder.Entity<LabelTypeEntity>().HasKey(lt => lt.Code);
        }
        private void LabelConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabelConfigurationEntity>().ToTable("LabelConfiguration");
            modelBuilder.Entity<LabelConfigurationEntity>().HasKey(lc => new { lc.Code, lc.PrinterId });

            modelBuilder.Entity<LabelConfigurationEntity>()
                .HasRequired<LabelTypeEntity>(l => l.LabelType)
                .WithMany(t => t.LabelConfigurationItems)
                .HasForeignKey(l => l.Code);
        }
        private void PrintingBatchConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabelPrintingConfigurationEntity>().ToTable("LabelPrintingConfiguration");

            modelBuilder.Entity<PrintingBatchHeaderEntity>().ToTable("PrintingBatchHeader");

            modelBuilder.Entity<PrintingBatchDetailEntity>().ToTable("PrintingBatchDetail");

            modelBuilder.Entity<PrintingBatchDetailEntity>()
                            .HasRequired<PrintingBatchHeaderEntity>(p => p.BatchHeader)
                            .WithMany(b => b.Details)
                            .HasForeignKey(p => p.BatchHeaderId);
        }
        //end---------------------Label Printing-----------------------------------------
        #endregion
        
        #region Installations
        private static void InstallServiceHeadersConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallationPackEntity>().ToTable("InstServHdr");
            modelBuilder.Entity<InstallationPackEntity>().Property(t => t.Id).HasColumnName("ServhdrID");
            modelBuilder.Entity<InstallationPackEntity>().Property(t => t.DepartmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<InstallationPackEntity>().Property(t => t.ClassId).HasColumnName("ClassNo");
            modelBuilder.Entity<InstallationPackEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<InstallationPackEntity>().Property(s => s.TypeServ).HasMaxLength(1);

            modelBuilder.Entity<InstallationPackEntity>()
                .HasRequired(t => t.Department)
                .WithMany(t => t.InstallationPacks)
                .HasForeignKey(t => t.DepartmentId);

            modelBuilder.Entity<InstallationPackEntity>()
                .HasRequired(t => t.DepartmentClass)
                .WithMany(t => t.InstallationPacks)
                .HasForeignKey(t => new { t.DepartmentId, t.ClassId });

            modelBuilder.Entity<InstallationPackEntity>()
                .HasMany(t => t.Details)
                .WithRequired(t => t.InstallationPack)
                .HasForeignKey(t => t.InstallationPackId);
        }

        private static void InstallServiceDetailsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallationPackDetailEntity>().ToTable("INstServDet");
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.InstallationPackId).HasColumnName("ServhdrID");
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.ServiceSequence).HasColumnName("ServSeq");
            modelBuilder.Entity<InstallationPackDetailEntity>().HasKey(t => new { t.InstallationPackId, t.ServiceSequence });

            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.InstCost).HasPrecision(9, 4);
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.InstPrice).HasPrecision(7, 2);
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.Description).HasMaxLength(256);
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.Comments).HasMaxLength(256);
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.ServiceOrComment).HasColumnName("Type");
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.ServiceOrComment).HasMaxLength(1);
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.StatusCode).HasMaxLength(1);
            modelBuilder.Entity<InstallationPackDetailEntity>().Property(t => t.Uom).HasColumnName("UOM");
        }

        private static void InstallRequestConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallationRequestEntity>().ToTable("InstSol");
            modelBuilder.Entity<InstallationRequestEntity>()
                .Property(t => t.Id)
                .HasColumnName("solicID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<InstallationRequestEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.PackId).HasColumnName("ServhdrID");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallerId).HasColumnName("installerID");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.CustomerSubKey).HasColumnName("SubKey");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InvoiceDate).HasColumnName("InvDate").HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.WishedDate).HasColumnName("Wished_Date").HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.FeasibleDate).HasColumnName("feasible_date").HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.StartDate).HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.EndDate).HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.CreateDate).HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.ProgDateStart).HasColumnName("ProgDate").HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.ProgDateEnd).HasColumnName("ProgEndDate").HasColumnType("date");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallationPrice).HasColumnName("InstPrice");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallationCost).HasColumnName("InstCost");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallType).HasColumnName("typeinst");
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallType).HasMaxLength(1);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.StatusCode).HasMaxLength(1);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.Description).HasMaxLength(256);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InvoiceId).HasMaxLength(16);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.Total).HasPrecision(7, 2);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallationPrice).HasPrecision(7, 2);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallationCost).HasPrecision(9, 4).IsOptional();
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.TaxAmount).HasPrecision(8, 2);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.Comments).HasMaxLength(1000);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.FeedbackId).HasColumnName("result_sol").HasMaxLength(1).IsOptional();
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.SuspendPreviosStatus).HasColumnName("SuspendPrevStatus").HasMaxLength(1).IsOptional();
            modelBuilder.Entity<InstallationRequestEntity>()
                        .Property(t => t.ReasonOfSuspend)
                        .HasColumnName("comm_susp");
            modelBuilder.Entity<InstallationRequestEntity>()
                        .Property(t => t.GuaranteeFeeSource)
                        .HasColumnName("Cargoa")
                        .HasMaxLength(10);
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.GuaranteeFeeSource).IsOptional();
            modelBuilder.Entity<InstallationRequestEntity>().Property(t => t.InstallerReassignReason).HasMaxLength(100).IsOptional();

            modelBuilder.Entity<InstallationRequestEntity>()
                .HasOptional(t => t.Installer)
                .WithMany(t => t.InstallRequests)
                .HasForeignKey(t => t.InstallerId);

            modelBuilder.Entity<InstallationRequestEntity>()
                .HasRequired(t => t.Customer)
                .WithMany(t => t.InstallationRequests)
                .HasForeignKey(t => new { t.CustomerNo, t.CustomerSubKey });

            modelBuilder.Entity<InstallationRequestEntity>()
                .HasRequired(t => t.Order)
                .WithMany(t => t.InstallationRequests)
                .HasForeignKey(t => t.OrderNo);

            modelBuilder.Entity<InstallationRequestEntity>()
                .HasMany(t => t.Details)
                .WithRequired(t => t.Request)
                .HasForeignKey(t => t.RequestId);

            modelBuilder.Entity<InstallationRequestEntity>()
                .HasRequired(t => t.InstallationPack)
                .WithMany(t => t.Requests)
                .HasForeignKey(t => t.PackId);

            modelBuilder.Entity<InstallationRequestEntity>()
                .HasOptional(s => s.Invoice)
                .WithMany(s => s.Requests)
                .HasForeignKey(s => new { s.InvoiceId, s.InstallerId });
        }

        private static void InstallRequestDetailConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallationRequestDetailEntity>().ToTable("InstSolDet");
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.RequestId).HasColumnName("solicID");
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.RequestSequence).HasColumnName("solseq");
            modelBuilder.Entity<InstallationRequestDetailEntity>().HasKey(t => new { t.RequestId, t.RequestSequence });
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.Price).HasColumnName("InstPrice");
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.Cost).HasColumnName("InstCost");
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.PackId).HasColumnName("ServhdrID");
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.PackServiceSequence).HasColumnName("ServSeq");
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.Price).HasPrecision(7, 2);
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.Cost).HasPrecision(9, 4);
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.Quantity).HasPrecision(7, 2);
            modelBuilder.Entity<InstallationRequestDetailEntity>().Property(t => t.Description).HasMaxLength(256);

            modelBuilder.Entity<InstallationRequestDetailEntity>()
                .HasRequired(t => t.InstallationPackDetail)
                .WithMany(t => t.RequestDetails)
                .HasForeignKey(t => new { t.PackId, t.PackServiceSequence });
        }

        private static void InstallerConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallerEntity>().ToTable("Installer");
            modelBuilder.Entity<InstallerEntity>()
                .Property(t => t.Id)
                .HasColumnName("installerID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<InstallerEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<InstallerEntity>().Property(t => t.TotalInstalls).HasColumnName("Inst_total");
        }

        private static void InstallerInvoiceConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallerInvoiceEntity>().ToTable("InstInv");
            modelBuilder.Entity<InstallerInvoiceEntity>().HasKey(t => new { t.InvoiceId, t.InstallerId });

            modelBuilder.Entity<InstallerInvoiceEntity>().Property(t => t.InvoiceId).HasMaxLength(16);
            modelBuilder.Entity<InstallerInvoiceEntity>()
                            .Property(t => t.InvoiceDate)
                            .HasColumnName("InvDate")
                            .HasColumnType("date");
            modelBuilder.Entity<InstallerInvoiceEntity>()
                            .Property(t => t.CreatedDate)
                            .HasColumnName("CreateDate")
                            .HasColumnType("date");
            modelBuilder.Entity<InstallerInvoiceEntity>().Property(t => t.StatusCode).HasMaxLength(1).IsRequired();
            modelBuilder.Entity<InstallerInvoiceEntity>()
                            .Property(t => t.Tax)
                            .HasColumnName("TaxAmount")
                            .HasPrecision(7, 2);
            modelBuilder.Entity<InstallerInvoiceEntity>()
                            .Property(t => t.TotalInstaller)
                            .HasColumnName("TotInstaller")
                            .HasPrecision(7, 2);

            modelBuilder.Entity<InstallerInvoiceEntity>()
                            .HasRequired(s => s.Installer)
                            .WithMany(s => s.Invoices)
                            .HasForeignKey(s => s.InstallerId);

            modelBuilder.Entity<InstallerInvoiceEntity>()
                .HasMany(s => s.Requests)
                .WithOptional(s => s.Invoice)
                .HasForeignKey(s => new { s.InvoiceId, s.InstallerId });
        }

        private static void InstallationAlertConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallationAlertEntity>().ToTable("InstAlert");
            modelBuilder.Entity<InstallationAlertEntity>().HasKey(t => new { t.RequestId, t.AutoSequence });
            modelBuilder.Entity<InstallationAlertEntity>().Property(s => s.RequestId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<InstallationAlertEntity>().Property(t => t.RequestId).HasColumnName("SolicId");
            modelBuilder.Entity<InstallationAlertEntity>().Property(t => t.EscalationLevel).HasColumnName("Nivelescal");
            modelBuilder.Entity<InstallationAlertEntity>().Property(s => s.CreateDate).HasColumnType("date");
            modelBuilder.Entity<InstallationAlertEntity>().Property(s => s.AlertType).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<InstallationAlertEntity>().Property(s => s.StatusCode).HasMaxLength(1).IsRequired();

            modelBuilder.Entity<InstallationAlertEntity>()
                            .HasOptional(s => s.Installer)
                            .WithMany(s => s.InstallationAlerts)
                            .HasForeignKey(s => s.InstallerId);

            modelBuilder.Entity<InstallationAlertEntity>()
                            .HasRequired(s => s.InstallationRequest)
                            .WithMany(s => s.InstallationAlerts)
                            .HasForeignKey(s => s.RequestId);

            modelBuilder.Entity<InstallationAlertEntity>()
                            .HasRequired(s => s.InstallationRequest)
                            .WithMany(s => s.InstallationAlerts)
                            .HasForeignKey(s => s.RequestId);

            modelBuilder.Entity<InstallationAlertEntity>()
                            .HasRequired(s => s.Order)
                            .WithMany(s => s.InstallationAlerts)
                            .HasForeignKey(s => s.OrderNo);
        }

        private static void InstallationLogConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstallationLogEntity>().ToTable("INstBit");
            modelBuilder.Entity<InstallationLogEntity>().Property(t => t.Id).HasColumnName("BitaId");
            modelBuilder.Entity<InstallationLogEntity>().HasKey(t => new { t.Id, t.AutoSequence });
            modelBuilder.Entity<InstallationLogEntity>().Property(s => s.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<InstallationLogEntity>().Property(s => s.AutoSequence).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<InstallationLogEntity>().Property(t => t.RequestId).HasColumnName("SolicId");
            modelBuilder.Entity<InstallationLogEntity>().Property(t => t.Time).HasColumnName("Bit_Time").HasColumnType("time");
            modelBuilder.Entity<InstallationLogEntity>().Property(t => t.CommentsLine1).HasColumnName("Comments__1").HasMaxLength(500).IsRequired();
            modelBuilder.Entity<InstallationLogEntity>().Property(s => s.CreateDate).HasColumnType("date");
            modelBuilder.Entity<InstallationLogEntity>().Property(s => s.Type).HasMaxLength(1).IsRequired();
        }

        private void UnitOfMeasureConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitOfMeasureEntity>().ToTable("InvUom");
            modelBuilder.Entity<UnitOfMeasureEntity>().Property(s => s.Uom).HasColumnName("UOM");
            modelBuilder.Entity<UnitOfMeasureEntity>().HasKey(s => s.Uom);
            modelBuilder.Entity<UnitOfMeasureEntity>().Property(t => t.Uom).HasMaxLength(4);
        }
        #endregion

        #region Customers
        private void AuthrizdSignrConfiguration(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<AuthrizdSignr>().ToTable("AuthrizdSignr");
            modelbuilder.Entity<AuthrizdSignr>().HasKey(s => new { s.CustomerID, s.SubKey, s.Sequence });
        }

        private void CountryConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryEntity>().ToTable("STORE_Countries");
            modelBuilder.Entity<CountryEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CountryEntity>().Property(t => t.Name).HasMaxLength(25).IsUnicode().IsRequired();
            modelBuilder.Entity<CountryEntity>().HasRequired(t => t.Definition).WithRequiredPrincipal(t => t.Country);
            modelBuilder.Entity<CountryEntity>()
                .HasMany(t => t.States)
                .WithRequired(t => t.Country)
                .HasForeignKey(t => t.CountryId);

            modelBuilder.Entity<CountryDefinitionEntity>().ToTable("STORE_CountryDefinitions");
            modelBuilder.Entity<CountryDefinitionEntity>().HasKey(t => t.Id);
        }

        private static void CustomerConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>().ToTable("Customer");
            modelBuilder.Entity<CustomerEntity>().HasKey(t => new { t.CustomerId, t.SubKey });
            modelBuilder.Entity<CustomerEntity>().Property(t => t.FaxNumber).HasMaxLength(16);
            modelBuilder.Entity<CustomerEntity>().Property(t => t.StoreRemarks).HasMaxLength(1000);
            modelBuilder.Entity<CustomerEntity>().Property(t => t.CURP).HasMaxLength(18);
            modelBuilder.Entity<CustomerEntity>().Property(t => t.TaxId).HasColumnName("TaxAuthority");
            modelBuilder.Entity<CustomerEntity>().Property(t => t.JobStateId).HasColumnName("JobState").HasMaxLength(3);
            modelBuilder.Entity<CustomerEntity>().Property(t => t.StateId).HasColumnName("State").HasMaxLength(3);

            modelBuilder.Entity<CustomerEntity>()
                .HasOptional(t => t.Tax)
                .WithMany()
                .HasForeignKey(t => t.TaxId);

            modelBuilder.Entity<CustomerEntity>()
                .HasOptional(t => t.JobState)
                .WithMany(t => t.CustomersJob)
                .HasForeignKey(t => t.JobStateId);

            modelBuilder.Entity<CustomerEntity>()
                .HasOptional(t => t.State)
                .WithMany(t => t.Customers)
                .HasForeignKey(t => t.StateId);

            CustomerIgnore(modelBuilder);
        }

        private static void CustomerIgnore(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.POReference);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.SalesmanNo);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.Discount);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.Contact);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.CreditDate);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.DBRating);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ApprCredLim);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ARCurrent);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.NumbOpenOrd);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.TaxExReason);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PORequired);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.CreditCode);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LoyaltyPtsFlag);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.Anniversary);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PriceCode);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LienLaw);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.OffLineCode);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.DriverLicense);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.MailList);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.TaxExExp);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LastChgDate);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.CustomerStatus);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.EmployeeFlag);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.Downloaded);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.InvoiceHold);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.WebAddr);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.BirthMMDD);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.RenewalAmount);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LoyaltyPts);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.TotalIssued);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.OptEmail);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.OptPhone);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.OptFax);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.OptText);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.OptShare);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.EmailRcpt);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PCIComments__1);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PCIComments__2);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.JobAddr1);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.JobAddr2);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.OutSideSlsID);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LastTranType);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.DiscountCode);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.Taxable);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LastMntDate);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LastRevwDate);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.BalMaintDate);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.LastRefresh);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ECDCode);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.CustTypeNo);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.Terms);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayDays__1);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayDays__2);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayDays__3);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayDays__4);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayDays__5);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayDays__6);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayDays__7);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviDays__1);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviDays__2);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviDays__3);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviDays__4);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviDays__5);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviDays__6);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviDays__7);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.PayTime);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.ReviTime);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.TaxFolio);
            modelBuilder.Entity<CustomerEntity>().Ignore(t => t.StatusDate);
        }

        private static void ProPriceConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProPriceEntity>().ToTable("ProPriceDet");
            modelBuilder.Entity<ProPriceEntity>().HasKey(t => new { t.StartDate, t.SkuId });
            modelBuilder.Entity<ProPriceEntity>().Property(t => t.SkuId).HasColumnName("SKU");
        }

        #endregion

        #region Tender
        
        private static void TenderConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenderEntity>().ToTable("STORE_TenderKeys");
            modelBuilder.Entity<TenderEntity>().HasKey(t => t.TenderId);
            modelBuilder.Entity<TenderEntity>().Property(t => t.Key).HasMaxLength(10);
            modelBuilder.Entity<TenderEntity>().Property(t => t.Description).HasMaxLength(255);
            modelBuilder.Entity<TenderEntity>().HasRequired(t => t.TenderType).WithMany(s => s.Tenders).HasForeignKey(s => s.TenderCode);
        }

        private static void TenderTypeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenderTypeEntity>()
                .Map(s =>
                {
                    s.Properties(t => new { t.TenderCode, t.Description, t.LastTime, t.LastUpdate, t.Rate, t.SafeTender, t.MediaType });
                    s.ToTable("TenderCntrl");
                })
                .Map(s =>
                {
                    s.Properties(t => new { t.TenderCode, t.IsCash, t.IsTransportable, t.IsFormOfPayment, t.FormOfPaymentName });
                    s.ToTable("STORE_TenderCtrlDetails");
                });

            modelBuilder.Entity<TenderTypeEntity>().HasKey(t => t.TenderCode);
            modelBuilder.Entity<TenderTypeEntity>().Property(t => t.TenderCode).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<TenderTypeEntity>().Property(t => t.FormOfPaymentName).HasMaxLength(255);
        }
        
        #endregion

        #region Cash Management

        private static void AcctPeriodConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcctPeriodEntity>().ToTable("AcctPeriod");
            modelBuilder.Entity<AcctPeriodEntity>().HasKey(t => t.IDX_FIELD);
        }
        
        #endregion

        #region PhysicalInventory
        private static void PhyInvConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhyInvEntity>().ToTable("PhyInvs");
        }
        
        private void PhyInvPreCountSchedConfiguration(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<PhyInvPreCountSchedEntity>().ToTable("PhyInvPreCountScheds");
            modelbuilder.Entity<PhyInvPreCountSchedEntity>()
                .HasRequired<BayEntity>(p => p.Bay)
                .WithMany(b => b.PhyInvPreCountScheds)
                .HasForeignKey(p => p.BayId);
        }

        private static void InventoryConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryEntity>().ToTable("InventoryEntity");
            modelBuilder.Entity<InventoryEntity>().HasKey(m => m.InventoryDate);
            modelBuilder.Entity<InventoryEntity>().Property(m => m.InventoryDate).HasColumnName("Inventory_Date");
            modelBuilder.Entity<InventoryEntity>().Property(m => m.InventoryLib).HasColumnName("Inventory_Lib");
        }

        private void PhyInvsImportTempConfiguration(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<PhyInvsImportTempEntity>().ToTable("PhyInvsImportTemp");
        }
        #endregion

        #region Labour Management
        
        private void LabourConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabourEntity>().ToTable("STORE_Labours");
            modelBuilder.Entity<LabourEntity>().HasKey(t => t.Id);
        }
        
        #endregion

        #region Labor Schedule

        private void CustomerServiceDemandConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerServiceDemandEntity>().ToTable("CSDemand");
            modelBuilder.Entity<CustomerServiceDemandEntity>().HasKey(x => new { x.DemandDate, x.JobClass, x.DemandType });
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.DemandType).HasMaxLength(1);
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded1).HasColumnName("DemandedEmp__1");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded2).HasColumnName("DemandedEmp__2");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded3).HasColumnName("DemandedEmp__3");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded4).HasColumnName("DemandedEmp__4");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded5).HasColumnName("DemandedEmp__5");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded6).HasColumnName("DemandedEmp__6");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded7).HasColumnName("DemandedEmp__7");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded8).HasColumnName("DemandedEmp__8");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded9).HasColumnName("DemandedEmp__9");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded10).HasColumnName("DemandedEmp__10");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded11).HasColumnName("DemandedEmp__11");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded12).HasColumnName("DemandedEmp__12");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded13).HasColumnName("DemandedEmp__13");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded14).HasColumnName("DemandedEmp__14");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded15).HasColumnName("DemandedEmp__15");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded16).HasColumnName("DemandedEmp__16");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded17).HasColumnName("DemandedEmp__17");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded18).HasColumnName("DemandedEmp__18");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded19).HasColumnName("DemandedEmp__19");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded20).HasColumnName("DemandedEmp__20");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded21).HasColumnName("DemandedEmp__21");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded22).HasColumnName("DemandedEmp__22");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded23).HasColumnName("DemandedEmp__23");
            modelBuilder.Entity<CustomerServiceDemandEntity>().Property(x => x.Demanded24).HasColumnName("DemandedEmp__24");
        }

        #endregion

        #region EJournal
        private void EJournalItemsTenderDataConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EJournalItemTenderDataEntity>().ToTable("TranTendData");
            modelBuilder.Entity<EJournalItemTenderDataEntity>()
                        .HasKey(s => new { s.TranNumber, s.RegisterId, s.TranDate, s.SigSequence, s.Sequence });
            modelBuilder.Entity<EJournalItemTenderDataEntity>()
                        .HasRequired(s => s.EJournalTender)
                        .WithMany(s => s.TenderData)
                        .HasForeignKey(s => new { s.TranNumber, s.RegisterId, s.TranDate, s.SigSequence });
            modelBuilder.Entity<EJournalItemTenderDataEntity>().Property(t => t.MiscNumber).HasMaxLength(96).IsRequired();
        }

        private void EJournalItemsTenderConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EJournalItemTenderEntity>().ToTable("TranTender");
            modelBuilder.Entity<EJournalItemTenderEntity>()
                        .HasKey(s => new { s.TranNumber, s.RegisterId, s.TranDate, s.SigSequence });
            modelBuilder.Entity<EJournalItemTenderEntity>()
                        .HasRequired(s => s.EJournalItem)
                        .WithMany(s => s.Tenders)
                        .HasForeignKey(s => new { s.TranNumber, s.RegisterId, s.TranDate });
        }

        private void EJournalItemsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EJournalItemEntity>().ToTable("TranTotal");
            modelBuilder.Entity<EJournalItemEntity>().HasKey(s => new { s.TranNumber, s.RegisterId, s.TranDate });
            modelBuilder.Entity<EJournalItemEntity>().Property(t => t.DocumentNumber).HasColumnName("DocNumber");
            modelBuilder.Entity<EJournalItemEntity>().Property(t => t.RecType).HasMaxLength(1).IsRequired();
            modelBuilder.Entity<EJournalItemEntity>().Property(t => t.SoldLastName).HasMaxLength(35).IsRequired();
            modelBuilder.Entity<EJournalItemEntity>().Property(t => t.SoldFirstName).HasMaxLength(35).IsRequired();
            modelBuilder.Entity<EJournalItemEntity>().Property(t => t.SoldMidInit).HasMaxLength(1).IsRequired();
            modelBuilder.Entity<EJournalItemEntity>()
                        .Property(t => t.TranTime)
                        .HasColumnName("EndTime")
                        .HasColumnType("time")
                        .HasPrecision(0);
        }
        #endregion

        private static void GeneratedScheduleDaysConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeneratedScheduleDayEntity>().ToTable("STORE_GeneratedScheduleDays");
            modelBuilder.Entity<GeneratedScheduleDayEntity>().HasKey(t => new { t.EmployeeId, t.Date });
            modelBuilder.Entity<GeneratedScheduleDayEntity>()
                .HasRequired(t => t.Employee)
                .WithMany(t => t.GeneratedScheduleDays)
                .HasForeignKey(t => t.EmployeeId);
            modelBuilder.Entity<GeneratedScheduleDayEntity>()
                .HasOptional(t => t.ReasonType)
                .WithMany(t => t.GeneratedScheduleDays)
                .HasForeignKey(t => t.ReasonId);
        }

        private static void CategoryConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryEntity>().HasKey(t => new { t.DepartmentId, t.ClassId, t.SubClass });
            modelBuilder.Entity<CategoryEntity>().Property(t => t.DepartmentId).HasColumnName("DeptNo");
            modelBuilder.Entity<CategoryEntity>().Property(t => t.ClassId).HasColumnName("ClassNo");
        }

        private static void InventoryAdjustmentsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryAdjustmentEntity>().Property(t => t.RetailPrice).HasPrecision(7, 2);
            modelBuilder.Entity<InventoryAdjustmentEntity>().Property(t => t.QuantityAdjusted).HasPrecision(9, 3);
            modelBuilder.Entity<InventoryAdjustmentEntity>().Property(t => t.Cost).HasPrecision(9, 4);
            modelBuilder.Entity<InventoryAdjustmentEntity>().Property(t => t.OldCost).HasPrecision(9, 4);
            modelBuilder.Entity<InventoryAdjustmentEntity>().Property(t => t.NewCost).HasPrecision(9, 4);
            modelBuilder.Entity<InventoryAdjustmentEntity>().Property(t => t.CurrentAvailable).HasPrecision(9, 3);
        }

        #region Cash Safe

        private static void CmCurrenciesConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmCurrencyEntity>().ToTable("CmCurrencies");
            modelBuilder.Entity<CmCurrencyEntity>().HasKey(t => new { t.Id });
            modelBuilder.Entity<CmCurrencyEntity>().Property(t => t.Rate).HasPrecision(10, 5);
            modelBuilder.Entity<CmCurrencyEntity>().HasMany(t => t.CmTenderCurrencyDenominations).WithRequired(t => t.Currency).HasForeignKey(t => t.CurrencyId);
        }

        private static void CmSafeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmSafeEntity>().ToTable("CmSafe");
            modelBuilder.Entity<CmSafeEntity>().HasKey(t => new { t.TenderId, t.CurrencyId });
            modelBuilder.Entity<CmSafeEntity>().Property(t => t.TenderAmount).HasPrecision(9, 2);
            modelBuilder.Entity<CmSafeEntity>().Property(t => t.TenderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<CmSafeEntity>().Property(t => t.CurrencyId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        private static void CmDenominationsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmDenominationEntity>().ToTable("CmDenominations");
            modelBuilder.Entity<CmDenominationEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmDenominationEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmDenominationEntity>().HasMany(t => t.CmTenderCurrencyDenominations).WithRequired(t => t.Denomination).HasForeignKey(t => t.DenominationId);
        }

        private static void CmTendersConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmTenderEntity>().ToTable("CmTenders");
            modelBuilder.Entity<CmTenderEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmTenderEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmTenderEntity>().HasMany(t => t.CmTenderCurrencyDenominations).WithRequired(t => t.Tender).HasForeignKey(t => t.TenderId);
        }

        private static void CmTenderCurrencyDenominationsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmTenderCurrencyDenominationEntity>().ToTable("CmTenderCurrencyDenominations");
            modelBuilder.Entity<CmTenderCurrencyDenominationEntity>().HasKey(t => new {t.TenderId, t.CurrencyId, t.DenominationId});
            modelBuilder.Entity<CmTenderCurrencyDenominationEntity>().HasRequired(t => t.Currency);
            modelBuilder.Entity<CmTenderCurrencyDenominationEntity>().HasRequired(t => t.Denomination);
            modelBuilder.Entity<CmTenderCurrencyDenominationEntity>().HasRequired(t => t.Tender);
        }

        private static void CmPickupHeadersConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmPickupHeaderEntity>().ToTable("CmPickupHeaders");
            modelBuilder.Entity<CmPickupHeaderEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmPickupHeaderEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmPickupHeaderEntity>().Property(x => x.BalancingMethod).HasMaxLength(20);
            modelBuilder.Entity<CmPickupHeaderEntity>().HasMany(t => t.PickupDetails).WithRequired(t => t.PickupHeader).HasForeignKey(t => t.PickupHdrId);
        }

        private static void CmPickupDetailsConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmPickupDetailEntity>().ToTable("CmPickupDetails");
            modelBuilder.Entity<CmPickupDetailEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmPickupDetailEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmPickupDetailEntity>().HasRequired(t => t.PickupHeader);
            modelBuilder.Entity<CmPickupDetailEntity>().Property(t => t.TenderAmount).HasPrecision(9, 2);
            modelBuilder.Entity<CmPickupDetailEntity>().Property(t => t.Rate).HasPrecision(9, 2);
        }

        private static void CmBalanceHdrConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmBalanceHdrEntity>().ToTable("CmCashBalanceHeaders");
            modelBuilder.Entity<CmBalanceHdrEntity>().HasKey(t => t.Id );
            modelBuilder.Entity<CmBalanceHdrEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmBalanceHdrEntity>().HasMany(t => t.BalanceDetails).WithRequired(t => t.CmCashBalanceHeader).HasForeignKey(t => t.BalanceHdrId);
        }

        private static void CmBalanceDtlConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmBalanceDtlEntity>().ToTable("CmCashBalanceDetails");
            modelBuilder.Entity<CmBalanceDtlEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmBalanceDtlEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmBalanceDtlEntity>().Property(t => t.ActualTenderAmnt).HasPrecision(9,2);
            modelBuilder.Entity<CmBalanceDtlEntity>().Property(t => t.ZReadsAmnt).HasPrecision(9, 2);
            modelBuilder.Entity<CmBalanceDtlEntity>().HasRequired(t => t.CmCashBalanceHeader);
            modelBuilder.Entity<CmBalanceDtlEntity>().HasRequired(t => t.Currency);
            modelBuilder.Entity<CmBalanceDtlEntity>().HasRequired(t => t.Tender);

        }
        
        private static void CmControlConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmControlEntity>().ToTable("CmControl");
            modelBuilder.Entity<CmControlEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmControlEntity>().Property(t => t.StartBankAmount).HasPrecision(8, 2);
            modelBuilder.Entity<CmControlEntity>().Property(t => t.MaxCashDrawer).HasPrecision(8, 2);
        }

        private static void CmLoanConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmLoanEntity>().ToTable("CmLoans");
            modelBuilder.Entity<CmLoanEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmLoanEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

        private static void CmAdjustConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmAdjustEntity>().ToTable("CmAdjusts");
            modelBuilder.Entity<CmAdjustEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmAdjustEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmAdjustEntity>().Property(t => t.PrevSafeAmount).HasPrecision(9, 2);
            modelBuilder.Entity<CmAdjustEntity>().Property(t => t.TenderAmount).HasPrecision(9, 2);
            modelBuilder.Entity<CmAdjustEntity>().Property(t => t.Rate).HasPrecision(10, 5);
        }

        private static void CmDepositHeaderConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmDepositHeaderEntity>().ToTable("CmDepositHeader");
            modelBuilder.Entity<CmDepositHeaderEntity>().HasKey(t => new { t.DepositNumber });
            modelBuilder.Entity<CmDepositHeaderEntity>().Property(t => t.DepositNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        private static void CmDepositDetailConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmDepositDetailEntity>().ToTable("CmDepositDetail");
            modelBuilder.Entity<CmDepositDetailEntity>().HasKey(t => new { t.DepositNumber, t.TenderId, t.CurrencyId });
            modelBuilder.Entity<CmDepositDetailEntity>().Property(t => t.DepositNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<CmDepositDetailEntity>().Property(t => t.TenderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<CmDepositDetailEntity>().Property(t => t.CurrencyId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<CmDepositDetailEntity>().Property(t => t.TenderRate).HasPrecision(10, 5);
            modelBuilder.Entity<CmDepositDetailEntity>().Property(t => t.TenderAmount).HasPrecision(8, 2);
            modelBuilder.Entity<CmDepositDetailEntity>()
             .HasRequired<CmDepositHeaderEntity>(t => t.Deposit)
                            .WithMany(b => b.Tenders)
                            .HasForeignKey(p => p.DepositNumber);
        }

        private static void CmAuditConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmAuditEntity>().ToTable("CmAudits");
            modelBuilder.Entity<CmAuditEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<CmAuditEntity>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CmAuditEntity>().Property(t => t.PrevSafeAmount).HasPrecision(9, 2);
            modelBuilder.Entity<CmAuditEntity>().Property(t => t.TenderAmount).HasPrecision(9, 2);
            modelBuilder.Entity<CmAuditEntity>().Property(t => t.Rate).HasPrecision(10, 5);
        }

        #endregion

        #region ZRead
        private void ZReadConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZReadEntity>().ToTable("TranZRead");
            modelBuilder.Entity<ZReadEntity>().HasKey(s => new { s.RegisterId, s.TranDate, s.TranNumber });

            modelBuilder.Entity<ZReadEntity>().Property(s => s.RecStatus).HasMaxLength(1).IsRequired();
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZTaxAmt).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZDiscountAmt).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZCashAmt).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZMdseAmt).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZNonMdseAmt).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZDeposits).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZPayments).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZPickUps).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadEntity>().Property(s => s.ZLoans).HasPrecision(8, 2);
        }

        private void ZReadTenderTypeConfiguration(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZReadTenderTypeEntity>().ToTable("TranZTender");
            modelBuilder.Entity<ZReadTenderTypeEntity>()
                .HasKey(s => new { s.RegisterId, s.TranDate, s.TranNumber, s.TenderCode })
                .HasRequired(s => s.ZRead)
                .WithMany(s => s.ZReadTenders)
                .HasForeignKey(s => new { s.RegisterId, s.TranDate, s.TranNumber });

            modelBuilder.Entity<ZReadTenderTypeEntity>().Property(s => s.ZTenderAmt).HasPrecision(8, 2);
            modelBuilder.Entity<ZReadTenderTypeEntity>().Property(s => s.ZForeignAmt).HasPrecision(8, 2);
        }
        #endregion
    }
}
