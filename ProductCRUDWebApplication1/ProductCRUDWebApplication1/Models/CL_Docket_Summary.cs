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
    
    public partial class CL_Docket_Summary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Docket_Summary()
        {
            this.CL_Deps_Detail = new HashSet<CL_Deps_Detail>();
            this.CL_Docket_Status = new HashSet<CL_Docket_Status>();
            this.CL_LoadingSheet_Detail = new HashSet<CL_LoadingSheet_Detail>();
            this.CL_Manifest_Detail = new HashSet<CL_Manifest_Detail>();
            this.CL_Mr_Docket_Charge_Detail = new HashSet<CL_Mr_Docket_Charge_Detail>();
            this.CL_Thc_Docket_Detail = new HashSet<CL_Thc_Docket_Detail>();
            this.CL_Docket_Dispatch_Header = new HashSet<CL_Docket_Dispatch_Header>();
        }
    
        public long DocketId { get; set; }
        public string DocketSuffix { get; set; }
        public short ToLocationId { get; set; }
        public int Packages { get; set; }
        public decimal ActualWeight { get; set; }
        public Nullable<decimal> ChargedWeight { get; set; }
        public bool LoadingSheetStatus { get; set; }
        public bool ManifestStatus { get; set; }
        public bool PrsStatus { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public bool IsDelivered { get; set; }
        public int ArrivalPackages { get; set; }
        public int DeliveredPackages { get; set; }
        public bool UnderDrs { get; set; }
        public short CurrentLocationId { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public string DocketStatus { get; set; }
        public string StockType { get; set; }
        public decimal ArrivalWeight { get; set; }
        public string DeliveryPersonName { get; set; }
        public Nullable<byte> LateDeliveryReasonId { get; set; }
        public Nullable<System.DateTime> StockUpdateDate { get; set; }
        public byte StockTypeId { get; set; }
        public bool IsSepd { get; set; }
        public string Remarks { get; set; }
        public byte FlowTypeId { get; set; }
        public byte DeliveryProcessId { get; set; }
        public bool TripsheetStatus { get; set; }
        public bool ThcStatus { get; set; }
        public byte StatusId { get; set; }
        public bool IsTransit { get; set; }
        public Nullable<bool> IsHold { get; set; }
        public bool IsDaccUpdated { get; set; }
        public Nullable<bool> IsAvailableForDRS { get; set; }
        public Nullable<bool> IsTransfered { get; set; }
        public Nullable<byte> DeliveryStatus { get; set; }
        public Nullable<byte> ReceiverType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Deps_Detail> CL_Deps_Detail { get; set; }
        public virtual CL_Docket CL_Docket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Status> CL_Docket_Status { get; set; }
        public virtual CL_Master_Location CL_Master_Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_LoadingSheet_Detail> CL_LoadingSheet_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Manifest_Detail> CL_Manifest_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Mr_Docket_Charge_Detail> CL_Mr_Docket_Charge_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Thc_Docket_Detail> CL_Thc_Docket_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_Dispatch_Header> CL_Docket_Dispatch_Header { get; set; }
    }
}
