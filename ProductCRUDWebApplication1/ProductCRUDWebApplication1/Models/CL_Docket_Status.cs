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
    
    public partial class CL_Docket_Status
    {
        public long DocketId { get; set; }
        public string DocketSuffix { get; set; }
        public System.DateTime StatueDate { get; set; }
        public string Status { get; set; }
        public System.DateTime EntryDate { get; set; }
        public short LocationId { get; set; }
        public byte StatusId { get; set; }
    
        public virtual CL_Docket_Summary CL_Docket_Summary { get; set; }
        public virtual CL_Master_Location CL_Master_Location { get; set; }
    }
}
