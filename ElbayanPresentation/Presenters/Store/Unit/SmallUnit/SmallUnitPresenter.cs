using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Units.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
using ElbayanServices.Repository.Products.Units.SmallUnit;
using ElbayanServices.Repository.Products.Units.SmallUnit.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Unit.SmallUnit
{
    public class SmallUnitPresenter
    {
        private readonly IViewSmallUnit _view;

        private readonly SmallService smallUnit = new SmallService(new ConnectionOption());

        private readonly LargeUnitService largeUnitServices = new LargeUnitService(new ConnectionOption());

        public SmallUnitPresenter(IViewSmallUnit view)
        {
            _view = view;
        }

        public List<LargeUnitDto> FillcbxLargeUnit()
        {
            _view.LargeUnit = largeUnitServices.GetAllLargeUnit();
            return _view.LargeUnit.ToList();
        }

        public List<SmallUnitDto> GetAllSubCategory()
        {
            _view.SmallUnits = smallUnit.GetAllSmallUnit();
            return _view.SmallUnits.ToList();
        }
        public List<SmallUnitDto> GetAllDeletedSubCategory()
        {
            _view.SmallUnits = smallUnit.GetAllSmallUnitDeleted();
            return _view.SmallUnits.ToList();
        }

        public void OnClickbtnAdd()
        {
            smallUnit.Add(new SmallUnitDto
            {
                Name = _view.Name,
                Description = _view.Description,
                
            });
        }
    }
}
