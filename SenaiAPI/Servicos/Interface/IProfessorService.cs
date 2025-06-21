using SenaiAPI.DTos;

namespace SenaiAPI.Servicos.Interface
{
    public interface IProfessorService
    {
        void Salvar(ProfessorDTo professor);
        List<ProfessorDTo> BuscarTodos();

        Task Remover(long id);

        public void Editar(ProfessorEdicaoDTo model);
    }
}
