using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Mappers
{
    public class EnderecoMapper : Profile
    {
        public EnderecoMapper()
        {
            CreateMap<EnderecoEdicaoDTo, Endereco>().ReverseMap();


            CreateMap<EnderecoDTo, Endereco>().ReverseMap();

            //.ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));
            //CreateMap<Escola, EscolaDto>();
        }
    }
}
