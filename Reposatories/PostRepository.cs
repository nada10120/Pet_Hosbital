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
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private readonly ApplicationDbContext context;
        public PostRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }


    }
}
