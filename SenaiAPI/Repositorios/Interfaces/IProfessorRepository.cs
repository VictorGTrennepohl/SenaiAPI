using SenaiAPI.Entidades;

namespace SenaiAPI.Repositorios.Interfaces
{
    public interface IProfessorRepository
    {
        void Salvar(Professor professor);
        public List<Professor> PegarTodos();

        Task Remover(long id);

        Professor ObterPorId(long Id);
    }
}
