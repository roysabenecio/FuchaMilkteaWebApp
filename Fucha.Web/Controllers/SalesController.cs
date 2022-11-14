using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
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
        //public async Task<IActionResult> PostSalesOrders([FromBody]PostSalesOrdersCommand request)
        //public async Task<IActionResult> PostSalesOrders([FromBody] PostSalesOrdersCommand request)
        public async Task<IActionResult> PostSalesOrders([FromBody] List<Order> orders)
        {
            if (orders.Count != 0)
            {
                var result = await _mediator.Send(new PostSalesOrdersCommand(orders));
                //var result = await _mediator.Send(new PostSalesOrdersCommand());
                //var result = await _mediator.Send(request);
                return Ok(result);
            } else
            {
                return NoContent();
            }
        }
    }
}
