using Notespr.Data.AppDbContext;
using Notespr.Data.Repository;
using Notespr.Data.Repository.IRepository;
using Notespr.Data.UnitOfWork.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ICategoryRepository Category { get; private set; }
        //*todo сделать product логику для заметок

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Category = new CategoryRepository(_context);
            //*todo сделать product логику для заметок
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
