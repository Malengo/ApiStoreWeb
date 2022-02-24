using ApiStoreWeb.Models;

namespace ApiStoreWeb.Repository
{
    public interface ISmartphoneRepository
    {
        Task addNewPhone(Smartphone phone);
        Task<Smartphone> findById(int id);
        Task<IEnumerable<Smartphone>> findAll();
        Task updatePhone(Smartphone phone);
        Task deletePhone(Smartphone phone);
    }
}
