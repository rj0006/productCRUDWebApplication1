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
    
    public partial class CL_TripsheetBill_Detail
    {
        public long TripsheetBillId { get; set; }
        public long TripsheetId { get; set; }
        public decimal FreightAmount { get; set; }
        public decimal LabourCharge { get; set; }
        public decimal OtherCharge { get; set; }
        public decimal Amount { get; set; }
        public decimal GstRate { get; set; }
        public decimal Igst { get; set; }
        public decimal Cgst { get; set; }
        public decimal Sgst { get; set; }
        public decimal TotalGst { get; set; }
        public decimal BillTotal { get; set; }
    }
}