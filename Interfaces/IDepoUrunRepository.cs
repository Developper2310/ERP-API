using Demo1.DTOs;
using Demo1.Model;

namespace Demo1.Interfaces
{
    public interface IDepoUrunRepository : IGenericRepository<DepoUrun>
    {
        Task<IEnumerable<DepoUrun>> GetUrunlerByDepoIdAsync(int depoId);
        Task<IEnumerable<DepoUrun>> GetDepoByUrunIdAsync(int urunId);
    }
}
