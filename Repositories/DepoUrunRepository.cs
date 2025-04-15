using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Repositories
{
    public class DepoUrunRepository : GenericRepository<DepoUrun>, IDepoUrunRepository
    {
        private readonly AppDbContext _context;

        public DepoUrunRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DepoUrun>> GetUrunlerByDepoIdAsync(int depoId)
        {
            return await _context.DepoUrunler
                .Where(du => du.DepoId == depoId)
                .ToListAsync();
        }

        public async Task<IEnumerable<DepoUrun>> GetDepoByUrunIdAsync(int urunId)
        {
            return await _context.DepoUrunler
                .Where(du => du.UrunID == urunId)
                .ToListAsync();
        }
    }
}
