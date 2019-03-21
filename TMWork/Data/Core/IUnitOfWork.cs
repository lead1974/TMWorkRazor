using TMWork.Data.Core.Repositories;
using TMWork.Data.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMWork.Data.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ECDbContext _context { get; }
        IContactRepository Contacts { get; }
        int Complete();
    }
}
