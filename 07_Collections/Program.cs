using System;
using System.Collections.Generic;

namespace _07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Example01();
            Example02();
            MyList<string> names = new MyList<string>();
            names.Add("Metin");
            names.Add("Oğuzhan");
            names.Add("Emre");
            names.Add("Yaşar");

            foreach (var VARIABLE in names.Items)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine(names.Lenght);
        }
        private static void Example01()
        {
            string[] names = new[] { "Engin", "Murat", "Kerem", "Halil" };
            //Index was outside the bounds of the array
            //names[4] = "İlker";
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            // Console.WriteLine(names[4]);
        }

        private static void Example02()
        {
            List<string> names = new List<string>() {"Engin", "Murat", "Kerem", "Aydın"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names.Add("İlker");
            Console.WriteLine(names[4]);
            names.ForEach(e => Console.WriteLine(e));
        }

        
    }
}
