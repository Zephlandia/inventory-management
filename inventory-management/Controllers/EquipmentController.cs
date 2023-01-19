using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Services.Services;

namespace inventory_management.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class EquipmentController : Controller
   {
      private readonly ILogger<EquipmentController> _logger;
      private readonly EquipmentService _equipmentService;


      public EquipmentController(ILogger<EquipmentController> logger, EquipmentService equipmentService)
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
   }
}
