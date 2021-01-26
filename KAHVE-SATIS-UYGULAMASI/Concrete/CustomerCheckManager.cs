using KAHVE_SATIS_UYGULAMASI.Abstrack;
using KAHVE_SATIS_UYGULAMASI.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace KAHVE_SATIS_UYGULAMASI.Concrete
{
    public class CustomerCheckManager : IPersonCheckService1
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;       

        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
