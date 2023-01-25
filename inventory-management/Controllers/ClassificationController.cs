using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Models.ViewModels;
using Services.Interfaces;

namespace inventory_management.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class ClassificationController : Controller
   {

      private readonly ILogger<ClassificationController> _logger;
      private readonly InventoryManagementContext _context;


      public ClassificationController(ILogger<ClassificationController> logger, InventoryManagementContext context)
      {
         _logger = logger;
         _context = context;
      }


//      EquipmentTypeId Name
//DECF3D1C-9FAC-4AC8-25E3-08DAFA8F0669 Office
//EF814D77-E944-41D9-25E4-08DAFA8F0669 Field
//B767815F-4918-4486-25E5-08DAFA8F0669 Shop

      [HttpGet]
      [EnableQuery]
      public ActionResult Get()
      {
         return Ok(_context.Classification);

      }

      [HttpGet("{guid}")]
      [EnableQuery]

      public ActionResult Get(Guid key)
      {
         return Ok(_context.Classification.Where(x => x.ClassificationId == key));

      }
   }
}
