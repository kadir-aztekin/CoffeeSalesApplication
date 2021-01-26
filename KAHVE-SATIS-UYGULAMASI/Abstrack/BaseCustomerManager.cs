using KAHVE_SATIS_UYGULAMASI.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace KAHVE_SATIS_UYGULAMASI.Abstrack
{
    public abstract class BaseCustomerManager : IPersonCheckService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("SAVE TO DB : "+customer.FırstName);
        }
    }
}
