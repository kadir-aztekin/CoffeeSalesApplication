using KAHVE_SATIS_UYGULAMASI.Abstrack;
using KAHVE_SATIS_UYGULAMASI.Concrete;
using KAHVE_SATIS_UYGULAMASI.Entites;
using System;

namespace KAHVE_SATIS_UYGULAMASI
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();

var customerManager1 = customerManager;
            customerManager1.Save(new Customer { DateOfBırth = new DateTime(1985, 1, 6), FırstName = "KADİR", Lastname = "AZTEKİN", NatıonlıtyId = "40117777785" });

        }
    }
}
 