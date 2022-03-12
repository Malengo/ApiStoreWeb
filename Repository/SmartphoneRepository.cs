using ApiStoreWeb.Models.Context;
using ApiStoreWeb.Models.Entites;
using Microsoft.EntityFrameworkCore;


namespace ApiStoreWeb.Repository
{
    public class SmartphoneRepository : ISmartphoneRepository
    {
        private SmartphoneContext _context;
        private DbSet<Smartphone> smartphone;


        public SmartphoneRepository(SmartphoneContext context)
        {
            _context = context;
            smartphone = _context.Set<Smartphone>();
        }

        public async Task addNewPhone(Smartphone phone)
        {
            _context.smartphones.Add(phone);
            await _context.SaveChangesAsync();

        }
        public async Task<Smartphone> findById(int id)
        {
            var phone = await _context.smartphones.FindAsync(id);
            return phone;

        }

        public async Task<IEnumerable<Smartphone>> findAll()
        {

            return await _context.smartphones.ToListAsync();

        }

        public async Task updatePhone(Smartphone phone)
        {
            _context.Update(phone);
            await _context.SaveChangesAsync();
        }

        public async Task deletePhone(Smartphone phone)
        {
            _context.smartphones.Remove(phone);
            await _context.SaveChangesAsync();
        }
    }
}
