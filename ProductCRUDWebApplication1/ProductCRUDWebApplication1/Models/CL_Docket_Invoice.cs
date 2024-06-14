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
    
    public partial class CL_Docket_Invoice
    {
        public long DocketId { get; set; }
        public long InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string PartNo { get; set; }
        public string PartDescription { get; set; }
        public short TypeOfPackage { get; set; }
        public decimal Length { get; set; }
        public decimal Breadth { get; set; }
        public decimal Height { get; set; }
        public decimal InvoiceAmount { get; set; }
        public short Packages { get; set; }
        public decimal VolumetricWeight { get; set; }
        public decimal ActualWeight { get; set; }
        public decimal ChargedWeight { get; set; }
        public string EwayBillNo { get; set; }
        public Nullable<System.DateTime> EwayBillIssueDate { get; set; }
        public Nullable<System.DateTime> EwayBillExpiryDate { get; set; }
    
        public virtual CL_Docket CL_Docket { get; set; }
    }
}
