using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Models.ViewModels;
using Services.Interfaces;

namespace inventory_management.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class LocationController : Controller
   {
      private readonly ILogger<LocationController> _logger;
      private readonly ILocationService _locationService;


      public LocationController(ILogger<LocationController> logger, ILocationService locationService)
      {
         _logger = logger;
         _locationService = locationService;
      }

      [EnableQuery]
      [HttpGet("{guid}")]
      public async Task<ActionResult<EquipmentVM>> Get(Guid guid)
      {
         LocationVM locationVM = await _locationService.GetLocationById(guid);
         if (locationVM == null)
            return NotFound();

         return Ok(locationVM);
      }


      [HttpPost]
      public async Task<ActionResult<LocationVM>> CreateLocation([FromBody] LocationCreateVM location)
      {
         try
         {

            var locationReturned = await _locationService.AddLocation(location);
            return locationReturned;
            //return CreatedAtAction("GetCustomer", new { guid = equipmentReturned.EquipmentId, version = apiVersion.ToString() }, equipmentReturned.EquipmentId);
         }
         catch (ArgumentNullException e)
         {
            _logger.LogWarning(e.Message);
            return BadRequest(e.Message);
         }
         catch (Exception e)
         {
            _logger.LogError(e.Message);
            throw new Exception("Creating Location failed.");
         }

      }
   }
}
