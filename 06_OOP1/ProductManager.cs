using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP1
{
    class ProductManager
    {
        //CRUD Operations
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" added..");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated..");
        }

        
    }
}

//int, double, bool ... value type
//array, class, abstract class, interface ... reference type
//ref out 
