using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
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

        [HttpGet]
        [Route("AllOrders")]
        public async Task<IActionResult> GetAllOrders()
        {
            var result = await _mediator.Send(new GetAllOrdersQuery());
            return Ok(result);
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

        [HttpGet]
        [Route("AllSaleTransactions")]
        public async Task<IActionResult> GetAllSaleTransactions()
        {
            var result = await _mediator.Send(new GetAllSaleTransactionsQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("CurrentYearMonthlyTransactions")]
        public async Task<IActionResult> GetCurrentYearMonthlySales()
        {
            var result = await _mediator.Send(new GetCurrentYearMonthlySalesQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("DailySales")]
        public async Task<IActionResult> GetDailySales()
        {
            var result = await _mediator.Send(new GetDailySalesQuery());
            return Ok(result);
        }

    }
}
