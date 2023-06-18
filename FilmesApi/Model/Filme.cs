using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Model
{
    public class Filme 
    {
        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O genero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamnho do genero não pode exeder 50 caracteres")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "O duração do filme é obrigatório")]
        [Range(70,600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
