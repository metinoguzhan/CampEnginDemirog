using System;

namespace _08_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual()
            {
                Id = 1,
                CustomerNumber = "12345",
                Name = "Engin",
                Surname = "Demiroğ",
                IdentityNumber = "22222222222"
            };

            Coorporate customer2 = new Coorporate()
            {
                Id = 2,
                CustomerNumber = "12346",
                CompanyName = "Kodlama.io",
                TaxNumber = "1234567890"
            };

            //Individual Customer - Coorporate Customer
            //SOLID
            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
