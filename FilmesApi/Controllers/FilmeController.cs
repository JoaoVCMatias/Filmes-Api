using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Dto;
using FilmesApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private FilmeContext _Context;
        private IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _Context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);
            _Context.Filmes.Add(filme);
            _Context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmesPorID), new { id = filme.Id },
                filme);

        }
        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return _Context.Filmes.Skip(skip).Take(take);
        }
        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorID(int id)
        {
            Filme? filme = _Context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();

            return Ok(filme);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto) 
        {
            var filme = _Context.Filmes.FirstOrDefault(
                  filme => filme.Id == id);
            if (filme == null) return NotFound();
            _mapper.Map(filmeDto, filme);
            _Context.SaveChanges();
            return NoContent();
        }
    }
}
