using AutoMapper;
using Demo1.Controllers;
using Demo1.DTOs;
using Demo1.Interfaces;
using Demo1.Model;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class RolController : GenericController<Rol, RolDto>
{
    private readonly IRolRepository _rolRepository;
    private readonly IMapper _mapper;

    public RolController(IRolRepository rolRepository, IMapper mapper)
        : base(rolRepository, mapper)
    {
        _rolRepository = rolRepository;
        _mapper = mapper;
    }

   
}