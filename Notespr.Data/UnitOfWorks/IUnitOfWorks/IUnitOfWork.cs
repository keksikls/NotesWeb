using Notespr.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Data.UnitOfWork.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        //*todo сделать product логику для заметок

        void Save();

    }
}
