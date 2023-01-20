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
   public class LocationService : ILocationService
   {
      private readonly InventoryManagementContext _context;
      private readonly IMapper _mapper;

      public LocationService(InventoryManagementContext context, IMapper mapper)
      {
         _context = context;
         _mapper = mapper;
      }

      public async Task<LocationVM> GetLocationById(Guid guid)
      {
         Location? location= await _context.Location.FindAsync(guid);
         LocationVM locationVM = new LocationVM();
         if (location != null)
         {
            locationVM = _mapper.Map<Location, LocationVM>(location);
         }

         return locationVM;
      }

      public async Task<LocationVM> AddLocation(LocationCreateVM locationCreate)
      {

         Location location = _mapper.Map<Location>(locationCreate);
         _context.Location.Add(location);
         await _context.SaveChangesAsync();

         LocationVM result = _mapper.Map<LocationVM>(location);
         return result;

      }

   }
}
