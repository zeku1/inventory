using System.Collections.Generic;
using InventoryERP.Data.Models;

namespace InventoryERP.Web.Models
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalPurchases { get; set; }
        public int LowStockAlertCount { get; set; }
        public List<Product> LowStockProducts { get; set; } = new List<Product>();
    }
}
