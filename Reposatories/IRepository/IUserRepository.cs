﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repositories.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
