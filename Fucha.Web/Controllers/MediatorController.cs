using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fucha.Web.Controllers;

[ApiController]
public abstract class MediatorController : ControllerBase
{
    private IMediator _mediator;
    protected IMediator Mediator => _mediator ??= (_mediator = HttpContext.RequestServices.GetService<IMediator>()); 
}

