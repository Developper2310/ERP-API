using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Repositories
{
    public class KullaniciIslemRepository : GenericRepository<KullaniciIslem>, IKullaniciIslemRepository
    {
        private readonly AppDbContext _context;
        public KullaniciIslemRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }



        public async Task<IEnumerable<Islem>> GetKullaniciIslemByCalisanAsync(int id)
        {
            return await _context.Islemler.Where(a => a.Id == id).ToListAsync();
            
        }
    }
}