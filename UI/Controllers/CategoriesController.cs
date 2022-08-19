using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryBusiness categoryBusiness;
        public CategoriesController(ICategoryBusiness categoryBusiness)
        {
            this.categoryBusiness = categoryBusiness;
        }
        [HttpGet]
        public IActionResult Get(string name)
        {
            IDataResult<Category> category = categoryBusiness.GetByCategoryName(name);
            return Ok(category.Data);
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
          IDataResult<Category>category=  categoryBusiness.GetByCategoryId(id);
            return Ok(category.Data);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
          IDataResult<List<Category>>categories=  categoryBusiness.GetAllByCategories();
            return Ok(categories);
        }
        [HttpGet]
        public IActionResult Add(Category category)
        {
           IResult result= categoryBusiness.Add(category);
            if (result.Success == true)
            {
               return Ok("success");
            }
            else 
            {
               return BadRequest(result.Message);
            }
        }
        [HttpGet]
        public IActionResult Delete(Category category)
        {
           IResult result= categoryBusiness.Delete(category);
            if(result.Success == true)
            {
                return Ok("success");
            }
            else { return BadRequest(result.Message); }
        }
        [HttpGet]
        public IActionResult Update(Category category)
        {
            IResult result=categoryBusiness.Update(category);
            if( result.Success == true)
            { return Ok("success"); }
            else { return BadRequest(result.Message); }
        }
    }
}
