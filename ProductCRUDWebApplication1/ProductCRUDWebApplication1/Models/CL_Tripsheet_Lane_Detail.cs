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
    
    public partial class CL_Tripsheet_Lane_Detail
    {
        public long TSLaneDetailID { get; set; }
        public byte CompanyId { get; set; }
        public short CustomerId { get; set; }
        public long TripsheetId { get; set; }
        public long LaneId { get; set; }
        public short FSCRateId { get; set; }
        public Nullable<short> ContractID { get; set; }
        public string TourId { get; set; }
        public string ErId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<decimal> FixedAmount { get; set; }
        public Nullable<decimal> VariableBaseAmtPerTrip { get; set; }
        public Nullable<decimal> TotalTripFSCAmount { get; set; }
        public Nullable<decimal> TollAmount { get; set; }
        public Nullable<decimal> AdditionalKM { get; set; }
        public Nullable<decimal> AdditionalAmountKM { get; set; }
        public Nullable<decimal> OtherCharge { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Remark { get; set; }
        public string EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual CL_Tripsheet_Header CL_Tripsheet_Header { get; set; }
    }
}