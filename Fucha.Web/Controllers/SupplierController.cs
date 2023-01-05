using Fucha.DataLayer.CQRS.Commands;
using Fucha.DataLayer.CQRS.Queries;
using Fucha.DataLayer.DTOs;
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

        // Get All Purchase Records
        [HttpGet]
        [Route("AllPurchaseRecords")]
        public async Task<IActionResult> AllPurchaseRecords()
        {
            var result = await _mediator.Send(new GetAllPurchaseRecordsQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("AllPORecords")]
        public async Task<IActionResult> AllPORecords()
        {
            var result = await _mediator.Send(new GetAllPORecordsQuery());
            return Ok(result);
        }

        [HttpPost]
        [Route("AddSupplier")]
        public async Task<IActionResult> AddSupplier(AddSupplierCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddPurchaseRecord")]
        public async Task<IActionResult> AddPurchaseRecord(AddPurchaseRecordCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdatePurchaseRecord")]
        public async Task<IActionResult> EditUser(UpdatePRCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("EditSupplier")]
        public async Task<IActionResult> EditUser(EditSupplierCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        [Route("RemoveSupplier")]
        public async Task<IActionResult> RemoveUser(RemoveSupplierCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [Route("RestoreSupplier")]
        [HttpPut]
        public async Task<IActionResult> RestoreSupplier(RestoreSupplierCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
