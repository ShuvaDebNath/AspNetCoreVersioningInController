using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApiVersioningWithController.V2.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/StringList")]
    [ApiVersion("2.0")]
    public class StringListController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            return WeatherForecast.Summaries.Where(x => x.StartsWith("C"));
        }
    }
}
