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
    
    public partial class CL_SpareRequest_Detail
    {
        public long SpareRequestId { get; set; }
        public byte SkuId { get; set; }
        public int RequestedQuantity { get; set; }
        public int IssuedQuantity { get; set; }
    
        public virtual CL_Master_SKU CL_Master_SKU { get; set; }
        public virtual CL_SpareRequest_Header CL_SpareRequest_Header { get; set; }
    }
}
