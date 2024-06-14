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
    
    public partial class CL_Master_Card
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Master_Card()
        {
            this.CL_Master_Card_Detail = new HashSet<CL_Master_Card_Detail>();
            this.CL_Tripsheet_Oil_Expense = new HashSet<CL_Tripsheet_Oil_Expense>();
            this.CL_Tripsheet_Header = new HashSet<CL_Tripsheet_Header>();
        }
    
        public short CardId { get; set; }
        public string CardNo { get; set; }
        public Nullable<short> VendorId { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public short AccountId { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<short> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int IsFuelCard { get; set; }
        public decimal CardLimit { get; set; }
        public Nullable<decimal> BalanceAmount { get; set; }
    
        public virtual CL_Master_Account CL_Master_Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_Card_Detail> CL_Master_Card_Detail { get; set; }
        public virtual CL_Master_Vendor CL_Master_Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Tripsheet_Oil_Expense> CL_Tripsheet_Oil_Expense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Tripsheet_Header> CL_Tripsheet_Header { get; set; }
    }
}