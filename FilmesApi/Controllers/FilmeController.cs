using FilmesApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionaFilme([FromBody]Filme filme) 
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
        [HttpGet]
        public List<Filme> RecuperaFilmes() 
        {
            return filmes;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
