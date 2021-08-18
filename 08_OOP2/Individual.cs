using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOP2
{
    //Gerçek Müşteri
    class Individual : Customer
    {
      
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
    }
}
