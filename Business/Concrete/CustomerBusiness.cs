using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerBusiness : ICustomerBusiness

    {
        private readonly ICustomerDal customerDal;
        public CustomerBusiness(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAllByCustomers()
        {
            try
            {
                List<Customer> customers = customerDal.GetAll();
                SuccessDataResult<List<Customer>>successDataResult=new SuccessDataResult<List<Customer>>(customers);
                return successDataResult;


            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<Customer>>(ex.Message);
            }
        }

        public IDataResult<Customer> GetCustomer(int id)
        {
            try
            {
                Customer customer = customerDal.Get(c => c.CustomerID == id);
                SuccessDataResult<Customer> successDataResult = new SuccessDataResult<Customer>(customer, "");
                return successDataResult;
            }
            catch (Exception)
            {

           return new ErrorDataResult<Customer>();
            }
        }
        public IResult Add(Customer customer)
        {
            try
            {
                customerDal.Add(customer);
                SuccessResult successResult=new SuccessResult();
                return successResult;

            }
            catch (Exception)
            {

               return new ErrorResult();    
            }
        }

        public IResult Delete(Customer customer)
        {
            try
            {
                customerDal.Delete(customer);
                SuccessResult successResult =new SuccessResult();
                return successResult;

            }
            catch (Exception)
            {

                return new ErrorResult();
            }
        }

     

        public IResult Update(Customer customer)
        {
            try
            {
                customerDal.Update(customer);
                SuccessResult successResult = new SuccessResult();
                return successResult;
            }
            catch (Exception)
            {

                return new ErrorResult();
            }
        }
    }
}
