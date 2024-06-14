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
    
    public partial class CL_Unloading_Header
    {
        public long UnloadingId { get; set; }
        public string UnloadingNo { get; set; }
        public System.DateTime UnloadingDate { get; set; }
        public short LocationId { get; set; }
        public bool IsMarketVehicle { get; set; }
        public short VehicleId { get; set; }
        public string VehicleNo { get; set; }
        public short FromCityId { get; set; }
        public short ToCityId { get; set; }
        public short DriverId { get; set; }
        public short WarehouseId { get; set; }
        public short AccountId { get; set; }
        public string Remark { get; set; }
        public string UnloadingDocumentName { get; set; }
        public byte CompanyId { get; set; }
        public int TotalPackages { get; set; }
        public decimal TotalFreight { get; set; }
        public decimal LoadingCharges { get; set; }
        public decimal UnLoadingCharges { get; set; }
        public decimal TotalActualWeight { get; set; }
        public decimal TotalChargedWeight { get; set; }
        public decimal AdvanceFreight { get; set; }
        public decimal BalanceFreight { get; set; }
        public decimal DeliveryCommission { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalTopayAmount { get; set; }
        public decimal DoorDelivery { get; set; }
        public decimal KartAmount { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
    
        public virtual CL_Master_Company CL_Master_Company { get; set; }
        public virtual CL_Master_Location CL_Master_Location { get; set; }
    }
}
