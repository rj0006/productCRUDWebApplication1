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
    
    public partial class CL_Master_Vendor_VendorService_Mapping
    {
        public short VendorId { get; set; }
        public byte VendorServiceId { get; set; }
    
        public virtual CL_Master_Vendor CL_Master_Vendor { get; set; }
    }
}
