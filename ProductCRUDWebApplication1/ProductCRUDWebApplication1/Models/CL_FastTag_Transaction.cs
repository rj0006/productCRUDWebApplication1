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
    
    public partial class CL_FastTag_Transaction
    {
        public int SrNo { get; set; }
        public string TransactionId { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<System.TimeSpan> TransactionTime { get; set; }
        public Nullable<System.DateTime> TransactionDateTime { get; set; }
        public string Plaza { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleClass { get; set; }
        public string LaneDirection { get; set; }
        public Nullable<decimal> Fare { get; set; }
        public Nullable<short> EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDateTime { get; set; }
        public Nullable<bool> IsMapped { get; set; }
        public Nullable<System.DateTime> MappingDateTime { get; set; }
        public Nullable<long> TripsheetId { get; set; }
    
        public virtual CL_Master_User CL_Master_User { get; set; }
    }
}
