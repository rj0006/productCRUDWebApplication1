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
    
    public partial class CL_Master_Customer_Detail
    {
        public short CustomerId { get; set; }
        public string Password { get; set; }
        public string PanNo { get; set; }
        public string GstTinNo { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public byte IndustryId { get; set; }
        public byte TypeOfOwnershipId { get; set; }
        public string DecisionMakerName { get; set; }
        public string DecisionMakerDesignation { get; set; }
        public string DecisionMakerEmailId { get; set; }
        public string DecisionMakerMobileNo { get; set; }
        public string SalesPersonBookingDealName { get; set; }
        public string SalesPersonBookingDealDesignation { get; set; }
        public string SalesPersonBookingDealEmailId { get; set; }
        public string SalesPersonBookingDealMobileNo { get; set; }
        public string SalesPersonClosingDealName { get; set; }
        public string SalesPersonClosingDealDesignation { get; set; }
        public string SalesPersonClosingDealEmailId { get; set; }
        public string SalesPersonClosingDealMobileNo { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<short> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<short> GSTStateId { get; set; }
        public string BillSeriesStartAs { get; set; }
        public Nullable<bool> IsMilkrunHrsPerDayEnabled { get; set; }
        public Nullable<bool> IsLaneID { get; set; }
        public Nullable<bool> IsWalkIn { get; set; }
        public bool IsTruckForwardNote { get; set; }
    
        public virtual CL_Master_Customer CL_Master_Customer { get; set; }
    }
}
