using Microsoft.EntityFrameworkCore;
using SenaiAPI.Contexto;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class ProfessorRepository : IProfessorRepository
    {
        public readonly SenaiContext _context;

        public ProfessorRepository(SenaiContext context)
        {
            _context = context;
        }

        public void Salvar(Professor professor)
        {
            if (professor.Id == 0)
            {
                _context.Professor.Add(professor);
            }
            else
            {
                _context.Professor.Update(professor);//if(endereco.Id > 0) Update
            }
            _context.SaveChanges();
        }
        public List<Professor> PegarTodos()
        {
            return _context.Professor.ToList();
        }

        public async Task Remover(long id)//se colocar bool, colocar try{} catch{return false}/void
        {
            await _context.Professor.Where(c => c.Id == id).ExecuteDeleteAsync();

        }

        public Professor ObterPorId(long id)
        {
            return _context.Professor.FirstOrDefault(e => e.Id == id);
        }
    }
}
