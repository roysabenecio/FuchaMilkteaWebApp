using Fucha.DataLayer.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers
{
    [Route("api/Menu")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MenuController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("AllMenus")]
        public async Task<IActionResult> GetAllMenus()
        {
            var result = await _mediator.Send(new GetAllMenuQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("AllMenuPrices")]
        public async Task<IActionResult> GetAllMenuPrices()
        {
            var result = await _mediator.Send(new GetAllMenuPricesQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("AllMenuCategories")]
        public async Task<IActionResult> GetAllMenuCategories()
        {
            var response = await _mediator.Send(new GetAllMenuCategoriesQuery());
            return Ok(response);
        }


    }
}
