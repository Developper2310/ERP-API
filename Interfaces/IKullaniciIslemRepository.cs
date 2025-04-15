using Demo1.Model;

namespace Demo1.Interfaces
{
    public interface IKullaniciIslemRepository:IGenericRepository<KullaniciIslem>
    {
        Task<IEnumerable<Islem>> GetKullaniciIslemByCalisanAsync(int id);
    }
}
