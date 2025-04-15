using Demo1.Model;

namespace Demo1.Interfaces
{
    public interface IKullaniciRolRepository:IGenericRepository<KullaniciRol>
    {
         Task<IEnumerable<KullaniciRol>> GetCalisanlarByRolAsync(int rolid);
    }
}
