using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MethodIntro
{
    class CartManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations. Added to cart : " + product.Name);
        }

        public void Add2(string name, string description, double price, int stockQty)
        {
            Console.WriteLine("Congratulations. Added to cart : " + name);
        }
    }
}
