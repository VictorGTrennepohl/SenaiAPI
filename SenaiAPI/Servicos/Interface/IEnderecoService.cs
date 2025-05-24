using SenaiAPI.DTos;

namespace SenaiAPI.Servicos.Interface
{
    public interface IEnderecoService
    {
        void Salvar(EnderecoDTo endereco);

        List<EnderecoDTo> BuscarTodos();

        Task Remover(long id);

        public void Editar(EnderecoEdicaoDTo model);

    }
}
