using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Repositories
{
    public class UrunRepository : GenericRepository<Urun>,IUrunRepository
    {
        private readonly AppDbContext _context;

        public UrunRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Urun>> GetUrunlerByKategoriIdAsync(int kategoriIdd)
        {
            return await _context.Urunler.Where(k => k.KategoriID == kategoriIdd).ToListAsync();
            
        }

        public async Task<IEnumerable<Urun>> GetUrunlerByMarkaAsync(int markaId)
        {
            return await _context.Urunler.Where(k => k.MarkaID == markaId).ToListAsync();
        }
    }
}
