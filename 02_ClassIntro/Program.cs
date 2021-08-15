using System;

namespace _02_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
			Course[] Courselar = new Course[]
            {
                new Course
                {
                    Instructor = "Engin Demiroğ",
                    CourseName = "C#",
                    ViewsRate = 68
                },
                new Course
                {
                    Instructor = "Kerem Varış",
                    CourseName = "Java",
                    ViewsRate = 46
                },
                new Course
                {
                    Instructor = "Berkay Bilgin",
                    CourseName = "Python",
                    ViewsRate = 90
                }
            };
            int count = 1;
            foreach (Course Course in Courselar)
            {
                Console.WriteLine("Course Informations --> {0}", count);
                Console.WriteLine(Course.Instructor + " / " + Course.CourseName);
                Console.WriteLine(Course.ViewsRate);
                count++;
            }
		}
    }
}
