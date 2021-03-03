using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Customers.Building.Dtos;

namespace ElbayanServices.Repository.Customers.Building
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
