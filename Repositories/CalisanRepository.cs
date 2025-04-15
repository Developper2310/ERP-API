using AutoMapper;
using Demo1.Data;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Demo1.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

public class CalisanRepository : GenericRepository<Calisan>, ICalisanRepository
{
    private readonly AppDbContext _context;


    public CalisanRepository(
        AppDbContext context) : base(context)
    {
        _context = context;
        
    }
    public async Task<List<Calisan>> GetCalisanlarByDepartmanDtoAsync(int depID)
    {
        var calisanlar = await _context.Calisanlar
            .Where(a => a.DepartmanID == depID)
            .ToListAsync();

        return calisanlar;
    }


  


    public async Task<List<Yetki>> GetCalisanYetkileriDtoAsync(int calisanID)
    {
        var yetkiler = await _context.KullaniciRoller
            .Where(kr => kr.CalisanID == calisanID)
            .Include(kr => kr.Rol)
            .ThenInclude(r => r.RolYetkileri)
            .ThenInclude(ry => ry.Yetki)
            .SelectMany(kr => kr.Rol.RolYetkileri.Select(ry => ry.Yetki))
            .Distinct()
            .ToListAsync();

        return yetkiler;
    }

    //AlimSatim Kısımları <<<<-------------------------------------------------------------------------------------
    public async Task<List<AlimSatim>> GetCalisanAlimSatimDtoAsync(int calisanID)
    {
        var alimSatimlar = await _context.AlimSatimlar
            .Where(a => a.CalisanID == calisanID)
            .ToListAsync();

        return alimSatimlar;
    }

    public async Task<List<KullaniciIslem>> GetCalisanIslemlerDtoAsync(int calisanID)
    {
        var islemler = await _context.KullaniciIslemler
            .Where(i => i.CalisanID == calisanID)
            .ToListAsync();

        return islemler;
    }


    //daha sonrası için
    public Task<IActionResult> ToplamMaas()
    {
        throw new NotImplementedException();
    }




    //Maas özelliğini tanımlamayı unutmuşum--------------------

    //public async Task<IActionResult> ToplamMaas()
    //{
    //    return _context.Set<Calisan>().Sum(c => c.Maas);
    //}
}
