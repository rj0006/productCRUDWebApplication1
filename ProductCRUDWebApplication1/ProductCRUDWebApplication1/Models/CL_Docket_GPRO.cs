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
    
    public partial class CL_Docket_GPRO
    {
        public long DocketId { get; set; }
        public Nullable<int> SNo { get; set; }
        public string GPNo { get; set; }
        public Nullable<System.DateTime> GPDate { get; set; }
        public string RONo { get; set; }
        public Nullable<System.DateTime> RODate { get; set; }
        public bool isActive { get; set; }
    }
}
