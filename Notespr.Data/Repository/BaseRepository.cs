using Notespr.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public void Add(T Entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(T Entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> Entity)
        {
            throw new NotImplementedException();
        }
    }
}
