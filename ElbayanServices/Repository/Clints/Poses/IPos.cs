using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Clints.Poses.Dtos;

namespace ElbayanServices.Repository.Clints.Poses
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
