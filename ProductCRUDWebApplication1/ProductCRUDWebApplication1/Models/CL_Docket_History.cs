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
    
    public partial class CL_Docket_History
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Docket_History()
        {
            this.CL_Docket_Charge_Detail_History = new HashSet<CL_Docket_Charge_Detail_History>();
            this.CL_Docket_Charge_History = new HashSet<CL_Docket_Charge_History>();
            this.CL_Docket_Detail_History = new HashSet<CL_Docket_Detail_History>();
            this.CL_Docket_Document_History = new HashSet<CL_Docket_Document_History>();
            this.CL_Docket_Invoice_History = new HashSet<CL_Docket_Invoice_History>();
            this.CL_Docket_Invoice_Part_History = new HashSet<CL_Docket_Invoice_Part_History>();
            this.CL_Docket_Summary_History = new HashSet<CL_Docket_Summary_History>();
            this.CL_Docket_Tax_Detail_History = new HashSet<CL_Docket_Tax_Detail_History>();
        }
    
        public long HistoryId { get; set; }
        public long DocketId { get; set; }
        public string DocketNo { get; set; }
        public Nullable<System.DateTime> DocketDate { get; set; }
        public Nullable<short> FromLocationId { get; set; }
        public Nullable<short> ToLocationId { get; set; }
        public Nullable<short> FromCityId { get; set; }
        public Nullable<short> ToCityId { get; set; }
        public Nullable<byte> TransportModeId { get; set; }
        public Nullable<byte> PaybasId { get; set; }
        public Nullable<System.DateTime> Edd { get; set; }
        public Nullable<int> Packages { get; set; }
        public Nullable<decimal> ActualWeight { get; set; }
        public Nullable<decimal> ChargedWeight { get; set; }
        public Nullable<byte> BusinessTypeId { get; set; }
        public Nullable<byte> ServiceTypeId { get; set; }
        public Nullable<short> BillLocationId { get; set; }
        public string CustomerReferenceNo { get; set; }
        public Nullable<short> EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<byte> CompanyId { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string CancelReason { get; set; }
        public Nullable<short> CancelBy { get; set; }
        public Nullable<bool> IsTpl { get; set; }
        public string CustomerDocketNo { get; set; }
        public Nullable<bool> IsOld { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Charge_Detail_History> CL_Docket_Charge_Detail_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Charge_History> CL_Docket_Charge_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Detail_History> CL_Docket_Detail_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Document_History> CL_Docket_Document_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Invoice_History> CL_Docket_Invoice_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Invoice_Part_History> CL_Docket_Invoice_Part_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Summary_History> CL_Docket_Summary_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Tax_Detail_History> CL_Docket_Tax_Detail_History { get; set; }
    }
}
