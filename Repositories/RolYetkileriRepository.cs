using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Repositories
{
    public class RolYetkileriRepository:GenericRepository<RolYetki>,IRolYetkileriRepository
    {

        private readonly AppDbContext _context;


        public RolYetkileriRepository(
            AppDbContext context) : base(context)
        {
            _context = context;

        }

        public async Task<IEnumerable<RolYetki>> GetRolYetkileriAsync(int rolid)
        {
            return await _context.RolYetkileri.Where(a => a.RolID==rolid).ToListAsync();
        }
    }
}
