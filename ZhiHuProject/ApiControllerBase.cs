using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel.Result;

namespace ZhiHuProject
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiControllerBase:ControllerBase
    {
        protected ISender Sender => HttpContext.RequestServices.GetRequiredService<ISender>();


        protected IActionResult ReturnResult(ICommonResult result)
        {
            switch(result.Status)
            {
                case ResultStatus.Ok:
                    var value = result.GetValue();
                    return value is null ? NoContent():Ok(value);
                case ResultStatus.Error:
                    return result.Errors is null ? BadRequest(): BadRequest(new {error=result.Errors});
                case ResultStatus.NotFound:
                    return result.Errors == null ? NotFound() : NotFound(new {error=result.Errors});
                case ResultStatus.Invalid:
                    return result.Errors == null ? BadRequest() : BadRequest(new { error = result.Errors });
                case ResultStatus.Forbidden:
                    return StatusCode(403);
                case ResultStatus.Unauthorized:
                    return Unauthorized();
                    default:
                    return BadRequest();                      
            }
        }
    }
}
