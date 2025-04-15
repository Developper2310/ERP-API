using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;

namespace Demo1.Repositories
{
    public class KategoriRepository : GenericRepository<Kategori>, IKategoriRepository
    {
        public KategoriRepository(AppDbContext context) : base(context)
        {
        }
    
    }
}
