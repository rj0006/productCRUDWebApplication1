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
    
    public partial class CL_Master_CustomerContract_RateMatrix
    {
        public short ContractId { get; set; }
        public short RateMatrixId { get; set; }
        public byte TransportModeId { get; set; }
        public bool IsBooking { get; set; }
        public byte BaseOn1 { get; set; }
        public byte BaseCode1 { get; set; }
        public byte BaseOn2 { get; set; }
        public byte BaseCode2 { get; set; }
        public byte FtlTypeId { get; set; }
        public byte ChargeCode { get; set; }
        public byte MatrixType { get; set; }
        public short FromLocation { get; set; }
        public short ToLocation { get; set; }
        public Nullable<short> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual CL_Master_CustomerContract CL_Master_CustomerContract { get; set; }
    }
}