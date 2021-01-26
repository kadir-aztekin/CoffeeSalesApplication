using KAHVE_SATIS_UYGULAMASI.Entites;

namespace KAHVE_SATIS_UYGULAMASI.Abstrack
{
    public interface IPersonCheckService1
    {
        bool CheckIfRealPerson(Customer customer);
        void Save(Customer customer);
    }
}