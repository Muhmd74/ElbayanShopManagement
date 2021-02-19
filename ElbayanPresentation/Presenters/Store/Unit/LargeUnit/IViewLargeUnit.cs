using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Unit.LargeUnit
{
    public interface IViewLargeUnit
    {
        string LargeUnitName { get; set; }
        string LargeUnitDescirption { get; set; }

        string SearchKeyword { get; set; }

        List<LargeUnitDto> LargeUnit { get; set; }

        LargeUnitPresenter Presenter { set; }
    }
}
