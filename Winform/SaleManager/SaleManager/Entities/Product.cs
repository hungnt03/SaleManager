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
    
    public partial class Product
    {
        public string Barcode { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public Nullable<bool> Pin { get; set; }
        public bool Enable { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public int Unit { get; set; }
        public string Img { get; set; }
        public Nullable<int> PriceBuy { get; set; }
        public Nullable<int> Interest { get; set; }
        public Nullable<bool> IsDefault { get; set; }
    }
}
