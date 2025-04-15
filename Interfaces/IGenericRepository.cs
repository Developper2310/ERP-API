public interface IGenericRepository<T> 
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T dto);
    Task UpdateAsync(T dto);
    Task DeleteAsync(int id);

}