using AutoMapper;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Models.ViewModels;
using Services.Interfaces;


namespace Services.Services
{
   public class EquipmentTypeService : IEquipmentTypeService
   {
      private readonly InventoryManagementContext _context;
      private readonly IMapper _mapper;

      public EquipmentTypeService(InventoryManagementContext context, IMapper mapper)
      {
         _context = context;
         _mapper = mapper;
      }

      //public IQueryable<EquipmentTypeVM>? GetTypeById(Guid guid)
      //{
      //   IQueryable<EquipmentType>? type = _context.EquipmentType.Where(x => x.EquipmentTypeId == guid);
      //   if (type != null)
      //   {
      //      var result = _mapper.Map<IEnumerable<EquipmentType>, IEnumerable<EquipmentTypeVM>>(type);
      //      return result.AsQueryable();
      //   }

      //   return null;
      //}

      //public IEnumerable<EquipmentType> GetAllEquipmentType()
      //{
      //   return _context.EquipmentType.AsQueryable();
      //}


      //public IQueryable<EquipmentTypeVM>? GetAllTypes()
      //{
      //   IQueryable<EquipmentType>? type = _context.EquipmentType;
      //   if (type != null)
      //   {
      //      var result = _mapper.Map<IEnumerable<EquipmentType>, IEnumerable<EquipmentTypeVM>>(type);
      //      return result.AsQueryable();
      //   }

      //   return null;
      //}

      //public async Task<EquipmentTypeVM> AddType(EquipmentTypeCreateVM TypeCreate)
      //{

      //   EquipmentType type = _mapper.Map<EquipmentType>(TypeCreate);
      //   _context.EquipmentType.Add(type);
      //   await _context.SaveChangesAsync();

      //   EquipmentTypeVM result = _mapper.Map<EquipmentTypeVM>(type);
      //   return result;

      //}

      //public async Task<Models.ViewModels.EquipmentTypeVM> UpdateType(EquipmentTypeCreateVM typeCreate)
      //{
      //   if (typeCreate == null)
      //      throw new ArgumentNullException("Null object");

      //   if (string.IsNullOrEmpty(typeCreate.Name))
      //      throw new ArgumentNullException("Name is null or empty");

      //   EquipmentType type = _mapper.Map<EquipmentType>(typeCreate);
      //   _context.EquipmentType.Add(type);
      //   await _context.SaveChangesAsync();

      //   EquipmentTypeVM result = _mapper.Map<EquipmentTypeVM>(type);
      //   return result;

      //}

      //public async Task UpdateType(Guid guid, EquipmentTypeUpdateVM typeUpdateDto)
      //{
      //   if (typeUpdateDto == null)
      //      throw new ArgumentNullException("Null object");

      //   if(string.IsNullOrEmpty(typeUpdateDto.Name))
      //      throw new ArgumentNullException("Name is null or empty");

      //   var type = _mapper.Map<EquipmentTypeVM>(typeUpdateDto);
      //   type.EquipmentTypeId = guid;
      //   _context.Entry(type).State = EntityState.Modified;

      //   try
      //   {
      //      await _context.SaveChangesAsync();
      //   }
      //   catch (DbUpdateConcurrencyException)
      //   {         
      //      throw new Exception();           
      //   }
      //}

      //public async Task DeleteType(Guid guid)
      //{
      //   var type = await _context.EquipmentType.FindAsync(guid);
      //   if (type == null)
      //      throw new KeyNotFoundException("Not found.");

      //   _context.EquipmentType.Remove(type);
      //   await _context.SaveChangesAsync();

      //}



   }
}
