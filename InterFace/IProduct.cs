namespace PrinterShop.InterFace
{
    public interface IProduct
    {
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }

    }
}
