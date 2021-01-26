using KAHVE_SATIS_UYGULAMASI.Abstrack;
using KAHVE_SATIS_UYGULAMASI.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace KAHVE_SATIS_UYGULAMASI.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference1.KPSPublicSoapClient client = new MernisServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NatıonlıtyId, customer.FırstName.ToUpper, customer.Lastname.ToUpper, customer.DateOfBırth.Year);
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
