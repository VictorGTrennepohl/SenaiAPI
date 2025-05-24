using AutoMapper;
using SenaiAPI.DTos;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios;
using SenaiAPI.Repositorios.Interfaces;
using SenaiAPI.Servicos.Interface;

namespace SenaiAPI.Servicos
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IMapper mapper, IEnderecoRepository enderecoRepository)
        {
            _mapper = mapper;
            _enderecoRepository = enderecoRepository;
        }

        public void Salvar(EnderecoDTo enderecoDTo)
        {
            var endereco = _mapper.Map<Endereco>(enderecoDTo);
            _enderecoRepository.Salvar(endereco);
        }

        public List<EnderecoDTo> BuscarTodos()
        {
            var endereco = _enderecoRepository.PegarTodos();
            return _mapper.Map<List<EnderecoDTo>>(endereco);
        }

        public async Task Remover(long id)
        {
            await _enderecoRepository.Remover(id);
        }

        public void Editar(EnderecoEdicaoDTo model)
        {
            var endereco = _enderecoRepository.ObterPorId(model.Id);
            _mapper.Map(model, endereco);
            _enderecoRepository.Salvar(endereco);
        }
    }
}
