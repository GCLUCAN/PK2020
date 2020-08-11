﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KitandaSoftERP.Dominio.Entidades.Seguranca
{
    public class Configuracao : Retorno.Retorno
    {
        public int Idioma { get; set; }
        public int Country { get; set; }
        public int Currency { get; set; }
        public int DefaultWarehouse { get; set; }
        public string DefaultAddressOnSalesDocuments { get; set; }
        public string PosDefaultAccount { get; set; }
        public int PosSalesDefaultDocument { get; set; }
        public int PosDefaultPaymentDeadLine { get; set; }
        public int PosDefaultExpedition { get; set; }
        public int PosDefaultCustomer { get; set; }
        public int PosDocumentStatus { get; set; }
        public string PosPageAfterSale { get; set; }
        public bool PosShowkeyBoard { get; set; }
        public int PosDefaultProductCategory { get; set; }
        public int PosNumberListedProduct { get; set; }
        public int PosDefaultWarehouse { get; set; }
        public Filial BranchDetails { get; set; }
        public int PaymentStatus { get; set; }
        public string POSOpenClosureMode { get; set; }
        public string PosControlMode { get; set; }
        public int PosAllowCodeConfirmation { get; set; }
        public int PosAllowMultipleCloses { get; set; }
        public string PosPrinterName { get; set; }
        public string CurrencySimbol { get; set; }
        public int SerieFaturacao { get; set; }
        public string SupervisorID { get; set; }
        public int PosDefaultSerie { get; set; }
        public int DefaultPaymentMethodID { get; set; }
        public object KitchenMonitorActive { get; set; }
        public object RestKitchenPrinterName { get; set; }
        public object DefaultPOSOpenDocumentID { get; set; }
        public object DefaultPosClosureDocumentID { get; set; }
        public object DefaultPOSIncomeDocumentID { get; set; }
        public object DefaultPOsOutDocumentID { get; set; }
        public string StockMode { get; set; }
        public bool NotifyStockLevel { get; set; }
        public bool ExpirationDateNotify { get; set; }
        public int StartExpireNotification { get; set; }
        public bool AllowSalesOnlyValidLote { get; set; }
        public string DefaultBarcodeLabel { get; set; }
        public string RestModalidade { get; set; }
        public bool AllowAutomaticChangePVP { get; set; }
        public string DefaultSalesDocumentDate { get; set; }
        public string DefaultPurchaseDocumentDate { get; set; }
        public bool IsMandatoryNIF { get; set; }
        public int PosDefaultPaymentMethod { get; set; }
        public decimal PosWorkCapital { get; set; }
        public bool AllowEntityWithDuplicatedNIF { get; set; }
        public bool AllowIgnorePaymentMethod { get; set; }
        public string PosOnClosedAction { get; set; }
        public int DefaultCustomerPaymentTerms { get; set; }
        public bool MandatoryValidateNIF { get; set; }
        public bool AlertWhenLowPVP { get; set; }
        public bool AlertWhenHasCustomerDownPayment { get; set; }
        public bool AllowBillingWithZero { get; set; }
        public bool MandatoryRetentionOnServices { get; set; }
        public bool AllowSuggestRetentionOnProductFrom { get; set; }
        public bool AllowedAutoBilling { get; set; }
        public string ProfitDefaultCostPrice { get; set; }
        public string ProfitDefaultFormule { get; set; }
        public bool ActiveCustomerFormPaymentMethod { get; set; }
        public int DefaultCustomerPaymentMethod { get; set; }
        public string DefaultCustomerExpedition { get; set; }
        public string DefaultCustomerLocalCarga { get; set; }
        public string DefaultCustomerLocalDescarga { get; set; }
        public int DefaultCustomerSalesDocument { get; set; }
        public int DefaultCustomerSerieSalesDocument { get; set; }
        public int DefaultCustomerSettlement { get; set; }
        public int DefaultCustomerSerieSettlement { get; set; }
        public int DefaultCustomerOrders { get; set; }
        public int DefaultCustomerSerieOrders { get; set; }
        public int DefaultCustomerBudgets { get; set; }
        public int DefaultCustomerSerieBudgets { get; set; }
        public int DefaultCustomerGuiasTransporte { get; set; }
        public int DefaultSerieCustomerGuiasTransporte { get; set; }
        public int DefaultCustomerNotasCredito { get; set; }
        public int DefaultSerieCustomerNotasCredito { get; set; }
        public bool ActiveSuggestSupplierFormPaymentMethod { get; set; }
        public bool ActiveMandatorySelectSupplier { get; set; }
        public string DefaultSupplierPaymentTerms { get; set; }
        public string DefaultSupplierPaymentMethod { get; set; }
        public string DefaultCostPrice { get; set; }
        public string DefaultSupplierExpedition { get; set; }
        public string DefaultSupplierLocalCarga { get; set; }
        public string DefaultSupplierLocalDescarga { get; set; }
        public string DefaultBehaviorOnDeadLineCustomerCredit { get; set; }
        public decimal CustomerDefaultDeadLineCredit { get; set; }
        public string DefaultBehaviorOnDeadLineCustomerPaymentDays { get; set; }
        public int CustomerDefaultDeadLinePaymentDays { get; set; }
        public string DefaultBehaviorOnDeadLineCreditWithSupplier { get; set; }
        public decimal DefaultSupplierDeadLineCredit { get; set; }
        public string DefaultBehaviorOnDeaLinePaymentDaysWithSupplier { get; set; }
        public int DefaultSupplierDeadLinePaymentDays { get; set; }
        public string DefaultBehaviorOnDeadLineOtherEntityCredit { get; set; }
        public decimal DefaultDeadLineOtherEntitiesCredit { get; set; }
        public string DefaultBehaviorOnDeadLineOtherEntityPaymentDays { get; set; }
        public int DefaultDeadLineOtherEntitiesPaymentDays { get; set; }
        public string DefaultReceiptAccount { get; set; }
        public string DefaultPaymentAccount { get; set; }
        public string DesignationDefaultSeriePOS { get; set; }
        public decimal TaxaNormalRetencao { get; set; }
        public List<ArmazemDTO> WareHouseList { get; set; }
        public List<CondicaoPagamentoDTO> CondicaoPagamentoList { get; set; }
        public List<SerieDTO> SeriesList { get; set; }
        public List<MeioExpedicaoDTO> ExpeditionModeList { get; set; }
        public List<MetodoPagamentoDTO> PaymentMethodList { get; set; }
        public bool InvoiceWithLogo { get; set; }
        public string BackupPath { get; set; }
        public bool InvoiceAcumulaQuantidade { get; set; }
        public decimal MargemLucroPadrao { get; set; }
    }
}