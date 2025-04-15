using Demo1.Data;
using Demo1.Interfaces;
using Demo1.Model;

namespace Demo1.Repositories
{
    public class YetkiRepository:GenericRepository<Yetki>,IYetkiRepository
    {
        private readonly AppDbContext _ass;
        public YetkiRepository(AppDbContext ass) : base(ass)
        {
            _ass = ass;
        }
    }
}
