using SenaiAPI.Contexto;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class EscolaRepository : IEscolaRepository
    {

        public readonly SenaiContext _context;

        public EscolaRepository(SenaiContext context) 
        {
            _context = context;
        }

        public List<Escola> PegarTodos()
        {
            return _context.Escola.ToList();
        }
        public void Salvar(Escola escola)
        {
            if (escola.Id == 0) 
            {
                _context.Escola.Add(escola);
            }
            else 
            {
                _context.Escola.Update(escola);
            }
            _context.SaveChanges();
        }
    }
}
