global using DynamicSpeedControl.Server.Data;
global using Microsoft.AspNetCore.Mvc;

namespace DynamicSpeedControl.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        public readonly DataContext _dataContext;

        public BaseController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
