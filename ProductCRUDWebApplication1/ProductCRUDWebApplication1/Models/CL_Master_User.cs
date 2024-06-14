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
    
    public partial class CL_Master_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CL_Master_User()
        {
            this.CL_Adjustment_Header = new HashSet<CL_Adjustment_Header>();
            this.CL_CustomerBill_Header = new HashSet<CL_CustomerBill_Header>();
            this.CL_CustomerBill_Header1 = new HashSet<CL_CustomerBill_Header>();
            this.CL_Drs_Header = new HashSet<CL_Drs_Header>();
            this.CL_FastTag_Transaction = new HashSet<CL_FastTag_Transaction>();
            this.CL_FuelRequest = new HashSet<CL_FuelRequest>();
            this.CL_Master_AutoMailService_History = new HashSet<CL_Master_AutoMailService_History>();
            this.CL_Master_AutoMailService_History1 = new HashSet<CL_Master_AutoMailService_History>();
            this.CL_Master_CityWiseFuelRate_History = new HashSet<CL_Master_CityWiseFuelRate_History>();
            this.CL_Master_CityWiseFuelRate_History1 = new HashSet<CL_Master_CityWiseFuelRate_History>();
            this.CL_StandardRouteCharge_Enroute_Expense_History = new HashSet<CL_StandardRouteCharge_Enroute_Expense_History>();
            this.CL_Master_User_Company_Mapping = new HashSet<CL_Master_User_Company_Mapping>();
            this.CL_Master_User1 = new HashSet<CL_Master_User>();
            this.CL_Master_User_Warehouse_Mapping = new HashSet<CL_Master_User_Warehouse_Mapping>();
            this.CL_Prs_Header = new HashSet<CL_Prs_Header>();
            this.CL_Thc_Summary = new HashSet<CL_Thc_Summary>();
        }
    
        public short UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<short> LocationId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public bool Gender { get; set; }
        public System.DateTime DoB { get; set; }
        public System.DateTime DoJ { get; set; }
        public string Address { get; set; }
        public bool UserStatusId { get; set; }
        public Nullable<byte> UserTypeId { get; set; }
        public Nullable<short> ManagerId { get; set; }
        public string Photo { get; set; }
        public bool IsActive { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<short> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<byte> DefaultCompanyId { get; set; }
        public Nullable<short> DefaultWarehouseId { get; set; }
        public byte RoleId { get; set; }
        public short UserTypeMapId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Adjustment_Header> CL_Adjustment_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CustomerBill_Header> CL_CustomerBill_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_CustomerBill_Header> CL_CustomerBill_Header1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Drs_Header> CL_Drs_Header { get; set; }
        public virtual CL_Master_Location CL_Master_Location { get; set; }
        public virtual CL_Master_Role CL_Master_Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_FastTag_Transaction> CL_FastTag_Transaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_FuelRequest> CL_FuelRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_AutoMailService_History> CL_Master_AutoMailService_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_AutoMailService_History> CL_Master_AutoMailService_History1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_CityWiseFuelRate_History> CL_Master_CityWiseFuelRate_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_CityWiseFuelRate_History> CL_Master_CityWiseFuelRate_History1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_StandardRouteCharge_Enroute_Expense_History> CL_StandardRouteCharge_Enroute_Expense_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_User_Company_Mapping> CL_Master_User_Company_Mapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_User> CL_Master_User1 { get; set; }
        public virtual CL_Master_User CL_Master_User2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Master_User_Warehouse_Mapping> CL_Master_User_Warehouse_Mapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Prs_Header> CL_Prs_Header { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CL_Thc_Summary> CL_Thc_Summary { get; set; }
    }
}