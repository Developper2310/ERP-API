using AutoMapper;
using Demo1.Data;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;

namespace Demo1.Repositories
{
    public class DepartmanRepository :GenericRepository< Departman>,IDepartmanRepository
    {
        private readonly AppDbContext _contx;

        public DepartmanRepository(AppDbContext contx):base(contx)
        {
            _contx = contx;
    
        }



    }
}
