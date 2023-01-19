using AutoMapper;
using Data.Entities;
using Models.ViewModels;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
   public class EquipmentService: IEquipmentService
   {
      private readonly InventoryManagementContext _context;
      private readonly IMapper _mapper;

      public EquipmentService(InventoryManagementContext context, IMapper mapper)
      {
         _context = context;
         _mapper = mapper;
      }

      public async Task<EquipmentVM> GetEquipmentById(Guid guid)
      {
         Equipment? equipment = await _context.Equipment.FindAsync(guid);
         EquipmentVM equipmentVM = new EquipmentVM();
         if (equipment != null)
         {
            equipmentVM = _mapper.Map<Equipment, EquipmentVM>(equipment);
         }

         return equipmentVM;
      }


   }
}
