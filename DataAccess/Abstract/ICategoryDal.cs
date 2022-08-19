using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace DataAccess.Abstract
{
  public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
