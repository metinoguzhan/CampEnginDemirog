using System;

namespace _04_Mathematics
{
    class FourOperations
    {
        public void Addition(double number1, double number2)
        {
            double result = number1 + number2;
            Console.WriteLine("Addition Operation => {0} + {1} = {2}", number1, number2, result);
        }

        public void Subtraction(double number1, double number2)
        {
            double result = number1 - number2;
            Console.WriteLine("Subtraction Operation => {0} - {1} = {2}", number1, number2, result);
        }

        public void Multiplication(int number1, int number2)
        {
            double result = (double)(number1 * number2);
            Console.WriteLine("Multiplication Operation => {0} * {1} = {2}", number1, number2, result);
        }

        public void Division(int number1, int number2)
        {
            double result = (double)(number1 / number2);
            Console.WriteLine("Division Operation => {0} / {1} = {2}", number1, number2, result);
        }
    }
}
