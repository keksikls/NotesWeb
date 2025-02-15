using Notespr.Data.AppDbContext;
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
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }

        void ICategoryRepository.Update(Category obj)
        {
            _context.Categories.Update(obj);
        }
    }
}
