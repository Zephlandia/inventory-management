using AutoMapper;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Models.ViewModels;
using Services.Interfaces;

using Type = Data.Entities.Type;

namespace Services.Services
{
   public class TypeService : ITypeService
   {
      private readonly InventoryManagementContext _context;
      private readonly IMapper _mapper;

      public TypeService(InventoryManagementContext context, IMapper mapper)
      {
         _context = context;
         _mapper = mapper;
      }

      public async Task<TypeVM?> GetTypeById(Guid guid)
      {
         Type? type = await _context.Type.FindAsync(guid);
         if (type != null)
         {
            return _mapper.Map<Type, TypeVM>(type);
         }

         return null;
      }

      public async Task<TypeVM> AddType(TypeCreateVM TypeCreate)
      {

         Type Type = _mapper.Map<Type>(TypeCreate);
         _context.Type.Add(Type);
         await _context.SaveChangesAsync();

         TypeVM result = _mapper.Map<TypeVM>(Type);
         return result;

      }

      public async Task<TypeVM> UpdateType(TypeCreateVM TypeCreate)
      {

         Type Type = _mapper.Map<Type>(TypeCreate);
         _context.Type.Add(Type);
         await _context.SaveChangesAsync();

         TypeVM result = _mapper.Map<TypeVM>(Type);
         return result;

      }

      public async Task UpdateType(Guid guid, TypeUpdateVM typeUpdateDto)
      {
         if (typeUpdateDto == null)
            throw new ArgumentNullException("Customer entity");

         var type = _mapper.Map<Type>(typeUpdateDto);
         type.TypeId = guid;
         _context.Entry(type).State = EntityState.Modified;

         try
         {
            await _context.SaveChangesAsync();
         }
         catch (DbUpdateConcurrencyException)
         {         
            throw new Exception();           
         }
      }

      public async Task DeleteType(Guid guid)
      {
         var type = await _context.Type.FindAsync(guid);
         if (type == null)
            throw new KeyNotFoundException("Not found.");

         _context.Type.Remove(type);
         await _context.SaveChangesAsync();

      }



   }
}
