using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(3.5, "chifla", new DateTime(2022,01,04), "panifcom", Categories.Bread);
            product.ExpirationDate(product);
            Console.WriteLine(product.ExpirationDate(product));
            


        }
    }
}


