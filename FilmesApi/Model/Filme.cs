using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Model
{
    public class Filme 
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
    }
}
