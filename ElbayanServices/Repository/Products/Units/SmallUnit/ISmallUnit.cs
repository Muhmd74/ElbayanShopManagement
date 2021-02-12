using System;
using System.Collections.Generic;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;

namespace ElbayanServices.Repository.Products.Units.SmallUnit
{
    public interface ISmallUnit
    {
        bool Add(SmallUnitDto model);
        bool Update(SmallUnitDto model);

        bool DeleteOrRestore(Guid id);
        List<SmallUnitDto> GetAllSmallUnit();
        SmallUnitDto Get(Guid id);

    }
}
