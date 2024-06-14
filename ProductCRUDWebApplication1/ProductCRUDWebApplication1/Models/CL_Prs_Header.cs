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
    
    public partial class CL_Prs_Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Prs_Header()
        {
            this.CL_Prs_Charge_Detail = new HashSet<CL_Prs_Charge_Detail>();
            this.CL_Docket = new HashSet<CL_Docket>();
        }
    
        public long PrsId { get; set; }
        public string PrsNo { get; set; }
        public System.DateTime PrsDate { get; set; }
        public System.TimeSpan PrsTime { get; set; }
        public Nullable<System.DateTime> PrsDateTime { get; set; }
        public string ManualPrsNo { get; set; }
        public short LocationId { get; set; }
        public bool IsAdhoc { get; set; }
        public Nullable<short> ContractId { get; set; }
        public short VendorId { get; set; }
        public string VendorName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierMobileNo { get; set; }
        public Nullable<int> TripsheetId { get; set; }
        public short VehicleId { get; set; }
        public string VehicleNo { get; set; }
        public short VehicleTypeId { get; set; }
        public short FtlTypeId { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public string EngineNo { get; set; }
        public string ChassisNo { get; set; }
        public string RcBookNo { get; set; }
        public System.DateTime InsuranceValidityDate { get; set; }
        public System.DateTime FitnessValidityDate { get; set; }
        public System.DateTime PermitValidityDate { get; set; }
        public string FirstDriverName { get; set; }
        public string FirstDriverMobileNo { get; set; }
        public string FirstDriverLicenseNo { get; set; }
        public string FirstDriverLicenseIssueBy { get; set; }
        public System.DateTime FirstDriverLicenseValidityDate { get; set; }
        public string SecondDriverName { get; set; }
        public string SecondDriverMobileNo { get; set; }
        public string SecondDriverLicenseNo { get; set; }
        public string SecondDriverLicenseIssueBy { get; set; }
        public Nullable<System.DateTime> SecondDriverLicenseValidityDate { get; set; }
        public int StartKm { get; set; }
        public int EndKm { get; set; }
        public string OutgoingRemark { get; set; }
        public bool IsOverLoaded { get; set; }
        public Nullable<byte> OverLoadedReasonId { get; set; }
        public decimal WeightLoaded { get; set; }
        public decimal CapacityUtilization { get; set; }
        public short TotalDocket { get; set; }
        public int TotalPackages { get; set; }
        public decimal TotalActualWeight { get; set; }
        public decimal ContractAmount { get; set; }
        public short BalanceLocationId { get; set; }
        public decimal AdvanceAmount { get; set; }
        public Nullable<short> AdvanceLocationId { get; set; }
        public byte FinacialStatus { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public string CancelReason { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public byte CompanyId { get; set; }
        public decimal OtherAmount { get; set; }
        public Nullable<short> CancelBy { get; set; }
        public string EwayBillNo { get; set; }
        public Nullable<System.DateTime> EwayBillIssueDate { get; set; }
        public Nullable<System.DateTime> EwayBillExpiryDate { get; set; }
        public byte TransportModeId { get; set; }
        public Nullable<short> FromCityId { get; set; }
        public Nullable<short> ToCityId { get; set; }
        public Nullable<short> LocationUpdatedBy { get; set; }
        public Nullable<System.DateTime> LocationUpdatedDate { get; set; }
        public bool IsOutCapacity { get; set; }
        public Nullable<bool> IsMultiAdvApply { get; set; }
        public Nullable<bool> isLabourBilling { get; set; }
        public Nullable<decimal> KantaWeight { get; set; }
        public string SlipNo { get; set; }
        public string ReasonForWeightLoss { get; set; }
        public Nullable<bool> IsAdvancePaymentDone { get; set; }
    
        public virtual CL_Master_Location CL_Master_Location { get; set; }
        public virtual CL_Master_User CL_Master_User { get; set; }
        public virtual CL_Master_Vehicle CL_Master_Vehicle { get; set; }
        public virtual CL_Master_Vendor CL_Master_Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Prs_Charge_Detail> CL_Prs_Charge_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket> CL_Docket { get; set; }
    }
}
