using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Employees.Poses.Dtos;

namespace ElbayanServices.Repository.Employees.Poses
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
