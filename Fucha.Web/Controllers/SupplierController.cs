using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers
{
    [Route("api/Supplier")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get All Suppliers
        [HttpGet]
        [Route("AllSuppliers")]
        public async Task<IActionResult> AllSuppliers()
        {
            var result = await _mediator.Send(new GetAllSuppliersQuery());
            return Ok(result);
        }

        // Remove Supplier
        [HttpDelete]
        [Route("RemoveSupplier")]
        public async Task<IActionResult> RemoveUser(RemoveSupplierCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // Get All Purchase Records
        [HttpGet]
        [Route("AllPurchaseRecords")]
        public async Task<IActionResult> AllPurchaseRecords()
        {
            var result = await _mediator.Send(new GetAllPurchaseRecordsQuery());
            return Ok(result);
        }
    }
}
