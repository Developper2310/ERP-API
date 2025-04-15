using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KullaniciRolController:GenericController<KullaniciRol,KullaniciRolDto>
    {

        private readonly IKullaniciRolRepository _context;
        private readonly IMapper _mapper;

        public KullaniciRolController(IKullaniciRolRepository context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper
            ;
        }

        [HttpGet("kullaniciRol/{calisanID}")]

        public async Task<IActionResult> GetCalisanlarByRol(int rolid)
        {
            var calisanlar = _context.GetCalisanlarByRolAsync(rolid);
            if (calisanlar == null) return NotFound("Aradğınız Role sahip çalışan bulunamadı.");
            var dtos = _mapper.Map<KullaniciRol>(rolid);
            return Ok(dtos);
        }
    }
}
