using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;

namespace Demo1.Repositories
{
    public class DepoRepository : GenericRepository<Depo>,IDepoRepository

    {
        private readonly AppDbContext _ass;
        public DepoRepository(AppDbContext ass) : base(ass)
        {
            _ass = ass;
        }
    }
}
