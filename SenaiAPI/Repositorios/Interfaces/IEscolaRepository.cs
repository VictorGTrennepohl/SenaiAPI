using SenaiAPI.DTos;
using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IEscolaRepository
    {
        public List<Escola> PegarTodos();
        void Salvar(Escola escola);
       
    }
}
