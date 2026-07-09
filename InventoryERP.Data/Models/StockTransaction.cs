using System;

namespace InventoryERP.Data.Models
{
    public class StockTransaction
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public string TransactionType { get; set; } // In, Out
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Reason { get; set; } // Purchase, Sale, Damaged, Expired, Adjustment
        public string ReferenceNumber { get; set; }
    }
}
