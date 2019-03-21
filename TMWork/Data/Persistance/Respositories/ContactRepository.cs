using TMWork.Data.Core.Domain;
using TMWork.Data.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMWork.Data.Persistance.Respositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    { 
        public ContactRepository(ECDbContext context) : base(context)
        {
        }

    }
}
