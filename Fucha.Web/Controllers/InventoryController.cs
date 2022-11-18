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

        // Get All Item
        //[HttpGet]
        //[Route("GetAllItems")]
        //public async Task<IActionResult> GetAllItems()
        //{
        //    var result = await _mediator.Send(new GetAllItemsQuery());
        //    return Ok(result);
        //}

        // Get All Menu
        [HttpGet]
        [Route("GetAllMenus")]
        public async Task<IActionResult> GetAllMenus()
        {
            var result = await _mediator.Send(new GetAllMenuQuery());
            return Ok(result);
        }

        // Get All Prices
        [HttpGet]
        [Route("GetAllMenuPrices")]
        public async Task<IActionResult> GetAllMenuPrices()
        {
            var result = await _mediator.Send(new GetAllMenuPricesQuery());
            return Ok(result);
        }

        // Get All Add Ons
        [HttpGet]
        [Route("GetAllAddOns")]
        public async Task<IActionResult> GetAllAddOns()
        {
            var result = await _mediator.Send(new GetAllAddOnsQuery());
            return Ok(result);
        }

        // Get All Sizes
        [HttpGet]
        [Route("GetAllSizes")]
        public async Task<IActionResult> GetAllSizes()
        {
            var result = await _mediator.Send(new GetAllSizesQuery());
            return Ok(result);
        }

        // Get All Suppliers
        [HttpGet]
        [Route("AllSuppliers")]
        public async Task<IActionResult> AllSuppliers()
        {
            var result = await _mediator.Send(new GetAllSuppliersQuery());
            return Ok(result);
        }
        // Get All Suppliers
        [HttpGet]
        [Route("AllPurchaseRecords")]
        public async Task<IActionResult> AllPurchaseRecords()
        {
            var result = await _mediator.Send(new GetAllPurchaseRecordsQuery());
            return Ok(result);
        }
    }
}
