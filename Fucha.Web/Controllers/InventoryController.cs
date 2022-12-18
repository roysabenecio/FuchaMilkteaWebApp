using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
using Fucha.DataLayer.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Description;

namespace Fucha.Web.Controllers
{
    [Route("api/Inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InventoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get All Menu
        [HttpGet]
        [Route("AllMenus")]
        public async Task<IActionResult> GetAllMenus()
        {
            var result = await _mediator.Send(new GetAllMenuQuery());
            return Ok(result);
        }

        // Get All Prices
        [HttpGet]
        [Route("AllMenuPrices")]
        public async Task<IActionResult> GetAllMenuPrices()
        {
            var result = await _mediator.Send(new GetAllMenuPricesQuery());
            return Ok(result);
        }

        // Get All Add Ons
        [HttpGet]
        [Route("AllAddOns")]
        public async Task<IActionResult> GetAllAddOns()
        {
            var result = await _mediator.Send(new GetAllAddOnsQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("AllSizes")]
        public async Task<IActionResult> GetAllSizes()
        {
            var result = await _mediator.Send(new GetAllSizesQuery());
            return Ok(result);
        }

        [HttpPost]
        [Route("AddStock")]
        public async Task<IActionResult> AddStock(AddStockCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [Route("AllStocks")]
        public async Task<IActionResult> GetAllStocks()
        {
            var result = await _mediator.Send(new GetAllStocksQuery());
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateStockMeasure")]
        public async Task<IActionResult> AddStock(UpdateStockMeasureCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("EditStock/")]
        public async Task<IActionResult> EditStock([FromBody] EditStockCommand command )
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("RemoveStock")]
        public async Task<IActionResult> RemoveStock(RemoveStockCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
