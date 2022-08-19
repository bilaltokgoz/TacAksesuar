using DataAccess.Abstract;
using Core.Concrete.EfRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepository<User, EfContext>, IUserDal
    {
        
    }
}
