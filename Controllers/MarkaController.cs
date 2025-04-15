using AutoMapper;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MarkaController:GenericController<Marka,MarkaDto>
    {
        private readonly IMarkaRepository _context;
        private readonly IMapper _mapper;



        public MarkaController(IMarkaRepository context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper
            ;
        }

    }
}
