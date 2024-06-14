//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductCRUDWebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CL_Docket_Charge_History
    {
        public long HistoryId { get; set; }
        public long DocketId { get; set; }
        public short ContractCustomerId { get; set; }
        public short ContractId { get; set; }
        public short ProductTypeId { get; set; }
        public byte PackagingTypeId { get; set; }
        public byte FtlTypeId { get; set; }
        public byte RateTypeId { get; set; }
        public decimal Freight { get; set; }
        public decimal FreightRate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public bool IsBilled { get; set; }
        public Nullable<decimal> TaxPercentageTotal { get; set; }
        public bool IsFinalize { get; set; }
        public Nullable<System.DateTime> FinalizeDate { get; set; }
        public string DeclarationFileName { get; set; }
        public Nullable<byte> GstSacId { get; set; }
        public Nullable<byte> GstServiceTypeId { get; set; }
        public string GstTinNo { get; set; }
        public bool IsInterState { get; set; }
        public bool IsRcm { get; set; }
        public decimal GstAmount { get; set; }
        public bool IsBillingPartyGstPayer { get; set; }
        public string CompanyGstTinNo { get; set; }
        public Nullable<long> CompanyGstId { get; set; }
        public Nullable<long> PartyGstId { get; set; }
        public Nullable<decimal> VendorFreight { get; set; }
        public Nullable<decimal> VendorFreightRate { get; set; }
        public Nullable<byte> VendorRateTypeId { get; set; }
        public Nullable<short> VendorId { get; set; }
        public Nullable<short> VendorContractId { get; set; }
        public Nullable<decimal> VendorSubTotal { get; set; }
        public Nullable<decimal> VendorTaxTotal { get; set; }
        public Nullable<decimal> VendorGrandTotal { get; set; }
        public Nullable<decimal> VendorGstAmount { get; set; }
        public Nullable<decimal> AdvanceAmount { get; set; }
        public Nullable<decimal> BalanceAmount { get; set; }
        public Nullable<long> AdvanceVoucherId { get; set; }
        public Nullable<bool> IsBaDoorPickup { get; set; }
        public Nullable<bool> IsBaDoorDelivery { get; set; }
        public Nullable<decimal> BookingKartAmount { get; set; }
        public Nullable<bool> IsBulky { get; set; }
        public Nullable<decimal> BulkyAmount { get; set; }
        public Nullable<decimal> DeliveryKartAmount { get; set; }
        public Nullable<short> BookingKartBaId { get; set; }
        public Nullable<short> DeliveryKartBaId { get; set; }
        public Nullable<byte> GstPaidById { get; set; }
        public Nullable<short> FreightContractId { get; set; }
        public Nullable<short> GstStateId { get; set; }
        public Nullable<short> BillingStateId { get; set; }
    
        public virtual CL_Docket_History CL_Docket_History { get; set; }
    }
}