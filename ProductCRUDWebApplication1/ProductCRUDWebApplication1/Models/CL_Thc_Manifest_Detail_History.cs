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
    
    public partial class CL_Thc_Manifest_Detail_History
    {
        public long HistoryId { get; set; }
        public long ThcId { get; set; }
        public long ManifestId { get; set; }
        public Nullable<bool> IsArrived { get; set; }
    
        public virtual CL_Thc_Header_History CL_Thc_Header_History { get; set; }
    }
}
