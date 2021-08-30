using System;

namespace _10_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer()
            {
                Id = 1,
                BirthYear = 1986,
                IdentityNumber = 123456,
                LastName = "Demiroğ",
                FirstName = "Engin"
            });

            GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager2.Add(new Gamer()
            {
                Id = 1,
                BirthYear = 1985,
                IdentityNumber = 123456,
                LastName = "Demiroğ",
                FirstName = "Engin"
            });
        }
    }
}
