using Demo1.DTOs;
using Demo1.Model;

namespace Demo1.Interfaces
{
    public interface IUrunRepository : IGenericRepository<Urun>
    {
        Task<IEnumerable<Urun>> GetUrunlerByKategoriIdAsync(int kategoriIdd);
        Task<IEnumerable<Urun>> GetUrunlerByMarkaAsync(int markaId);
    }
}
