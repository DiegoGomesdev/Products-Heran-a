using System;
using System.Globalization;
namespace Products.Entidades
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(DateTime manufacturedate, string name, double price) : base (name, price)
        {
            manufactureDate = manufacturedate;
        }

       

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + manufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }


    }
}
