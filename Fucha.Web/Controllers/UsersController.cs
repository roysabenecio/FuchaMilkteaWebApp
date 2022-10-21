using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web.Http.Description;
//using System.Web.Http;

namespace Fucha.Web.Controllers
{
    //[Route("api/[controller]")]
    //[EnableCors("AnotherPolicy")]
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private static GetUsers getUsers = new GetUsers();
        private static CreateUser createUser = new CreateUser();
        private static DeleteUser deleteUser = new DeleteUser();
        //private static EditUser editUser = new EditUser();

        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        //[ProducesResponseType(typeof(List<UserDTO>), (int)HttpStatusCode.OK)]
        [ResponseType(typeof(Task<List<UserDTO>>))]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        //[HttpGet]
        //[Route("GetUser")]
        //[ResponseType(typeof(Task<UserDTO>))]
        //public async Task<IActionResult> GetUser([FromHeader] GetUserQuery request)
        //{
        //    var response = await _mediator.Send(request);

        //    return Ok(result);
        //}

        [HttpGet]
        [Route("Credentials")]
        [ResponseType(typeof(Task<LoginCredentialsDTO>))]
        public async Task<IActionResult> GetCredentials([FromHeader] LoginCredentialsQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        //[Route("GetUser")]
        //[HttpGet]
        //public ActionResult GetUser(int id)
        //{
        //    return getUsers.GetUserQuery(id);
        //}

        [Route("CreateUser")]
        [HttpPost]
        public void CreatUser(User userInfo)
        {
            createUser.CreateUserCommand(userInfo);
        }

        [Route("DeleteUser")]
        [HttpDelete]
        public void DeletUser(DeleteUserRequest request)
        {
            deleteUser.DeleteUserCommand(request);
        }

        //[Route("EditUser")]
        //[HttpPut]
        //public void EditUser(EditUserRequest request)
        //{
        //    EditUserCommand(request);
        //}


        //public UsersController(IMapper mapper, IUserService service)
        //{
        //    this._mapper = mapper;
        //    this._service = service;
        //}
        //public string GetUserInfo(string type)
        //{
        //    return this.User.Claims.First(i => i.Type == type).Value;
        //}
        //[HttpGet]
        //[ProducesResponseType(typeof(UserResultResource), 200)]
        //public async Task<IActionResult> Get()
        //{

        //    var userResource = new UserResultResource()
        //    {
        //        FirstName = GetUserInfo("name"),
        //        Users = _mapper.Map<IEnumerable<UserResource>>(await _service.GetAllUsersAsync())
        //    };
        //    return Ok(userResource);
        //}
    }
}
