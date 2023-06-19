using AutoMapper;
using FilmesApi.Dto;
using FilmesApi.Model;

namespace FilmesApi.profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile() 
        {
            CreateMap<CreateFilmeDto, Filme>();
        }
    }
}
