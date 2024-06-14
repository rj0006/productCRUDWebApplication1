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
    
    public partial class CL_Master_VendorContract_CrossingBased
    {
        public short ContractId { get; set; }
        public short FromLocationId { get; set; }
        public Nullable<int> ToCityId { get; set; }
        public byte RateTypeId { get; set; }
        public decimal Rate { get; set; }
        public decimal DoorDeliveryRate { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<short> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual CL_Master_Location CL_Master_Location { get; set; }
        public virtual CL_Master_VendorContract CL_Master_VendorContract { get; set; }
    }
}
