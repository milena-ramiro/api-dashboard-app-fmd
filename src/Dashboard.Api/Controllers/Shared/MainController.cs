using System.Linq;
using Dashboard.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Api.Controllers.Shared;

[ApiController]
public abstract class MainController : ControllerBase
{
    private readonly INotificator _notificator;

    public MainController(INotificator notificator)
    {
        _notificator = notificator;
    }

    protected bool ValidOperation()
    {
        return !_notificator.HasNotification();
    }

    protected ActionResult CustomResponse(object result = null)
    {
        if (ValidOperation())
            return Ok(new
            {
                success = true,
                data = result
            });

        return BadRequest(new
        {
            success = false,
            errors = _notificator.GetNotifications().Select(n => n.Message)
        });
    }
}