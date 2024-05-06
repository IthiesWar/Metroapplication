using METROAPI;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace METROAPI.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private static List<User> _UserDetails=new List<User>()
        {
            new User {UserID=1,UserName="harshad",UserEmail="harshad@gmail.com",UserBalance=9,UserPhone="6655443321",UserPassword="har@@66"},
            new User {UserID=2,UserName="kumaresh",UserEmail="kumar@gmail.com",UserBalance=10,UserPhone="9988776655",UserPassword="kumar@@66"}
            
        };
        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok(_UserDetails);
        }
         [HttpGet("{id}")]
        public  IActionResult GetUserDetails(int id)
        {
            var UserDetails=_UserDetails.Find(U=>U.UserID==id);
            if(_UserDetails==null)
            {
                return NotFound();
            }
            return Ok(_UserDetails);
        }

       
         [HttpPost]
        public IActionResult PostUserDetails([FromBody]User UserDetails)
        {
            _UserDetails.Add(UserDetails);
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult PutMedicine(int id,[FromBody] User UserDetails)
        {
            var index=_UserDetails.FindIndex(U=>U.UserID==id);
            if(index<0)
            {
                return NotFound();
            }
            _UserDetails[index]=UserDetails;
            return Ok();
        }
          [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var medicine=_UserDetails.Find(U=>U.UserID==id);
            if(medicine==null)
            {
                return NotFound();
            }
            _UserDetails.Remove(medicine);
            return Ok();
        }

    }

    
}