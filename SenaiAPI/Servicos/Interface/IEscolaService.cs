using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Servicos.Interface
{
    public interface IEscolaService 
    {
        void Salvar(EscolaDTo escola);
        List<EscolaDTo> BuscarTodos();


    }
}
