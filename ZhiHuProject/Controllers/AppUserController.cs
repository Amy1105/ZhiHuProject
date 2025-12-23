using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using UseCases.AppUsers.Queries;

namespace ZhiHuProject.Controllers
{
    public class AppUserController : ApiControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await Sender.Send(new GetUserInfoQuery(id));

            return ReturnResult(result);
        }
    }
}
