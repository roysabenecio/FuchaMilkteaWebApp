using Fucha.DataLayer.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers
{
    [Route("api/Extra")]
    [ApiController]
    public class ExtraController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExtraController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpPost]
        //[Route("CalculateStockMeasure")]
        //public async Task<IActionResult> CalculateStockMeasure(CalculateStockMeasureCommand command)
        //{
        //    var response = await _mediator.Send(command);
        //    return Ok(response);
        //}
        [HttpGet]
        [Route("LoginCredentials")]
        public async Task<IActionResult> GetLoginCredentials(GetAllLoginCredentialsQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        [Route("AllGramSold")]
        public async Task<IActionResult> GetAllGramSold()
        {
            var response = await _mediator.Send(new GetAllGramSoldQuery());
            return Ok(response);
        }
    }
}
