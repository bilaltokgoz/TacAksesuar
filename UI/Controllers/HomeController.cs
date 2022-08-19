using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Core.Utilities.Results;

namespace UI.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IProductBusiness productBusiness;

        public HomeController(IProductBusiness productBusiness)
        {
            this.productBusiness = productBusiness;
        }

        [HttpGet]
        public IActionResult Index()
        {
            productBusiness.AddProduct();

            return Ok("Success");
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
         IDataResult< Product> product = productBusiness.GetBusiness(id);

            return Ok(product);
        }
    }
}
