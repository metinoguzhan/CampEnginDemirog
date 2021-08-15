using System;

namespace _05_ValueTypeAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number2 = 30;
            int number3 = number2;
            number2 = 65;
            Console.WriteLine(number3 + " / " + number2);
            Console.WriteLine("\n\n");

            int[] array = new int[]
            {
                10,
                20,
                30
            };
            int[] numbers2 = new int[]
            {
                100,
                200,
                300
            };
            int[] numbers3 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine("\nNumbers Array 1 :");
            foreach (int i in numbers3)
            {
                Console.WriteLine(i);
            } 
            Console.WriteLine("\nNumbers Array 2 :");
            foreach (int j in numbers2)
            {
                Console.WriteLine(j);
            }
        }
    }
}
