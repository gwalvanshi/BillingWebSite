//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingWebSite
{
    using System;
    
    public partial class GetAll_DeliveryNote_Result
    {
        public int DeliveryNoteID { get; set; }
        public Nullable<int> InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> DeliveryModeID { get; set; }
        public string DeliveryMode { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.DateTime> EstimatedDeliveryDate { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> DeliveryModeID1 { get; set; }
        public string DeliveryMode1 { get; set; }
    }
}