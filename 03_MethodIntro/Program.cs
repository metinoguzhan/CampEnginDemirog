using System;

namespace _03_MethodIntro
{
    class Program
    {
        static void Main(string[] args)
        {
			Product product = new Product();
            product.Name = "Apple";
            product.Price = 15.0;
            product.Description = "amasya apple is famous fruit in the world";
            product.StockQty = 99;
            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 15.0;
            product2.Description = "diyarbakır Watermelon is famous fruit in the world";
            product2.StockQty = 98;
            Product[] products = new Product[]
            {
                product,
                product2
            };
            foreach (Product product3 in products)
            {
                Console.WriteLine(product3.Name);
                Console.WriteLine(product3.Price);
                Console.WriteLine(product3.Description);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("<-------------Methods------------->");
            CartManager cartManager = new CartManager();
            cartManager.Add(product);
            cartManager.Add(product2);

            //misuse -> Hatalı kullanım
            cartManager.Add2("Armut", "Yeşil Armut", 12.0, 10);
            cartManager.Add2("Elma", "Yeşil Elma", 13.0, 9);
            cartManager.Add2("Karpuz", "Diyarbakır Karpuzu", 14.0, 8);
		}
    }
}
