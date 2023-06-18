using FilmesApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public void AdicionaFilme([FromBody]Filme filme) 
        {
            filme.Id = id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes() 
        {
            return filmes;
        }
        [HttpGet("{id}")]
        public Filme? RecuperaFilmesPorID(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
