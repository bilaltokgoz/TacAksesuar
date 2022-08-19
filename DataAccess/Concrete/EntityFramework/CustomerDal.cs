using Core.Concrete.EfRepository;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfRepository<Customer,EfContext>,ICustomerDal
    {
    }
}
