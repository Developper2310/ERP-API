using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;

namespace Demo1.Repositories
{
    public class IslemRepository : GenericRepository<Islem>,IIslemRepository
    {
        private readonly AppDbContext _context;

        public IslemRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
