using Core.Utilities.Results;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerBusiness
    {
        IDataResult<List<Customer>> GetAllByCustomers();
        IDataResult<Customer> GetCustomer(int id);
        IResult Add(Customer customer); 
        IResult Update(Customer customer);
       IResult Delete(Customer customer);
    }
}
