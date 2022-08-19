using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class UserBusiness:IUserBusiness
    {
       private readonly IUserDal userDal;
        public UserBusiness(IUserDal userDal)
        {
           this.userDal = userDal;
        }
        public IDataResult<User> Get(int id)
        {
         
            try
            {
                User user = userDal.Get(u => u.UserId == id);
                SuccessDataResult<User> successDataResult = new SuccessDataResult<User>(user, "kullanıcı adı geldi");
                return successDataResult;
            }
            catch (Exception)
            {
                return new ErrorDataResult<User>();
            }
        }

        public IDataResult<List<User>> GetAll()
        {
         
            try
            {
                List<User> users = userDal.GetAll();
                SuccessDataResult<List<User>> successDataResult = new SuccessDataResult<List<User>>(users);
                return successDataResult;
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<User>>();
            }
        }

        public IResult Add(User user)
        {
           
            try
            {
                userDal.Add(user);
                SuccessResult result = new SuccessResult();
                return result;
            }
            catch (Exception)
            {

               return new ErrorResult();
            }
        }

        public IResult Delete(User user)
        {
         
            try
            {
                userDal.Delete(user);
                SuccessResult result=new SuccessResult();
                return result;
            }
            catch (Exception)
            {

                return new ErrorResult();
            }

        }

      

        public IResult Update(User user)
        {
            try
            {
                userDal.Update(user);
                SuccessResult result= new SuccessResult();
                return result;

            }
            catch (Exception)
            {

                return new ErrorResult();
            }
        }
    }
}
