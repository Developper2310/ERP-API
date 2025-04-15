using Demo1.Data;
using Demo1.Interfaces;

using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Demo1.DTOs;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Repositories
{
    public interface ICalisanRepository : IGenericRepository<Calisan>
    {
        // DTO metodları ekleyin
        Task<IActionResult> ToplamMaas();
        Task<List<Calisan>> GetCalisanlarByDepartmanDtoAsync(int depID);

        Task<List<Yetki>> GetCalisanYetkileriDtoAsync(int calisanID);
        Task<List<AlimSatim>> GetCalisanAlimSatimDtoAsync(int calisanID);
        Task<List<KullaniciIslem>> GetCalisanIslemlerDtoAsync(int calisanID);
    }
}