//using Fucha.DataLayer.CQRS.Queries;
//using Fucha.DomainClasses;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace Fucha.Web.Controllers
//{
//    [Route("api/Sales")]
//    [ApiController]
//    public class SalesController : ControllerBase
//    {
//        private readonly IMediator _mediator;
//        public SalesController(IMediator mediator)
//        {
//            _mediator = mediator;
//        }
//        [HttpGet]
//        [Route("GetAllMeals")]
//        public async Task<IActionResult> GetAllMeal()
//        {
//            var result = _mediator.Send(new GetAllMealsQuery());
//            return Ok();
//        }
//    }
//}
