using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryBusiness
    {
        IDataResult<List<Category>> GetAllByCategories();
        IDataResult<Category> GetByCategoryId(int id);
        IDataResult<Category> GetByCategoryName(string name);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}
