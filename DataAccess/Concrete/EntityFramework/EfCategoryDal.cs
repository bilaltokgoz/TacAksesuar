using Core.Abstract;
using Core.Concrete.EfRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepository<Category, EfContext> ,ICategoryDal
    {
       
    }
}
