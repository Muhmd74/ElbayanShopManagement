using ElbayanServices.Repository.Products.Units.LargeUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Unit.LargeUnit
{
    public class LargeUnitPresenter
    {
        private readonly IViewLargeUnit _view;
        private readonly LargeUnitService largeUnit = new LargeUnitService(new ElbayanDatabase.ConnectionTools.ConnectionOption());


        public LargeUnitPresenter(IViewLargeUnit view)
        {
            _view = view;
        }

        public void AddNewUnit()
        {
            largeUnit.Add(new ElbayanServices.Repository.Products.Units.LargeUnit.Dtos.LargeUnitDto
            {
                Name = _view.LargeUnitName,
                Description = _view.LargeUnitDescirption
            });
        }

    }
}
