using Microsoft.AspNetCore.Identity;
using PrinterShop.Data;
using PrinterShop.InterFace;
using PrinterShop.Models;

namespace PrinterShop.Services
{
    public class PrinterService
    {

        private Dictionary<string, IProduct> _printers2D;

        private Dictionary<string, IProduct> _printers3D;

        private Dictionary<string, IProduct> _accessories;

        private Dictionary<string, User> _users;



        public PrinterService()
        {
            _printers2D = MockData.Get2DPrinters();
            _printers3D = MockData.Get3DPrinters();
            _accessories = MockData.GetAccessories();
            _users = MockData.GetUsers();
        }


        public Dictionary<string, IProduct> Get2DPrinters() => _printers2D;

        public Dictionary<string, IProduct> Get3DPrinters() => _printers3D;

        public Dictionary<string, IProduct> GetAccessories() => _accessories;

        public Dictionary<string, User> GetUsers() => _users;


    }
}
