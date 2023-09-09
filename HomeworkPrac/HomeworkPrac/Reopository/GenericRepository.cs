using HomeworkPrac.Data;
using System.Linq.Expressions;

namespace HomeworkPrac.Reopository
{
    public class GenericRepository<T>:IGenericRepository<T> where T : class
    {
        private readonly practicedbContext _context;
        public void Add(T entity) 
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll() 
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id) 
        {
            return _context.Set<T>().Find(id);
        }

        T IGenericRepository<T>.Get(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Remove(T entity)
        {
            _context.Set<T>().Remove(entity);

        }

        void IGenericRepository<T>.RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

        }

        void IGenericRepository<T>.Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        void IGenericRepository<T>.Update(IEnumerable<T> entity)
        {
             _context.Set<T>().Update((T)entity);
        }
    }
}
