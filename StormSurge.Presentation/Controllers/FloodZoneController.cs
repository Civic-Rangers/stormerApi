using Shared.DataTransferObjects;
using Service.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace StormSurge.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloodZoneController : ControllerBase
    {
        private readonly IServiceManager _service;

        public FloodZoneController(IServiceManager service) =>
            _service = service;

        [HttpPost(Name = "AddFloodZone")]
        public async Task<IActionResult> CreateFloodZone([FromBody] FloodZoneDTO floodZone)
        {
            if (floodZone == null)
                return BadRequest("FloodZone object is null");

            var createdFloodZone = await _service.FloodZone.CreateFloodZoneAsync(floodZone);
         
            return Ok(createdFloodZone);
        }

        [HttpGet(Name = "GetFloodZones")]
        public async Task<IActionResult> GetFloodZones()
        {
            var floodZones = await _service.FloodZone.GetFloodZonesAsync(trackChanges: false);
            return Ok(floodZones);
        }
    }
}
