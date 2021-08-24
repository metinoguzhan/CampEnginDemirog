using System;
using System.Collections.Generic;

namespace _09_OOP3
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
            ICreditBaseManager houseLeonManager = new HouseLeonManager();
            houseLeonManager.Hesapla();

            ICreditBaseManager vehicleLoanManager = new VehicleLoanManager();
            vehicleLoanManager.Hesapla();

            ICreditBaseManager consumerLoanManager = new ConsumerLoanManager();
            consumerLoanManager.Hesapla();
        }
        private static void Example02()
        {
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(new VehicleLoanManager(),new DatabaseLoggerService());
        }
        private static void Example03()
        {
            ApplicationManager applicationManager = new ApplicationManager();
            List<ICreditBaseManager> credits = new List<ICreditBaseManager>()
            {
                new VehicleLoanManager(), new HouseLeonManager(), new ConsumerLoanManager()
            };
            applicationManager.PreliminaryInformation(credits);
        }
        private static void Example04()
        {
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply2(new BusinessLeonManager(), new List<ILoggerService>(){new DatabaseLoggerService(),new FileLoggerService(),new SmsLoggerService()});
        }
    }
}
