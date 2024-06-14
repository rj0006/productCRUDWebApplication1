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
    
    public partial class CL_PurchaseOrder_Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_PurchaseOrder_Header()
        {
            this.CL_PO_Grn_Detail = new HashSet<CL_PO_Grn_Detail>();
            this.CL_PO_Grn_Header = new HashSet<CL_PO_Grn_Header>();
            this.CL_PurchaseOrder_Detail = new HashSet<CL_PurchaseOrder_Detail>();
        }
    
        public long PoId { get; set; }
        public string PoNo { get; set; }
        public string ManualPoNo { get; set; }
        public System.DateTime PoDate { get; set; }
        public short LocationId { get; set; }
        public byte MaterialCategoryId { get; set; }
        public short VendorId { get; set; }
        public string Remarks { get; set; }
        public decimal Amount { get; set; }
        public decimal AdvanceAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string CancelReason { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public bool IsApprove { get; set; }
        public Nullable<System.DateTime> ApproveDate { get; set; }
        public Nullable<short> ApproveBy { get; set; }
        public bool GrnStatus { get; set; }
        public Nullable<long> VoucherId { get; set; }
    
        public virtual CL_Master_Location CL_Master_Location { get; set; }
        public virtual CL_Master_Vendor CL_Master_Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_PO_Grn_Detail> CL_PO_Grn_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_PO_Grn_Header> CL_PO_Grn_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_PurchaseOrder_Detail> CL_PurchaseOrder_Detail { get; set; }
        public virtual CL_Voucher_Detail CL_Voucher_Detail { get; set; }
    }
}
