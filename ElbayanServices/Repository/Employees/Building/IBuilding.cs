using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Employees.Building.Dtos;

namespace ElbayanServices.Repository.Employees.Building
{
    public interface IBuilding
    {
        bool Create(BuildingDto model);
        bool Update(BuildingDto model);
        BuildingDto GetById(Guid id);
        List<BuildingDto> GetAllBuilding();
        List<BuildingDto> GetAllBuildingDeleted();
        bool DeleteOrRestore(Guid id);
    }
}
