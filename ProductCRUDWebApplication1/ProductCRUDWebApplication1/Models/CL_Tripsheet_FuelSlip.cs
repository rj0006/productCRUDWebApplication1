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
    
    public partial class CL_Tripsheet_FuelSlip
    {
        public long TripsheetId { get; set; }
        public short VendorId { get; set; }
        public string FuelSlipNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.DateTime FuelSlipDate { get; set; }
        public Nullable<short> CityId { get; set; }
        public Nullable<bool> isBilled { get; set; }
        public Nullable<long> BillId { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<short> CancelBy { get; set; }
        public string CancelReason { get; set; }
    
        public virtual CL_Master_Vendor CL_Master_Vendor { get; set; }
        public virtual CL_Tripsheet_Header CL_Tripsheet_Header { get; set; }
    }
}