using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Mappers
{
    public class ProfessorMapper : Profile
    {
        public ProfessorMapper()
        {
            CreateMap<ProfessorEdicaoDTo, Professor>().ReverseMap();


            CreateMap<ProfessorDTo, Professor>().ReverseMap();

        }
    }
}
