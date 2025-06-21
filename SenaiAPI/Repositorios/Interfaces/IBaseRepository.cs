using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IBaseRepository<T> //where T : class
    {
       List<T> PegarTodos();

    }
}
