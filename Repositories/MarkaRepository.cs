using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;

namespace Demo1.Repositories
{
    public class MarkaRepository : GenericRepository<Marka>, IMarkaRepository
    {
        public MarkaRepository(AppDbContext context) : base(context)
        {
        }
    
    }
}
