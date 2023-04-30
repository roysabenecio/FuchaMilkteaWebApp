using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
using Fucha.DataLayer.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("AllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("AllExistingUsers")]
        public async Task<IActionResult> GetAllExistingUsers()
        {
            var result = await _mediator.Send(new GetAllExistingUsersQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("AllRemovedUsers")]
        public async Task<IActionResult> GetAllRemovedUsers()
        {
            var result = await _mediator.Send(new GetAllRemovedUsersQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("GetUserInfo")]
        public async Task<IActionResult> GetUserInfo([FromQuery] GetUserQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser(RegisterCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("EditUser")]
        public async Task<IActionResult> EditUser([FromBody] EditUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("EditProfile/{id}")]
        public async Task<IActionResult> EditProfile(int id, [FromBody] ProfileDTO command)
        {
            var response = await _mediator.Send(new EditProfileCommand(id, command));
            return Ok(response);
        }

        [HttpPut]
        [Route("RemoveUser")]
        public async Task<IActionResult> RemoveUser(RemoveUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("RestoreUser")]
        public async Task<IActionResult> RestoreUser(RestoreUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost]
        [Route("ValidateUsername")]
        public async Task<IActionResult> ValidateUsername(ValidateUsernameCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        } 
    }
}
