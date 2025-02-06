using PrinterShop.InterFace;

namespace PrinterShop.Models
{
    public class Accessories:IProduct
    {


        public Accessories(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


    }
}
