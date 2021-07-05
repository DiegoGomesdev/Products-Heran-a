using System.Globalization;
namespace Products.Entidades
{
    class ImportedProducts : Product
    {
        public double customsFee { get; set; }

        public ImportedProducts()
        {

        }
        public ImportedProducts(double customsfee, string name, double price) : base (name, price)
        {
            customsFee = customsfee;
        }

      
        public double totalPrice()
        {
            return Price + customsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " Customs fee: $ "
                + customsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}
