using Demo1.DTOs;
using Demo1.Model;
using System.Threading.Tasks;

namespace Demo1.Interfaces
{
    public interface IAlimSatimRepository : IGenericRepository<AlimSatim>
    {

        Task<List<AlimSatim>> GetFisDestekByAlimSatimlarAsync(int asid);
        Task<List<UrunAdetDto>> GetByDepoAsync(int depoid);
    }
}
