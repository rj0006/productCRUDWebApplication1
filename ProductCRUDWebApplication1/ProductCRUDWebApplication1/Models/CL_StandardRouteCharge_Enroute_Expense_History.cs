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
    
    public partial class CL_StandardRouteCharge_Enroute_Expense_History
    {
        public int SrNo { get; set; }
        public Nullable<short> RouteId { get; set; }
        public Nullable<short> VehicleTypeId { get; set; }
        public Nullable<byte> ChargeCode { get; set; }
        public Nullable<decimal> ChargeRate { get; set; }
        public Nullable<short> EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<decimal> StandardFuelInLiters { get; set; }
        public Nullable<decimal> StandardAdvanceAmount { get; set; }
    
        public virtual CL_Master_Route_CityWise CL_Master_Route_CityWise { get; set; }
        public virtual CL_Master_User CL_Master_User { get; set; }
    }
}