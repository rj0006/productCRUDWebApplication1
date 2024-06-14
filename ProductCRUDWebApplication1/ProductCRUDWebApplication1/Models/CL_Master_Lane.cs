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
    
    public partial class CL_Master_Lane
    {
        public long ID { get; set; }
        public byte CompanyId { get; set; }
        public short CustomerId { get; set; }
        public string LaneId { get; set; }
        public string MasterLaneId { get; set; }
        public int RouteId { get; set; }
        public int FTLTypeId { get; set; }
        public int FuelTypeId { get; set; }
        public decimal ContractedKM { get; set; }
        public int AssetCount { get; set; }
        public int DriverCount { get; set; }
        public bool IsActive { get; set; }
        public string EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual CL_Master_Company CL_Master_Company { get; set; }
        public virtual CL_Master_Customer CL_Master_Customer { get; set; }
    }
}
