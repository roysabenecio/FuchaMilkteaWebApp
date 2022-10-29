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

        // Get All Ingredient
        [HttpGet]
        [Route("GetAllIngredients")]
        public async Task<IActionResult> GetAllIngredients()
        {
            var result = await _mediator.Send(new GetAllIngredientsQuery());
            return Ok(result);
        }

        // Get All Material



        //[HttpPost]
        //[Route("AddIngredient")]
        //[ResponseType(typeof(Task<IngredientDTO>))]
        //public async Task<IActionResult> AddIngredient(AddItemCommand command)
        //{
        //    Console.WriteLine(command);
        //    //var result = await _mediator.Send(command);
        //    //return Ok(result);
        //    return Ok();
        //}
    }
}
