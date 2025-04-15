using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;

namespace Demo1.Repositories
{
    public class RolRepository : GenericRepository<Rol>,IRolRepository
    {
        private readonly AppDbContext _context;


        public RolRepository(
            AppDbContext context) : base(context)
        {
            _context = context;

        }

    }
}
