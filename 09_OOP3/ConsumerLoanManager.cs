using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_OOP3
{
    //İhtiyaç Kredisi
    class ConsumerLoanManager : ICreditBaseManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
