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
    
    public partial class CL_Master_JobOrder_TaskType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Master_JobOrder_TaskType()
        {
            this.CL_JobOrder_Task_Detail = new HashSet<CL_JobOrder_Task_Detail>();
            this.CL_Master_JobOrder_Task = new HashSet<CL_Master_JobOrder_Task>();
        }
    
        public byte TaskTypeId { get; set; }
        public string TaskType { get; set; }
        public short AccountId { get; set; }
        public bool IsActive { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<short> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_JobOrder_Task_Detail> CL_JobOrder_Task_Detail { get; set; }
        public virtual CL_Master_Account CL_Master_Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_JobOrder_Task> CL_Master_JobOrder_Task { get; set; }
    }
}