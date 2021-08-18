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
        //Method injection
        public void Apply(ICreditBaseManager creditBaseManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditBaseManager.Hesapla();
            loggerService.Log();
        }
        //Ön başvuru
        public void PreliminaryInformation(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }

        public void Apply2(ICreditBaseManager creditBaseManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditBaseManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
    }
}
 