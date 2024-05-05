using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningWithController.V1.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/StringList")]
    [ApiVersion("1.0")]
    public class StringListController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            return WeatherForecast.Summaries.Where(x => x.StartsWith("F"));
        }
    }
}
