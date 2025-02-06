using PrinterShop.InterFace;
using PrinterShop.Models;

namespace PrinterShop.Data
{
    public static class MockData
    {



        static readonly Dictionary<string, IProduct> Printers2D = new Dictionary<string, IProduct>()
        {
            {"HP1010",new Printer("HP1010","2d",3000.00) },
            {"HP2020",new Printer("HP2020","2d",3000.00) },
            {"HP3030",new Printer("HP3030","2d",3000.00) },
            {"HP4040",new Printer("HP4040","2d",3000.00) },
            {"HP5050",new Printer("HP5050","2d",3000.00) }
        };

        static readonly Dictionary<string, IProduct> Printers3D = new Dictionary<string, IProduct>()
        {
            {"HP100",new Printer("HP100","3d",3000.00) },
            {"HP200",new Printer("HP200","3d",3000.00) },
            {"HP300",new Printer("HP300","3d",3000.00) },
            {"HP400",new Printer("HP400","3d",3000.00) },
            {"HP500",new Printer("HP500","3d",3000.00) }
        };


        

        static readonly Dictionary<string, IProduct> Accessories = new Dictionary<string, IProduct>()
        {
            {"HP101",new Accessories("HP101","Accessory",3000.00) },
            {"HP201",new Accessories("HP201","Accessory",3000.00) },
            {"HP301",new Accessories("HP301","Accessory",3000.00) },
            {"HP401",new Accessories("HP401","Accessory",3000.00) },
            {"HP501",new Accessories("HP501","Accessory",3000.00) },
            {"HP601",new Accessories("HP601","Accessory",3000.00) },

        };



        public static Dictionary<string, IProduct> Get2DPrinters()
        {
            return Printers2D;
        }

        public static Dictionary<string, IProduct> Get3DPrinters()
        {
            return Printers3D;
        }

        public static Dictionary<string, IProduct> GetAccessories()
        {
            return Accessories;
        }











    }
}
