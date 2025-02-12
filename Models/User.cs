using PrinterShop.InterFace;

namespace PrinterShop.Models
{
    public class User
    {

        public User()
        {
            ShoppingCart = new List<IProduct>();
            Receipts = new List<List<IProduct>>();
        }


        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            ShoppingCart = new List<IProduct>();
            Receipts = new List<List<IProduct>>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<IProduct> ShoppingCart { get; set; }
        public List<List<IProduct>> Receipts { get; set; }






    }
}
