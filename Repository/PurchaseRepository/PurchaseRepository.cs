using ApiStoreWeb.Models.Context;
using ApiStoreWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiStoreWeb.Repository.PurchaseRepository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private SmartphoneContext _context;
        private DbSet<Purchase> purchase;

        public PurchaseRepository(SmartphoneContext context)
        {
            _context = context;
            purchase = _context.Set<Purchase>();
        }


        public async Task addNewPhone(Purchase purchase)
        {
            _context.purchases.Add(purchase);
            await _context.SaveChangesAsync();

        }
    }
}
