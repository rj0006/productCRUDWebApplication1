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
    
    public partial class CL_Master_Approval_History
    {
        public int SrNo { get; set; }
        public Nullable<short> EventId { get; set; }
        public string Approver { get; set; }
        public Nullable<short> EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDateTime { get; set; }
    }
}