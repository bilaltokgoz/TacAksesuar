using Business.Abstract;
using Core.Utilities.Results;
using Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CustomersController : ControllerBase
    {
       private readonly ICustomerBusiness customerBusiness;
        public CustomersController(ICustomerBusiness customerBusiness)
        {
            this.customerBusiness = customerBusiness;
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
           IDataResult<Customer>customer= customerBusiness.GetCustomer(id);
            return Ok(customer.Data);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           IDataResult<List<Customer>>customers= customerBusiness.GetAllByCustomers();
            return Ok(customers);
        }
        [HttpGet]
        public IActionResult Add(Customer customer)
        {
          IResult result=  customerBusiness.Add(customer);
            if (result.Success == true)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest(result.Message);    
            }
        }
        [HttpGet]
        public IActionResult Delete(Customer customer)
        {
           IResult result= customerBusiness.Delete(customer);
           if(result.Success == true)
            {
                return Ok("success");
            }
            else { return BadRequest(result.Message); }
        }
    }
}
