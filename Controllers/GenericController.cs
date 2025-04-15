using AutoMapper;
using Demo1.DTOs;
using Demo1.DTOs.DTO_Interface;
using Demo1.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Demo1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<T, TDto> : ControllerBase where T : class where TDto : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IMapper _mapper;


        public GenericController(IGenericRepository<T> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _repository.GetAllAsync();
            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            var dto = _mapper.Map<TDto>(entity);
            return Ok(dto);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TDto dto)
        {
            if (dto == null) return BadRequest();
            var entity = _mapper.Map<T>(dto);
            await _repository.AddAsync(entity);
            var createdDto = _mapper.Map<TDto>(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.GetType().GetProperty("Id")?.GetValue(entity) }, createdDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TDto dto)
        {
            if (dto == null) return BadRequest();
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();

            _mapper.Map(dto, entity); 
            await _repository.UpdateAsync(entity);

            return NoContent();
        }

        //[HttpPut]
        //public async Task<IActionResult> Update(T entity)
        //{
        //    await _repository.Update(entity);
        //    return NoContent();
        //}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();

            await _repository.DeleteAsync(id);

            return NoContent();
        }

    }
}
