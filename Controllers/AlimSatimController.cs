using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Demo1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AlimSatimController : GenericController<AlimSatim, AlimSatimDto>
    {
        private readonly IAlimSatimRepository _context;
        private readonly IMapper _mapper;

        public AlimSatimController(IAlimSatimRepository context,IMapper mapper):base(context,mapper)
        {
            _context = context;
            _mapper = mapper
            ;
        }

        // Depoya ait işlemleri getirme
        [HttpGet("depo/{depoID}")]
        public async Task<IActionResult> GetByDepo(int depoID)
        {
            var aslar = await _context.GetByDepoAsync(depoID);
            if (aslar == null) return NotFound("Depoya ait işlem bulunamadı.");
            
            return Ok(aslar);
        }

        [HttpGet("{alimSatimId}/FisleriGetir")]
        public async Task<ActionResult> GetFis(int alimSatimId)
        {
            var fisGetir = await _context.GetFisDestekByAlimSatimlarAsync(alimSatimId);
            if (fisGetir == null || fisGetir.Count == 0)
                return NotFound("Bu çalışana ait ticari işlem bulunamadı.");
            var dtos = _mapper.Map<AlimSatim>(fisGetir);
            return Ok(fisGetir);
        }
    }
}
