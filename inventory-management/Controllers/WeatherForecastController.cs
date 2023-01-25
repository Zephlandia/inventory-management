using Data.Entities;
using inventory_management.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Interfaces;

namespace inventory_management.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class WeatherForecastController : ControllerBase
   {
      private static readonly string[] Summaries = new[]
      {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
      };

      private readonly ILogger<WeatherForecastController> _logger;

      public WeatherForecastController(ILogger<WeatherForecastController> logger)
      {
         _logger = logger;
      }

      [EnableQuery]
      [HttpGet]
      public IEnumerable<WeatherForecast> Get()
      {
         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
         {
            WeatherForecastId = Guid.NewGuid(),
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
         })
         .ToArray();
      }
   }
}


//private readonly ILogger<EquipmentTypeController> _logger;
//private readonly IEquipmentTypeService _typeService;


//public EquipmentTypeController(ILogger<EquipmentTypeController> logger, IEquipmentTypeService typeService)
//{
//   _logger = logger;
//   _typeService = typeService;
//}

//[EnableQuery(PageSize = 2)]
//[HttpGet]
//public ActionResult<IQueryable<Type>> GetAllTypes()
//{
//   var typeVM = _typeService.GetAllTypes();
//   if (typeVM == null)
//      return NotFound();

//   return Ok(typeVM);
//}



//[EnableQuery]
//[HttpGet]
//public IEnumerable<EquipmentType> GetAllTypes()
//{
//   return _typeService.GetAllEquipmentType();

//}

//[EnableQuery]
//[HttpGet("{key}")]
//public IActionResult GetType(Guid key)
//{
//   return Ok();
//}

//   [EnableQuery]
//[HttpGet("{key}")]
//public IActionResult GetType(Guid key)
//{
//   var typeVM = _typeService.GetTypeById(key);
//   if (typeVM == null)
//      return NotFound();

//   return Ok(SingleResult.Create<TypeVM?>(typeVM));
//}



//[HttpPost]
//public async Task<ActionResult<TypeVM>> CreateType([FromBody] TypeCreateVM Type)
//{
//   try
//   {
//      var typeReturned = await _typeService.AddType(Type);
//      return CreatedAtAction("GetType", new { guid = typeReturned.TypeId }, typeReturned.TypeId);
//   }
//   catch (ArgumentNullException e)
//   {
//      _logger.LogWarning(e.Message);
//      return BadRequest(e.Message);
//   }
//   catch (Exception e)
//   {
//      _logger.LogError(e.Message);
//      throw new Exception("Creating Type failed.");
//   }
//}

//[HttpPut("{guid}")]
//public async Task<IActionResult> UpdateType(Guid guid, [FromBody] TypeUpdateVM type)
//{
//   try
//   {
//      await _typeService.UpdateType(guid, type);
//      return NoContent();
//   }
//   catch (ArgumentNullException e)
//   {
//      _logger.LogWarning(e.Message);
//      return BadRequest(e.Message);
//   }
//   catch (Exception e)
//   {
//      _logger.LogError(e.Message);
//      throw new Exception($"Upating Type with guid: {guid} failed.");
//   }
//}

//[HttpDelete("{guid}")]
//public async Task<ActionResult> DeleteCustomer(Guid guid)
//{
//   try
//   {
//      await _typeService.DeleteType(guid);
//      return NoContent();
//   }
//   catch (KeyNotFoundException e)
//   {
//      _logger.LogWarning(e.Message);
//      return NotFound(e.Message);
//   }
//   catch (Exception e)
//   {
//      _logger.LogError(e.Message);
//      throw new Exception($"Deleting Type with id {guid} failed.");
//   }
//}