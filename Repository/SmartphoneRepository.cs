using System.Text.Json;
using System.Text.Json.Serialization;
using ApiStoreWeb.Models;
using ApiStoreWeb.Models.Context;
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

        public void addAll(Smartphone phone)
        {
            _context.Entry(phone).State = EntityState.Added;
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Smartphone>> findAll()
        {
        
            return await _context.smartphones.ToListAsync();
            
        }
    }
}
