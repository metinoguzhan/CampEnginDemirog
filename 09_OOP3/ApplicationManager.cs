using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_OOP3
{
    class ApplicationManager
    {
        //Başvuru yap metodu
        public void Apply(ICreditBaseManager creditBaseManager)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditBaseManager.Hesapla();
        }
        //Ön başvuru
        public void PreliminaryInformation(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
 