using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
using Fucha.DataLayer.DTOs;
using Fucha.DomainClasses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers
{
    [Route("api/Sales")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SalesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("SalesOrders")]
        public async Task<IActionResult> PostSalesOrders([FromBody] PostSalesOrdersCommand command)
        {
            if (command.Orders != null)
            {
                var result = await _mediator.Send(command);
                return Ok(result);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
