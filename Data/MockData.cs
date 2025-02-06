using PrinterShop.Models;

namespace PrinterShop.Data
{
    public static class MockData
    {



        static readonly Dictionary<string, Printer> Printers2D = new Dictionary<string, Printer>()
        {
            {"HP100",new Printer("HP100","2d",3000.00) },
            {"HP200",new Printer("HP200","2d",3000.00) },
            {"HP300",new Printer("HP300","2d",3000.00) },
            {"HP400",new Printer("HP400","2d",3000.00) },
            {"HP500",new Printer("HP500","2d",3000.00) }
        };

        static readonly Dictionary<string, Printer> Printers3D = new Dictionary<string, Printer>()
        {
            {"HP100",new Printer("HP100","3d",3000.00) },
            {"HP200",new Printer("HP200","3d",3000.00) },
            {"HP300",new Printer("HP300","3d",3000.00) },
            {"HP400",new Printer("HP400","3d",3000.00) },
            {"HP500",new Printer("HP500","3d",3000.00) }
        };


        static readonly Dictionary<string, Accessories> Accessories = new Dictionary<string, Accessories>()
        {
            {"HP101",new Accessories("HP100","Accessory",3000.00) },
            {"HP201",new Accessories("HP100","Accessory",3000.00) },
            {"HP301",new Accessories("HP100","Accessory",3000.00) },
            {"HP401",new Accessories("HP100","Accessory",3000.00) },
            {"HP501",new Accessories("HP100","Accessory",3000.00) },
            {"HP601",new Accessories("HP100","Accessory",3000.00) },

        };



        public static Dictionary<string,Printer> Get2DPrinters()
        {
            return Printers2D;
        }

        public static Dictionary<string, Printer> Get3DPrinters()
        {
            return Printers3D;
        }

        public static Dictionary<string, Accessories> GetAccessories()
        {
            return Accessories;
        }











    }
}
