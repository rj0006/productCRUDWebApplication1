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
    
    public partial class CL_Master_Card_Detail
    {
        public short CardId { get; set; }
        public short VehicleDriverId { get; set; }
        public bool IsVehicle { get; set; }
        public short LastEditBy { get; set; }
        public System.DateTime LastEditDate { get; set; }
    
        public virtual CL_Master_Card CL_Master_Card { get; set; }
    }
}
