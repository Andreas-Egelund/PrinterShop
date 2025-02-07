using PrinterShop.InterFace;
using PrinterShop.Models;

namespace PrinterShop.Data
{
    public static class MockData
    {



        static readonly Dictionary<string, IProduct> Printers2D = new Dictionary<string, IProduct>()
        {
            {"2D100",new Printer("2D100","Canon PIXMA","2d",400.00) },
            {"2D101",new Printer("2D101","OfficeJet Pro","2d",2000.00) },
            {"2D102",new Printer("2D102","HP Officejet Pro","2d",1500.00) },
            {"2D103",new Printer("2D103","Canon PIXMA PRO","2d",3500.00) },
            {"2D104",new Printer("2D104","HP LaserJet Pro","2d",1500.00) }
        };

        static readonly Dictionary<string, IProduct> Printers3D = new Dictionary<string, IProduct>()
        {
            {"3D100",new Printer("3D100","Open Box","3d",3400.00) },
            {"3D101",new Printer("3D101","Tronxy 2 Pro","3d",1600.00) },
            {"3D102",new Printer("3D102","Creality K1","3d",4250.00) },
            {"3D103",new Printer("3D103","AnkerMake M5","3d",3000.00) },
            {"3D104",new Printer("3D104","Finder 3","3d",2260.00) }
        };


        

        static readonly Dictionary<string, IProduct> Accessories = new Dictionary<string, IProduct>()
        {
            
            {"AC100",new Accessories("AC100","XL color printer ink","Accessory",369.00) },
            {"AC101",new Accessories("AC101","XL printer ink","Accessory",289.00) },
            {"AC102",new Accessories("AC102","Epson-102 4 stk","Accessory",329.00) },
            {"AC103",new Accessories("AC103","Royal filament","Accessory",85.00) },
            {"AC104",new Accessories("AC104","3D-printer værktøjssæt","Accessory",230.00) },
            {"AC105",new Accessories("AC105","3D printer engine","Accessory",150.00) },

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
