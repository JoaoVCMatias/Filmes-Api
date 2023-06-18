using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Model
{
    public class Filme 
    {
        public string Titulo { get; set; }
        public string Gereno { get; set; }
        public int Duracao { get; set; }
    }
}
