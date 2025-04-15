using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Demo1.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolYetkileriController:GenericController<RolYetki,RolYetkiDto>
    {
        private readonly IRolYetkileriRepository _repo;
        private readonly IMapper _mapper;

        public RolYetkileriController(IRolYetkileriRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //Role ait yetkiler
        [HttpGet("{rolID}/yetkiler")]
        public async Task<IActionResult> GetRolYetkileri(int rolID)
        {
            var yetkiler = _repo.GetRolYetkileriAsync(rolID);
            if (yetkiler == null) return NotFound("Role ait yetki bulunamadı");
            var dtos = _mapper.Map<RolYetki>(yetkiler);
            return Ok(dtos);// burayı unutma
        }
    }
}
