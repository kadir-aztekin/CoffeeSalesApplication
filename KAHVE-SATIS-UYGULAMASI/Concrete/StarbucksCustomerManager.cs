using KAHVE_SATIS_UYGULAMASI.Abstrack;
using KAHVE_SATIS_UYGULAMASI.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace KAHVE_SATIS_UYGULAMASI.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private IPersonCheckService personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            this.personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                new Exception("NOT A VALİD  PERSON ");
            }
            
            
        }

       
    }
}
