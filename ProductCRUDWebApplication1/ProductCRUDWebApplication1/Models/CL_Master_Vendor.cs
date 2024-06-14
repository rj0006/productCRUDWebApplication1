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
    
    public partial class CL_Master_Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Master_Vendor()
        {
            this.CL_Docket_BookingChallan = new HashSet<CL_Docket_BookingChallan>();
            this.CL_Master_Card = new HashSet<CL_Master_Card>();
            this.CL_Master_Fuel_Card = new HashSet<CL_Master_Fuel_Card>();
            this.CL_Master_CityWiseFuelRate_History = new HashSet<CL_Master_CityWiseFuelRate_History>();
            this.CL_Master_CityWiseFuelRate_History1 = new HashSet<CL_Master_CityWiseFuelRate_History>();
            this.CL_Master_VendorContract = new HashSet<CL_Master_VendorContract>();
            this.CL_Master_Vendor_Gst_Detail = new HashSet<CL_Master_Vendor_Gst_Detail>();
            this.CL_Master_Vendor_VendorService_Mapping = new HashSet<CL_Master_Vendor_VendorService_Mapping>();
            this.CL_Prs_Header = new HashSet<CL_Prs_Header>();
            this.CL_PurchaseOrder_Header = new HashSet<CL_PurchaseOrder_Header>();
            this.CL_Thc_Header = new HashSet<CL_Thc_Header>();
            this.CL_Tripsheet_FuelSlip = new HashSet<CL_Tripsheet_FuelSlip>();
            this.CL_VendorBill_Header = new HashSet<CL_VendorBill_Header>();
            this.CL_Master_Location = new HashSet<CL_Master_Location>();
            this.CL_Master_Warehouse = new HashSet<CL_Master_Warehouse>();
        }
    
        public byte VendorTypeId { get; set; }
        public short VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> ContractApplicableId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Docket_BookingChallan> CL_Docket_BookingChallan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_Card> CL_Master_Card { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_Fuel_Card> CL_Master_Fuel_Card { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_CityWiseFuelRate_History> CL_Master_CityWiseFuelRate_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_CityWiseFuelRate_History> CL_Master_CityWiseFuelRate_History1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_VendorContract> CL_Master_VendorContract { get; set; }
        public virtual CL_Master_Vendor_Detail CL_Master_Vendor_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_Vendor_Gst_Detail> CL_Master_Vendor_Gst_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_Vendor_VendorService_Mapping> CL_Master_Vendor_VendorService_Mapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Prs_Header> CL_Prs_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_PurchaseOrder_Header> CL_PurchaseOrder_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Thc_Header> CL_Thc_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Tripsheet_FuelSlip> CL_Tripsheet_FuelSlip { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_VendorBill_Header> CL_VendorBill_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_Location> CL_Master_Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_Warehouse> CL_Master_Warehouse { get; set; }
    }
}