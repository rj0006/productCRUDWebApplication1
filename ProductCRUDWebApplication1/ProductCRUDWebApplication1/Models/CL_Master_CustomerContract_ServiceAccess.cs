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
    
    public partial class CL_Master_CustomerContract_ServiceAccess
    {
        public short ContractId { get; set; }
        public short ServiceTypeId { get; set; }
        public byte ServiceId { get; set; }
        public byte TransportModeId { get; set; }
    
        public virtual CL_Master_CustomerContract CL_Master_CustomerContract { get; set; }
    }
}
