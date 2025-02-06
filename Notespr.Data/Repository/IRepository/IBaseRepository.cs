﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Data.Repository.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T Entity);
        void Remove(T Entity);
        void RemoveRange(IEnumerable<T> Entity);
    }
}
