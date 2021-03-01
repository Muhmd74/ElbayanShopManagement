using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.Poses.Dtos;

namespace ElbayanServices.Repository.Customers.Poses
{
   public interface IPos
   {
       bool Create(PosDto model);
       bool Update(PosDto model);
       List<PosDetailsDto> GetAll();
       List<BuildingNameDto> GetBuilding();
       PosDto GetById(Guid id);
   }
}
