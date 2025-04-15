using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepoUrunController : GenericController<DepoUrun,DepoUrunDto>
    {
        private readonly IDepoUrunRepository _depoUrun;
        private readonly IMapper _mapper;

        public DepoUrunController(IDepoUrunRepository depoUrun,IMapper mapper):base(depoUrun, mapper)
        {
            _depoUrun = depoUrun;
            _mapper = mapper;
        }

        [HttpGet("{depoId}")]
        public async Task<IActionResult> GetUrunlerByDepo(int depoId)
        {
            var urunler = await _depoUrun.GetUrunlerByDepoIdAsync(depoId);//dikkat işlem repoya yönlendrilecek

            if (urunler == null || !urunler.Any())
                return NotFound("Bu depoya ait ürün bulunamadı.");

            return Ok(urunler);
        }

        [HttpGet("{urunId}")]
        public async Task<IActionResult> GetDepolarByUrunId(int urunId)
        {
            var depolar = await _depoUrun.GetDepoByUrunIdAsync(urunId);

            if (depolar == null || !depolar.Any())
                return NotFound("Bu ürünün bulunduğu depo bulunamadı.");

            return Ok(depolar);
        }
    }
}
