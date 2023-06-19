using FilmesApi.Data;
using FilmesApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private FilmeContext _Context;

        public FilmeController(FilmeContext context)
        {
            _Context = context;
        }   

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
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
    }
}
