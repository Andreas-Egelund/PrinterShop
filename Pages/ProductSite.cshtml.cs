using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrinterShop.InterFace;

namespace PrinterShop.Pages
{
    public class ProductSiteModel : PageModel
    {
        public static List<IProduct> Products = new List<IProduct>();
        public List<IProduct> TheProducts = Products;


        public void OnGet()
        {

        }
        public void OnPostRemoveProduct(string id)
        {
            var product = TheProducts.Find(p => p.ProductId == id);

            if (TheProducts.Contains(product))
            {
                TheProducts.Remove(product);
            }

        }

        public static void AddingProducts(IProduct product)
        {
            if (product != null)
            {
                Products.Add(product);
            }

        }
    }
}

