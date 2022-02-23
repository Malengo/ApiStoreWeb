using ApiStoreWeb.Models;

namespace ApiStoreWeb.Repository
{
    public interface ISmartphoneRepository
    {
         void addAll(Smartphone phone);
        Task<IEnumerable<Smartphone>> findAll();
    }
}
