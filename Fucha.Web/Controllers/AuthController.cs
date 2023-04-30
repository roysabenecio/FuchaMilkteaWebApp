using Fucha.DataLayer.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration, IMediator mediator)
        {
            _configuration = configuration;
            _mediator = mediator;

        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginUser(LoginCommand command)
        {
            var response = await _mediator.Send(command);
            if (response == null)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("LoginActivity")]
        public async Task<IActionResult> LoginActivity(LoginActivityCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost]
        [Route("LogoutActivity")]
        public async Task<IActionResult> LogoutActivity(LogoutActivityCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

    }
}
