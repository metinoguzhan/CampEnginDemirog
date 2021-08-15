using System;

namespace _02_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
			Course[] courses = new Course[]
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
            foreach (Course course in courses)
            {
                Console.WriteLine("Course Informations --> {0}", count);
                Console.WriteLine(course.Instructor + " / " + course.CourseName);
                Console.WriteLine(course.ViewsRate);
                count++;
            }
		}
    }
}
