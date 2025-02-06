using Notespr.Data.Repository.IRepository;
using Notespr.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Data.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public void update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
