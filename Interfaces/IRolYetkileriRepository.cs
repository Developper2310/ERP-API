using Demo1.Model;

namespace Demo1.Interfaces
{
    public interface IRolYetkileriRepository:IGenericRepository<RolYetki>
    {
        Task<IEnumerable<RolYetki>> GetRolYetkileriAsync(int rolid);
    }
}
