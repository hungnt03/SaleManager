//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleManager.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionDetail
    {
        public string Barcode { get; set; }
        public int TracsactionId { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int SuplierId { get; set; }
        public int Quantity { get; set; }
        public bool IsPayment { get; set; }
        public decimal Amount { get; set; }
    }
}
