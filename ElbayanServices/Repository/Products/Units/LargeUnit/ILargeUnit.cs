using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;

namespace ElbayanServices.Repository.Products.Units.LargeUnit
{
    public interface ILargeUnit
    {
        bool Add(LargeUnitDto model);
        bool Update(LargeUnitDto model);

        bool DeleteOrRestore(Guid id);
        List<LargeUnitDto> GetAllLargeUnit();
        LargeUnitDto Get(Guid id);

    }
}
