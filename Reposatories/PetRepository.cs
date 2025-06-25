using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManger;
using Entities;
using Repositories.IRepository;

namespace Repositories
{
    internal class PetRepository : Repository<Pet>, IPetRepository
    {
        private readonly ApplicationDbContext context;
        public PetRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

    }
}
