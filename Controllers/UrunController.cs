using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrunController : GenericController<Urun, UrunDto>
    {

        private readonly IUrunRepository _urunr;
        private readonly IMapper _mapper;
        public UrunController(IUrunRepository urunr,IMapper mapper) : base(urunr,mapper)
        {
            _urunr = urunr;
            _mapper = mapper;

        }
        [HttpGet("{kategoriId}")]
        public async Task<ActionResult> GetUrunlerByKategori(int kategoriId)
        {
            var urunler = _urunr.GetUrunlerByKategoriIdAsync(kategoriId);
            //buraya katagorinin var olup olmadığının kontrolü yapılabilir
            if (urunler == null) return NotFound("Aradığınız katagoride bir ürün bulunamadı");
            var dtos = _mapper.Map<Urun>(urunler);
            return Ok(urunler);
        }
        [HttpGet("{markaId}")]
        public async Task<ActionResult> GetUrunlerByMarka(int kategoriId)
        {
            var urunler = _urunr.GetUrunlerByMarkaAsync(kategoriId);

            if (urunler == null) return NotFound("Aradığınız markaya sahip bir ürün bulunamadı");
            var dtos = _mapper.Map<Urun>(urunler);
            return Ok(urunler);
        }


    }

}