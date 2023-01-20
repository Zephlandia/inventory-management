using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;
using Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace inventory_management.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class TypeController : Controller
   {
      private readonly ILogger<TypeController> _logger;
      private readonly ITypeService _typeService;


      public TypeController(ILogger<TypeController> logger, ITypeService typeService)
      {
         _logger = logger;
         _typeService = typeService;
      }

      [HttpGet("{guid}")]
      [ProducesResponseType(StatusCodes.Status404NotFound)]

      public async Task<ActionResult<TypeVM>> GetType(Guid guid)
      {
         TypeVM? TypeVM = await _typeService.GetTypeById(guid);
         if (TypeVM == null)
            return NotFound();

         return TypeVM;
      }

      [HttpPost]
      public async Task<ActionResult<TypeVM>> CreateType([FromBody] TypeCreateVM Type)
      {
         try
         {

            var typeReturned = await _typeService.AddType(Type);
            //return TypeReturned;
            return CreatedAtAction("GetType", new { guid = typeReturned.TypeId }, typeReturned.TypeId);
         }
         catch (ArgumentNullException e)
         {
            _logger.LogWarning(e.Message);
            return BadRequest(e.Message);
         }
         catch (Exception e)
         {
            _logger.LogError(e.Message);
            throw new Exception("Creating Type failed.");
         }
      }

      [HttpPut("{guid}")]
      public async Task<IActionResult> UpdateType(Guid guid, [FromBody] TypeUpdateVM type)
      {
         try
         {
            await _typeService.UpdateType(guid, type);
            return NoContent();
         }
         catch (ArgumentNullException e)
         {
            _logger.LogWarning(e.Message);
            return BadRequest(e.Message);
         }
         catch (ArgumentOutOfRangeException e)
         {
            _logger.LogWarning(e.Message);
            return new UnprocessableEntityObjectResult(e.Message);
         }
         catch (KeyNotFoundException e)
         {
            _logger.LogWarning(e.Message);
            return NotFound(e.Message);
         }
         catch (Exception e)
         {
            _logger.LogError(e.Message);
            throw new Exception($"Upating Type with guid: {guid} failed.");
         }
      }

      [HttpDelete("{guid}")]
      public async Task<ActionResult> DeleteCustomer(Guid guid)
      {
         try
         {
            await _typeService.DeleteType(guid);
            return NoContent();
         }
         catch (KeyNotFoundException e)
         {
            _logger.LogWarning(e.Message);
            return NotFound(e.Message);
         }
         catch (Exception e)
         {
            _logger.LogError(e.Message);
            throw new Exception($"Deleting TYpe with id {guid} failed.");
         }
      }


   }
}
