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
    
    public partial class CL_Mr_Bill_Detail
    {
        public long MrId { get; set; }
        public long BillId { get; set; }
        public decimal BillAmount { get; set; }
        public Nullable<decimal> ClaimDeduction { get; set; }
        public Nullable<decimal> FreightDiscount { get; set; }
        public Nullable<decimal> OtherDeduction { get; set; }
        public Nullable<decimal> OtherAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string Remarks { get; set; }
        public decimal TdsAmount { get; set; }
        public decimal CollectionAmount { get; set; }
        public decimal PendingAmount { get; set; }
    
        public virtual CL_CustomerBill_Header CL_CustomerBill_Header { get; set; }
        public virtual CL_Mr_Header CL_Mr_Header { get; set; }
    }
}