using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Homework
{
    class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız kayıt başarısız..");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }

        public void Delete(Gamer gmaer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
