using AutoMapper;
using Demo1.Data;
using Demo1.DTOs.DTO_Interface;
using Microsoft.EntityFrameworkCore;

public class GenericRepository< T> : IGenericRepository<T> where T : class

{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;



    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();

    }



    public async Task<T> GetByIdAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var entities = await _dbSet.ToListAsync();
        return entities;
    }

    public async Task AddAsync(T t)
    {
        var entity = t;

        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();

        //güncelle
        //_mapper.Map(entity, t);
    }

    public async Task UpdateAsync(T t)//böyle daha uygun int KULLANMA
    {

        try
        {
            var entity = t;


            //BU KISIMDA KAYITIN OLUP OLMADIĞI KONTROL EDİLEBİLİR
           // var varMi = await _dbSet.FindAsync(GetEntityId(entity));
           //gerek yok


            if (entity != null)
            {
                
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            } 
        }
        catch(Exception e)
        {

        }
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }


    //üzerine düşün
    //rafta
   


}














//public async Task<T> AddDtoAsync<TDto>(TDto dto) where TDto : class, IDto
//{
//    var entity = _mapper.Map<T>(dto);


//    await _dbSet.AddAsync(entity);
//    await _context.SaveChangesAsync();

//    return entity;
//}

////değiştir
//public async Task<T> UpdateDtoAsync<TDto>(TDto dto) where TDto : class, IDto
//{
//    var entity = await _dbSet.FindAsync(dto.id);

//    if (entity == null)
//    {
//        throw new KeyNotFoundException($"{id} ID numaralı kyayıt bulaunamadı.");
//    }


//    await _context.SaveChangesAsync();
//}

////  silme
//public async Task DeleteDtoAsync<TDto>(int id) where TDto : class, IDto
//{

//    try
//    {
//        var entity = await _dbSet.FindAsync(id);

//        if (entity == null)
//        {
//            throw new KeyNotFoundException($"{id} ID numaralı kyayıt bulaunamadı.");
//        }

//        _dbSet.Remove(entity);
//        await _context.SaveChangesAsync();
//    }
//    catch (Exception ex)
//    {

//    }

//}

//public async Task<IEnumerable<TDto>> GetAllDtoAsync<TDto>() where TDto : class, IDto
//{
//    var entities = await _dbSet.ToListAsync();
//    return _mapper.Map<IEnumerable<TDto>>(entities);
//}

//public async Task<TDto> GetByIdDtoAsync(int id)
//{
//    var entity = await _dbSet.FindAsync(id);
//    return entity != null ? _mapper.Map<TDto>(entity) : null;
//}