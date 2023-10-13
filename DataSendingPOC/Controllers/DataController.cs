using DataSendingPOC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace DataSendingPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet("fromroute/{id}")]
        public ActionResult<string> GetDataFromRoute([FromRoute] int id)
        {
            return $"Data from route: {id}";
        }

        [HttpGet("fromquery")]
        public ActionResult<string> GetDataFromQuery([FromQuery] string name)
        {
            return $"Data from query: {name}";
        }

        [HttpPost("frombody")]
        public ActionResult<string> GetDataFromBody([FromBody] RequestModel data)
        {
            return $"Data from body: {data.Name}";
        }

        [HttpGet("fromheader")]
        public ActionResult<string> GetDataFromHeader([FromHeader(Name = "CustomHeader")] string customHeader)
        {
            return $"Data from header: {customHeader}";
        }
    }
}
