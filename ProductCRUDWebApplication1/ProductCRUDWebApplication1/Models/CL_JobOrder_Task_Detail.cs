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
    
    public partial class CL_JobOrder_Task_Detail
    {
        public long JobOrderId { get; set; }
        public byte WorkGroupId { get; set; }
        public byte TaskTypeId { get; set; }
        public short TaskId { get; set; }
        public byte EstimatedLabourHours { get; set; }
        public decimal EstimatedLabourCost { get; set; }
        public string Remarks { get; set; }
        public string Action { get; set; }
        public Nullable<bool> AmcType { get; set; }
        public decimal ActualLabourCost { get; set; }
    
        public virtual CL_JobOrder_Header CL_JobOrder_Header { get; set; }
        public virtual CL_Master_JobOrder_Task CL_Master_JobOrder_Task { get; set; }
        public virtual CL_Master_JobOrder_TaskType CL_Master_JobOrder_TaskType { get; set; }
        public virtual CL_Master_JobOrder_WorkGroup CL_Master_JobOrder_WorkGroup { get; set; }
    }
}
