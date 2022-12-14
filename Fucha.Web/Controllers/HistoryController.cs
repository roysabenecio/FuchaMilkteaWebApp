using Fucha.DataLayer.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers
{
    [Route("api/History")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HistoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("AllLoginHistory")]
        public async Task<IActionResult> GetAllLoginHistory()
        {
            var response = await _mediator.Send(new GetAllLoginHistoryQuery());
            return Ok(response);
        }

        [HttpGet]
        [Route("AllActivityHistory")]
        public async Task<IActionResult> GetAllActivityHistory()
        {
            var response = await _mediator.Send(new GetAllActivityHistoryQuery());
            return Ok(response);
        }
    }
}
