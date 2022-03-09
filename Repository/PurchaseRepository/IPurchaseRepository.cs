using ApiStoreWeb.Models;

namespace ApiStoreWeb.Repository.PurchaseRepository
{
    public interface IPurchaseRepository
    {
        Task addNewPhone(Purchase purchase);
    }
}
