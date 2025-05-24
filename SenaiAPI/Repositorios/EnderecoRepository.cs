using Microsoft.EntityFrameworkCore;
using SenaiAPI.Contexto;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public readonly SenaiContext _context;

        public EnderecoRepository(SenaiContext context)
        {
            _context = context;
        }

        public void Salvar(Endereco endereco)
        {
            if (endereco.Id == 0)
            {
                _context.Endereco.Add(endereco);
            }
            else
            {
                _context.Endereco.Update(endereco);//if(endereco.Id > 0) Update
            }
            _context.SaveChanges();
        }

        public List<Endereco> PegarTodos()
        {
            return _context.Endereco.ToList();
        }

        public async Task Remover(long id)//se colocar bool, colocar try{} catch{return false}/void
        {
            await _context.Endereco.Where(c => c.Id == id).ExecuteDeleteAsync();

        }

        public Endereco ObterPorId(long id)
        {
            return _context.Endereco.FirstOrDefault(e => e.Id == id);
        }
    }
}
