using PrinterShop.InterFace;

namespace PrinterShop.Models
{
    public class Reciept
    {


        private static int _recieptId = 0;

        public Reciept()
        {
            _recieptId++;
            RecieptId = _recieptId;
            AllItems = new List<IProduct>();
        }


        public int RecieptId { get; set; } //Ved ikke om private betyder noget her. Tester bare

        public List<IProduct> AllItems { get; set; }

        public double Total 
        { 
            get
            {
                foreach (var product in AllItems)
                {
                    Total += product.Price;
                }
                return Total;
            }
            set { Total = value; } 
        }

    }
}
