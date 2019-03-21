using TMWork.Data.Core;
using TMWork.Data.Core.Repositories;
using TMWork.Data.Persistance.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMWork.Data.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {

        public ECDbContext _context { get; }
        public IContactRepository Contacts { get; private set; }

        public UnitOfWork(ECDbContext context)
        {
            _context = context;
            Contacts = new ContactRepository(_context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
