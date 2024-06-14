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
    
    public partial class CL_Thc_Summary_History
    {
        public long HistoryId { get; set; }
        public long ThcId { get; set; }
        public System.DateTime ThcDate { get; set; }
        public short FromLocationId { get; set; }
        public short ToLocationId { get; set; }
        public Nullable<System.DateTime> ActualDepartureDate { get; set; }
        public Nullable<System.DateTime> ExpectedArrivalDate { get; set; }
        public Nullable<System.DateTime> ActualArrivalDate { get; set; }
        public Nullable<System.DateTime> ExpectedDepartureDate { get; set; }
        public Nullable<System.DateTime> StockUpdateDate { get; set; }
        public string OutgoingSealNo { get; set; }
        public string IncomingSealNo { get; set; }
        public Nullable<byte> IncomingSealStatus { get; set; }
        public string IncomingSealReason { get; set; }
        public int StartKm { get; set; }
        public int EndKm { get; set; }
        public string OutgoingRemark { get; set; }
        public string IncomingRemark { get; set; }
        public short TotalManifest { get; set; }
        public short TotalDocket { get; set; }
        public int TotalPackages { get; set; }
        public decimal TotalActualWeight { get; set; }
        public bool IsOverLoaded { get; set; }
        public Nullable<byte> OverLoadedReasonId { get; set; }
        public decimal TotalWeight { get; set; }
        public Nullable<bool> IsWeightAdded { get; set; }
        public decimal AdjustmentWeight { get; set; }
        public decimal TotalWeightLoaded { get; set; }
        public decimal CapacityUtilization { get; set; }
        public Nullable<byte> LateArrivalReasonId { get; set; }
        public bool IsDeparture { get; set; }
        public short LoadBy { get; set; }
        public System.DateTime LoadDate { get; set; }
        public Nullable<short> UnloadBy { get; set; }
        public Nullable<System.DateTime> UnloadDate { get; set; }
        public Nullable<System.DateTime> ToExpectedDepartureDate { get; set; }
        public string EwayBillNo { get; set; }
        public Nullable<System.DateTime> EwayBillIssueDate { get; set; }
        public Nullable<System.DateTime> EwayBillExpiryDate { get; set; }
    
        public virtual CL_Thc_Header_History CL_Thc_Header_History { get; set; }
    }
}