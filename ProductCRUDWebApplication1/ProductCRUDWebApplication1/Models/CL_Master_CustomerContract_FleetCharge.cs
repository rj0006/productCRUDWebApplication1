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
    
    public partial class CL_Master_CustomerContract_FleetCharge
    {
        public short ContractId { get; set; }
        public byte FtlTypeId { get; set; }
        public byte ChargeCode { get; set; }
        public byte MatrixType { get; set; }
        public short ToLocation { get; set; }
        public short VehicleId { get; set; }
        public decimal FixedAmount { get; set; }
        public decimal FixedKm { get; set; }
        public decimal VariableRate { get; set; }
        public byte RateType { get; set; }
        public byte ProductId { get; set; }
        public Nullable<short> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<decimal> ExtraDaysRate { get; set; }
        public Nullable<decimal> ExtraHoursRate { get; set; }
        public Nullable<decimal> WorkingHours { get; set; }
        public Nullable<decimal> OtherFixedAmount { get; set; }
        public Nullable<long> LaneId { get; set; }
        public Nullable<decimal> FixedChargePerTrip { get; set; }
        public Nullable<decimal> VariableBaseAmtPerTrip { get; set; }
        public Nullable<decimal> FuelPrice { get; set; }
        public Nullable<decimal> TollAmount { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual CL_Master_CustomerContract CL_Master_CustomerContract { get; set; }
    }
}
