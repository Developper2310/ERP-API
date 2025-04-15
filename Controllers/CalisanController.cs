using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Demo1.Repositories;
using Microsoft.AspNetCore.Mvc;
using Demo1.DTOs.DTO_Interface;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalisanController : GenericController<Calisan, CalisanDto>
    {

        private readonly ICalisanRepository _calisanRepository;
        private readonly IMapper _mapper;

        public CalisanController(ICalisanRepository calisanRepository, IMapper mapper) : base(calisanRepository, mapper)
        {
            _calisanRepository = calisanRepository;
            _mapper = mapper;
        }
        //Http İstekleri değiştirebilirim !

        //TOPLAM MAAS ŞİMDİLİK YOK
        //[HttpGet("ToplamMaas")]
        //public async Task<IActionResult> ToplamMaas()
        //{
        //    var toplamMaas = await _calisanRepository.GetToplamMaasAsync();
        //    return Ok(toplamMaas);
        //}

        [HttpGet("GetByDepartman/{depID}")]
        public async Task<IActionResult> GetByDepartman(int depID)
        {
            var calisanlar = await _calisanRepository.GetCalisanlarByDepartmanDtoAsync(depID);
            if (calisanlar == null || !calisanlar.Any())
            {
                return NotFound("Bu departma ait çalışan bulunamadı.");
            }
            return Ok(calisanlar);
        }



        [HttpGet("{calisanID}/Yetkiler")]
        public async Task<IActionResult> GetCalisanYetkileri(int calisanID)
        {
            var yetkiler = await _calisanRepository.GetCalisanYetkileriDtoAsync(calisanID);
            if (yetkiler == null || !yetkiler.Any())
            {
                return NotFound("Bu çalışana ait yetki bulunamadı.");
            }
            return Ok(yetkiler);
        }



        // Bu Controller dan nçıkarılabilirler <<<--------------

        [HttpGet("{calisanID}/AlimSatimlar")]
        public async Task<IActionResult> GetCalisanAlimSatim(int calisanID)
        {
            var alimSatimlar = await _calisanRepository.GetCalisanAlimSatimDtoAsync(calisanID);
            if (alimSatimlar == null || !alimSatimlar.Any())
            {
                return NotFound("Bu çalışana ait alım-satım kaydı bulunamadı.");
            }
            return Ok(alimSatimlar);
        }



        [HttpGet("{calisanID}/Islemler")]
        public async Task<IActionResult> GetCalisanIslemleri(int calisanID)
        {
            var islemler = await _calisanRepository.GetCalisanIslemlerDtoAsync(calisanID);
            if (islemler == null || !islemler.Any())
            {
                return NotFound("Bu çalışana ait işlem bulunamadı.");
            }
            return Ok(islemler);
        }
    }
}












//public class CalisanController : ControllerBase
//{
//    private readonly IGenericRepository<Calisan> _calisanRepository;

//    public CalisanController(IGenericRepository<Calisan> calisanRepository)
//    {
//        _calisanRepository = calisanRepository;
//    }

//    [HttpGet]
//    public async Task<IActionResult> GetAllCalisan()
//    {
//        var calisanlar = await _calisanRepository.GetAllAsync();
//        return Ok(calisanlar);
//    }

//    [HttpGet("{id}")]
//    public async Task<IActionResult> GetCalisanById(int id)
//    {
//        var calisan = await _calisanRepository.GetByIdAsync(id);
//        if (calisan == null) return NotFound();
//        return Ok(calisan);
//    }

//    [HttpPost]
//    public async Task<IActionResult> CreateCalisan([FromBody] Calisan calisan)
//    {
//        if (calisan == null) return BadRequest();
//        await _calisanRepository.AddAsync(calisan);
//        return CreatedAtAction(nameof(GetCalisanById), new { id = calisan.CalisanID }, calisan);
//    }

//    [HttpPut("{id}")]
//    public IActionResult UpdateCalisan(int id, [FromBody] Calisan calisan)
//    {
//        if (calisan == null || id != calisan.CalisanID) return BadRequest();
//        _calisanRepository.Update(calisan);
//        return NoContent();
//    }

//    [HttpDelete("{id}")]
//    public async Task<IActionResult> DeleteCalisan(int id)
//    {
//        var calisan = await _calisanRepository.GetByIdAsync(id);
//        if (calisan == null) return NotFound();
//        _calisanRepository.Delete(calisan);
//        return NoContent();
//    }
//}
