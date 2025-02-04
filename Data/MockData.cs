using PrinterShop.Models;

namespace PrinterShop.Data
{
    public static class MockData
    {



        static readonly Dictionary<string, Printer> Printers = new Dictionary<string, Printer>()
        {
            {"HP100",new Printer("HP100","",3000.00) },
            {"HP200",new Printer("HP200","",3000.00) },
            {"HP300",new Printer("HP300","",3000.00) },
            {"HP400",new Printer("HP400","",3000.00) },
            {"HP500",new Printer("HP500","",3000.00) },
            {"HP600",new Printer("HP600","",3000.00) },
            {"HP700",new Printer("HP700","",3000.00) },

        };




        public static Dictionary<string,Printer> GetPrinters()
        {
            return Printers;
        }   















    }
}
