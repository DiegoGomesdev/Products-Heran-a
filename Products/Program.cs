using System;
using System.Collections.Generic;
using Products.Entidades;
using System.Globalization;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();
            Console.WriteLine("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'c')
                {
                    lista.Add(new Product(name, price));

                }
                else if (op == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(date, name , price ));

                }
                else
                {
                    Console.Write("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ImportedProducts(fee, name, price));
                }
            }
            Console.WriteLine(  );
            Console.WriteLine("Price Tags : ");
            foreach (Product prod in lista)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
