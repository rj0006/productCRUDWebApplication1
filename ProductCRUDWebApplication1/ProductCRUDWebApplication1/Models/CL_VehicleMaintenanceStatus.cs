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
    
    public partial class CL_VehicleMaintenanceStatus
    {
        public int ID { get; set; }
        public short VehicleId { get; set; }
        public int VehicleStatus { get; set; }
        public System.DateTime CurrDate { get; set; }
        public string Remarks { get; set; }
        public string SpareParts { get; set; }
        public System.DateTime ExpectdDate { get; set; }
        public string DocumentName { get; set; }
        public Nullable<decimal> ExpenseAmount { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDateTime { get; set; }
    }
}