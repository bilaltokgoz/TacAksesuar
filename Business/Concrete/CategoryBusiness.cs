
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CategoryBusiness : ICategoryBusiness
    {
        //private readonly IProductDal productDal;
        //private readonly ICategoryDal categoryDal;
        //public CategoryBusiness(IProductDal productDal, ICategoryDal categoryDal)
        //{
        //    this.productDal = productDal;
        //    this.categoryDal = categoryDal; 
        //}
        private readonly ICategoryDal categoryDal;
        public CategoryBusiness(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAllByCategories()
        {
            try
            {
                List<Category> categories = categoryDal.GetAll();
                SuccessDataResult<List<Category>>successDataResult = new SuccessDataResult<List<Category>>(categories);
                return successDataResult;
            }
            catch (Exception)
            {

               return new ErrorDataResult<List<Category>>();
            }
        }

        public IDataResult<Category> GetByCategoryId(int id)
        {
            try
            {
              Category category=  categoryDal.Get(c => c.CategoryId == id);
                SuccessDataResult<Category>successDataResult = new SuccessDataResult<Category>(category);
                return successDataResult;
            }
            catch (Exception)
            {

               return new ErrorDataResult<Category>();
            }
        }

        public IDataResult<Category> GetByCategoryName(string name)
        {
            try
            {
               Category category= categoryDal.Get(c => c.CategoryName == name);
                SuccessDataResult<Category>successDataResult= new SuccessDataResult<Category>(category);
                return successDataResult;
            }
            catch (Exception)
            {

                return new ErrorDataResult<Category>();
            }
        }
        public IResult Add(Category category)
        {
            try
            {
                categoryDal.Add(category);
                SuccessResult successResult = new SuccessResult();
                return successResult;

            }
            catch (Exception)
            {

              return new ErrorResult();
            }
        }

        public IResult Delete(Category category)
        {
            try
            {
                categoryDal.Delete(category);
                SuccessResult successResult= new SuccessResult();
                return successResult;
            }
            catch (Exception)
            {

                return new ErrorResult();
            }
        }

     

        public IResult Update(Category category)
        {
            try
            {
                categoryDal.Update(category);
                SuccessResult successResult=new SuccessResult();
                return successResult;
            }
            catch (Exception)
            {

                return new ErrorResult();
            }
        }
    }
}
