using Microsoft.AspNetCore.Mvc;
using TaskManager.Domain.Requests;
using TaskManager.Domain.Responses;
using TaskManager.Services;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTask), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestTask request)
        {
            var response = new RegisterTask().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseAllTasks>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var response = new GetAllTasks().Execute();

            if (response.Tasks.Any()) return Ok(response);

            return NoContent();
        }

        [HttpGet, Route("{id}")]
        [ProducesResponseType(typeof(ResponseViewTasks), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new GetByIdTasks().Execute(id);

            if (response.Id == id) return Ok(response);

            return NotFound();
        }

        [HttpPut, Route("{id}")]
        [ProducesResponseType(typeof(ResponseViewTasks), StatusCodes.Status200OK)]
        public IActionResult PutById([FromRoute] int id, [FromBody] RequestTask request)
        {
            var response = new UpdateTasks().Execute(id, request);

            return Ok(response);
        }

        [HttpDelete, Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteById([FromRoute] int id) {
            
            new DeleteTasks().Execute(id);

            return Ok();
        }

    }
}
