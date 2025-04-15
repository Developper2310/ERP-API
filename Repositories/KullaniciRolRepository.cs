using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Repositories
{
    public class KullaniciRolRepository: GenericRepository<KullaniciRol>,IKullaniciRolRepository

    {
        private readonly AppDbContext _context;
        public KullaniciRolRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<KullaniciRol>> GetCalisanlarByRolAsync(int rolid)
        {
            return await _context.KullaniciRoller.Where(a => a.RolID == rolid).ToListAsync();
        }
    }
}
