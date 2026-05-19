namespace WarehouseManagement
{
    public class StockItem(string name, string category, int quantity)
    {
        public string Name { get; set; } = name;
        public string Category { get; set; } = category;
        public int Quantity { get; set; } = quantity;

        public override string ToString()
        {
            return $"{Name} - {Quantity} шт.";
        }
    }
}
