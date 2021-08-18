using System;


namespace _09_OOP3
{
    class DatabaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı..");
        }
    }
}
