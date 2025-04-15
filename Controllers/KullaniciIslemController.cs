using AutoMapper;
using Demo1.Controllers;
using Demo1.DTOs;
using Demo1.DTOs.DTO_Interface;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class KullaniciIslemController : GenericController<KullaniciIslem, KullaniciIslemDto>
{
    private readonly IKullaniciIslemRepository _kullaniciIslemleriRepository;
    private readonly IMapper _mapper;

    public KullaniciIslemController(IKullaniciIslemRepository kullaniciIslemleriRepository, IMapper mapper)
        : base(kullaniciIslemleriRepository, mapper)
    {
        _kullaniciIslemleriRepository = kullaniciIslemleriRepository;
        _mapper = mapper;
    }

    // çalışana ait işlemler
    [HttpGet("calisanIslem/{calisanID}")]
    public async Task<IActionResult> GetByCalisan(int calisanID)
    {
        var islemler = _kullaniciIslemleriRepository.GetKullaniciIslemByCalisanAsync(calisanID);
        if (islemler == null ) return NotFound("Çalışana ait işlem bulunamadı");
        var dtos = _mapper.Map<KullaniciIslem>(islemler);
        return Ok(dtos);//heyyy
    }
}