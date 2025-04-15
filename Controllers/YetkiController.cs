using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class YetkiController:GenericController<Yetki,YetkiDto>

    {
        private readonly IYetkiRepository _urunr;
        private readonly IMapper _mapper;
        public YetkiController(IYetkiRepository urunr, IMapper mapper) : base(urunr, mapper)
        {
            _urunr = urunr;
            _mapper = mapper;

        }
    }
}
