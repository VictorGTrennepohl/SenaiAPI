using Microsoft.EntityFrameworkCore;
using SenaiAPI.Contexto;
using SenaiAPI.Entidades;
using SenaiAPI.Repositorios.Interfaces;

namespace SenaiAPI.Repositorios
{
    public class BaseRepository<T> //: IBaseRepository<T> where T : class
    {
        //protected readonly SenaiContext _context;
        //protected readonly DbSet<T> _dbSet;

        //public BaseRepository(SenaiContext context)
        //{
        //    _context = context;
        //    _dbSet = context.Set<T>();
        //}

        //public List<T> PegarTodos()
        //{
        //    return _dbSet.ToList();
        //}
    }
}
