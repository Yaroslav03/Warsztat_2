namespace Warsztat_2.Models
{
    public class WarehouseModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte Quantity { get; set; }
        public string Sum { get; set; }

        public void Clear()
        {
            Id = 0;
            Type = null;
            Name = null;
            PartNumber = null;
            Description = null;
            Price = 0;
            Quantity = 0;
            Sum = null;
        }
    }
}
