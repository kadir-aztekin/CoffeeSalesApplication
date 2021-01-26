using KAHVE_SATIS_UYGULAMASI.Abstrack;
using System;

namespace KAHVE_SATIS_UYGULAMASI.Entites
{
    public class Customer:IEntity 
    {
        public int Id { get; set; }
        public string FırstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBırth { get; set; }
        public string NatıonlıtyId { get; set; }

    }
}
