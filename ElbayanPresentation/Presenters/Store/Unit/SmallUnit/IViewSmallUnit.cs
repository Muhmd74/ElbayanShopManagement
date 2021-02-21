using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Unit.SmallUnit
{
    public interface IViewSmallUnit
    {
        Guid SmallUnitID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        decimal Weight { get; set; }

        string SearchKeyword { get; set; }
        Guid LargeUnitID { get; set; }
        string LargeUnitName { get; set; }
        List<SmallUnitDto> SmallUnits { get; set; }
        List<LargeUnitDto> LargeUnit { get; set; }
        SmallUnitPresenter Presenter { set; }
    }

}
