using DevFreela.Application.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers {
    [Route("api/users")]
    public class UserController: ControllerBase {

        [HttpGet("{id}")]
        public IActionResult GetById(int id) { 
            return Ok(new { id });
            
        
        }

        [HttpPost]
        public IActionResult CreateUsers([FromBody] NewUserInputModel createUser) {
            return Created();
        }


        


    }
}
