using System;

namespace _09_OOP3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms olarak loglandı..");
        }
    }
}