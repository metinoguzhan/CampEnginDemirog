using System;

namespace _04_Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance -> Örnekleme
            FourOperations fourOperations = new FourOperations();
            fourOperations.Addition(12.0, 3.0);
            fourOperations.Subtraction(12.0, 3.0);
            fourOperations.Division(12, 3);
            fourOperations.Multiplication(12, 3);
        }
    }
}
