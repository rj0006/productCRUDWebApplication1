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
    
    public partial class Comm_Email_Config
    {
        public string host { get; set; }
        public Nullable<int> port { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool sslEnabled { get; set; }
        public string fromEmailAddress { get; set; }
        public string HREmailAddress { get; set; }
        public string Tdsemail { get; set; }
        public string SqlEmailProfile { get; set; }
        public string fk_companyId { get; set; }
        public string KRAEmailAddress { get; set; }
        public string LeaveEmailAddress { get; set; }
    }
}
