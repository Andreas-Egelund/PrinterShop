﻿using PrinterShop.InterFace;

namespace PrinterShop.Models
{
    public class User
    {

        public User()
        {
            ShoppingCart = new List<IProduct>();
            Receipts = new List<Reciept>();
        }


        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            ShoppingCart = new List<IProduct>();
            Receipts = new List<Reciept>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<IProduct> ShoppingCart { get; set; }
        public List<Reciept> Receipts { get; set; }






    }
}
