using FlowPlane.Application.Commands.CreateActivity;
using FlowPlane.Application.Queries.GetActivityById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FlowPlane.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateActivityCommand command)
        {
            var id = await _mediator.Send(command);

            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetActivityByIdQuery(id);

            var activity = await _mediator.Send(query);

            if (activity == null)
            {
                return NotFound();
            }

            return Ok(activity);
        }
    }
}