using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;





namespace DevFreela.API.Controllers {


    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase {

        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService) {
            _projectService = projectService;
        }
        



        [HttpGet]
        public IActionResult Get(string query) {

            return Ok("Value");

            
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewProjectInputModel createProject) {
            return CreatedAtAction(nameof(GetById), new { createProject.Id }, createProject); 
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectInputModel updateProject) {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment) {
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id) {
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id) {
            return NoContent();
        }


    }
}
