using System;
using System.Collections.Generic;

namespace InventoryERP.Data.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Total { get; set; }
        public decimal Payment { get; set; }
        public decimal Change { get; set; }
        public List<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
    }
}
