using KAHVE_SATIS_UYGULAMASI.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace KAHVE_SATIS_UYGULAMASI.Abstrack
{
    public interface IPersonCheckService
    {
        void Save(Customer customer);
        bool CheckIfRealPerson(Customer customer);
    }
}
    