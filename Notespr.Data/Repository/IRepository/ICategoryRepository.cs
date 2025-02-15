using Notespr.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Data.Repository.IRepository
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        void Update(Category obj);
    }
}
