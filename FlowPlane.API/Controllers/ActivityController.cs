using FlowPlane.Application.Commands.CreateActivity;
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
    }
}