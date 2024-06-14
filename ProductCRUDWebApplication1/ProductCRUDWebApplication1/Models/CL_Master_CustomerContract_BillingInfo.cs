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
    
    public partial class CL_Master_CustomerContract_BillingInfo
    {
        public short ContractId { get; set; }
        public byte BillLocationRule { get; set; }
        public Nullable<short> BillGenerationLocationId { get; set; }
        public short BillSubmissionLocationId { get; set; }
        public short BillCollectionLocationId { get; set; }
        public byte CreditDays { get; set; }
        public decimal CreditLimit { get; set; }
        public bool UseCommunicationAddressAsBillingAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public short CityId { get; set; }
        public string Pincode { get; set; }
        public string MobileNo { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BankAccountNo { get; set; }
        public decimal TurnOver { get; set; }
        public short EntryBy { get; set; }
        public System.DateTime EntryDate { get; set; }
    
        public virtual CL_Master_CustomerContract CL_Master_CustomerContract { get; set; }
        public virtual CL_Master_Location CL_Master_Location { get; set; }
        public virtual CL_Master_Location CL_Master_Location1 { get; set; }
        public virtual CL_Master_Location CL_Master_Location2 { get; set; }
    }
}
