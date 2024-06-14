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
    
    public partial class CL_Manifest_Detail
    {
        public long ManifestId { get; set; }
        public long DocketId { get; set; }
        public string DocketSuffix { get; set; }
        public int Packages { get; set; }
        public decimal ActualWeight { get; set; }
        public Nullable<bool> isLabourBill { get; set; }
        public Nullable<decimal> LabourAmount { get; set; }
        public Nullable<decimal> DeliveryLabourAmount { get; set; }
        public Nullable<bool> isLabourDeliveryBill { get; set; }
    
        public virtual CL_Docket_Summary CL_Docket_Summary { get; set; }
        public virtual CL_Manifest_Header CL_Manifest_Header { get; set; }
    }
}
