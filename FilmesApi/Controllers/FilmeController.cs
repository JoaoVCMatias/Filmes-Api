using FilmesApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private static List<Filme> filmes = new List<Filme>();
        public void AdicionaFilme(Filme filme) 
        {
            filmes.Add(filme);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
