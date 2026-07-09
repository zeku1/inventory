namespace InventoryERP.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Unit { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int CurrentStock { get; set; }
        public int ReorderLevel { get; set; }
        public bool Status { get; set; }
    }
}
