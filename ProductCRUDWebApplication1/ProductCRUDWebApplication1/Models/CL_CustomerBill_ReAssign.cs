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
    
    public partial class CL_CustomerBill_ReAssign
    {
        public long BillId { get; set; }
        public long CurrentLocation { get; set; }
        public long ToLocationId { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public short EntryBy { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isActive { get; set; }
    }
}
