using ApiStoreWeb.Models;
using ApiStoreWeb.Models.Entites;

namespace ApiStoreWeb.Repository.PurchaseRepository
{
    public interface IPurchaseRepository
    {
        Task addNewPurchase(Purchase purchase);
    }
}
