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
    
    public partial class CL_Master_CustomerBillFormat
    {
        public short CustomerId { get; set; }
        public byte PaybasId { get; set; }
        public byte TransportModeId { get; set; }
        public byte ServiceTypeId { get; set; }
        public byte FormatId { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
    
        public virtual CL_Master_BillFormat CL_Master_BillFormat { get; set; }
        public virtual CL_Master_Customer CL_Master_Customer { get; set; }
    }
}