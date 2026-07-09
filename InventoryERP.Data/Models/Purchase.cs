using System;
using System.Collections.Generic;

namespace InventoryERP.Data.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; } // Pending, Received, Cancelled
        public List<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
    }
}
