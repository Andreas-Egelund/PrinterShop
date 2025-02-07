using PrinterShop.InterFace;

namespace PrinterShop.Models
{
    public class Accessories:IProduct
    {


        public Accessories(string productId, string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            ProductId = productId;

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }


    }
}
