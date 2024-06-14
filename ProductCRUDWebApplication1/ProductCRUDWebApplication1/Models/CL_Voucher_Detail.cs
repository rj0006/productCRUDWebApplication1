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
    
    public partial class CL_Voucher_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Voucher_Detail()
        {
            this.CL_Docket_Charge = new HashSet<CL_Docket_Charge>();
            this.CL_PurchaseOrder_Header = new HashSet<CL_PurchaseOrder_Header>();
            this.CL_Tripsheet_Advance = new HashSet<CL_Tripsheet_Advance>();
            this.CL_VendorPayment_Header = new HashSet<CL_VendorPayment_Header>();
            this.CL_Voucher_AccountDetail = new HashSet<CL_Voucher_AccountDetail>();
            this.CL_Tripsheet_DriverSettlement = new HashSet<CL_Tripsheet_DriverSettlement>();
        }
    
        public long VoucherId { get; set; }
        public string VoucherNo { get; set; }
        public string ManualVoucharNo { get; set; }
        public System.DateTime VoucherDate { get; set; }
        public System.TimeSpan VoucherTime { get; set; }
        public Nullable<System.DateTime> VoucherDateTime { get; set; }
        public short LocationId { get; set; }
        public Nullable<long> ChequeId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public bool IsByCash { get; set; }
        public string PartyCode { get; set; }
        public byte PartyType { get; set; }
        public string Narration { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<short> CancelBy { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public byte CompanyId { get; set; }
        public string PartyName { get; set; }
        public Nullable<byte> TransactionType { get; set; }
        public byte EntryModuleId { get; set; }
        public bool ByCheque { get; set; }
        public string CancelReason { get; set; }
        public Nullable<long> ChequeId2 { get; set; }
        public Nullable<bool> IsOnAccountCollection { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Charge> CL_Docket_Charge { get; set; }
        public virtual CL_Master_Location CL_Master_Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_PurchaseOrder_Header> CL_PurchaseOrder_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Tripsheet_Advance> CL_Tripsheet_Advance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_VendorPayment_Header> CL_VendorPayment_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Voucher_AccountDetail> CL_Voucher_AccountDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Tripsheet_DriverSettlement> CL_Tripsheet_DriverSettlement { get; set; }
        public virtual CL_Voucher_Summary CL_Voucher_Summary { get; set; }
    }
}