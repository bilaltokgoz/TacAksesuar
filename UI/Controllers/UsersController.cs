using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserBusiness userBusiness;
        public UsersController(IUserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
          IDataResult<User>user=  userBusiness.Get(id);
            return Ok(user.Data);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            IDataResult<List<User>>users=userBusiness.GetAll();
            return Ok(users);   
        }
        [HttpGet]
        public IActionResult Add(User user)
        {
           IResult result= userBusiness.Add(user);
            if (result.Success == true)
            {
                return Ok("success");
            }
            else { return BadRequest(result.Message); }
        }
        [HttpGet]
        public IActionResult Delete(User user)
        {
           IResult result= userBusiness.Delete(user);
            if(result.Success == true)
            {
              return  Ok("success");
            }
            else { return BadRequest(result.Message); }
        }
        [HttpGet]
        public IActionResult Update(User user)
        {
           IResult result= userBusiness.Update(user);
            if (result.Success == true)
            {
                return Ok("success");
            }
            else { return BadRequest(result.Message); }
        }
        
    }
}
