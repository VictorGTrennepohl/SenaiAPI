using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IEnderecoRepository
    {
        void Salvar(Endereco endereco);

        public List<Endereco> PegarTodos();

        Task Remover(long id);

        Endereco ObterPorId(long Id);
    }
}
