using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Dto
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "O genero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O tamnho do genero não pode exeder 50 caracteres")]
        public string? Genero { get; set; }
        [Required(ErrorMessage = "O duração do filme é obrigatório")]
        [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}

