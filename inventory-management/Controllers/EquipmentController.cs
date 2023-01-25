using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Models.ViewModels;
using Services.Interfaces;
using Services.Services;

namespace inventory_management.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class EquipmentController : Controller
   {
      private readonly ILogger<EquipmentController> _logger;
      private readonly IEquipmentService _equipmentService;


      public EquipmentController(ILogger<EquipmentController> logger, IEquipmentService equipmentService)
      {
         _logger = logger;
         _equipmentService = equipmentService;
      }

      [HttpGet("{guid}")]
      [ProducesResponseType(StatusCodes.Status404NotFound)]

      public async Task<ActionResult<EquipmentVM>> Get(Guid guid)
      {
         EquipmentVM equipmentVM = await _equipmentService.GetEquipmentById(guid);
         if (equipmentVM == null)
            return NotFound();
         
         return equipmentVM;
      }


      [HttpPost]
      public async Task<ActionResult<EquipmentVM>> CreateEquipment([FromBody] EquipmentCreateVM equipment)
      {
         try
         {
            
            var equipmentReturned = await _equipmentService.AddEquipment(equipment);
            return equipmentReturned;
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
            throw new Exception("Creating Customer failed.");
         }

      }
   }
}
