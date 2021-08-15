using System;

namespace _01_KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Example01();
            Example02();
            Example03();
            Example04();
        }

        private static void Example01()
        {
            string categoryLabel = "Kategoriler";
            bool isLogin = true;
            bool result = isLogin;
            if (result)
            {
                Console.WriteLine("User setting button");
            }
            else
            {
                Console.WriteLine("Welcome, please login");
            }
            Console.WriteLine(categoryLabel);
            Console.WriteLine(categoryLabel);
            Console.WriteLine(categoryLabel);
            Console.WriteLine(categoryLabel);
        }

        private static void Example02()
        {
            double usdYesterday = 7.65;
            double usdToday = 7.45;
            bool result = usdYesterday > usdToday;
            if (result)
            {
                Console.WriteLine("decrease button");
            }
            else
            {
                bool result2 = usdYesterday < usdToday;
                if (result2)
                {
                    Console.WriteLine("increase button");
                }
                else
                {
                    Console.WriteLine("not changed button");
                }
            }
        }

        private static void Example03()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i : " + i);
            }
            Console.WriteLine("///++");
            for (int j = 0; j <= 10; j += 2)
            {
                Console.WriteLine("i : " + j);
            }
        }

        private static void Example04()
        {
            string[] courses = new string[]
            {
                "software development camp",
                "basic programming course for beginners",
                "Java",
                "Python"
            };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("///++");
            Console.WriteLine("last page - Footer");
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("///++");
            Console.WriteLine("last page - Footer");
        }
    }
}

