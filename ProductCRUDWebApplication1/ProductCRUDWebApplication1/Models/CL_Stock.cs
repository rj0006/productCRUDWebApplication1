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
    
    public partial class CL_Stock
    {
        public byte CompanyId { get; set; }
        public short WarehouseId { get; set; }
        public long SkuId { get; set; }
        public short BinId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal UnderPickQuantity { get; set; }
        public Nullable<decimal> TotalQuantity { get; set; }
        public Nullable<decimal> UnderOrderQuantity { get; set; }
    }
}