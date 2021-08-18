using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_OOP3
{
    //Ev Kredisi
    class HouseLeonManager:ICreditBaseManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Ev kredisi ödeme planı hesaplandı");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
