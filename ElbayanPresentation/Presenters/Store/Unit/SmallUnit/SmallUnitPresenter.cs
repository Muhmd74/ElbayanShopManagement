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

        public List<SmallUnitDto> GetAllSmallUnit()
        {
            _view.SmallUnits = smallUnit.GetAllSmallUnit();
            return _view.SmallUnits.ToList();
        }
        public List<SmallUnitDto> GetAllSmallUnitDeleted()
        {
            _view.SmallUnits = smallUnit.GetAllSmallUnitDeleted();
            return _view.SmallUnits.ToList();
        }

        public void OnClickbtnAdd()
        {
            smallUnit.Add(new SmallUnitDto
            {
                Name = _view.SmallUnitName,
                Description = _view.Description,
                Weight = _view.Weight.ToString(),
                LargeUnitId = _view.LargeUnitID                
            });
        }
        public void OnclickUpdate(Guid ID, Guid LargeUnitID)
        {
            smallUnit.Update( new SmallUnitDto
            {
                Id = ID,
                Name = _view.SmallUnitName,
                Description = _view.Description,
                LargeUnitId = LargeUnitID,
                Weight = _view.Weight.ToString()
            });
        }

        public void onClickbtnDelete(Guid ID)
        {
            smallUnit.DeleteOrRestore(ID);
            
        }

        public List<SmallUnitDto> FilterDataGridView()
        {
            return _view.SmallUnits = smallUnit.GetAllSmallUnit().Where(d => d.Name.Contains(_view.SearchKeyword) || d.LargeUnitName.Contains(_view.SearchKeyword)).ToList();
        }
        public List<SmallUnitDto> FilterDataGridViewDeleted()
        {
            return _view.SmallUnits = smallUnit.GetAllSmallUnitDeleted().Where(d => d.Name.Contains(_view.SearchKeyword) || d.LargeUnitName.Contains(_view.SearchKeyword)).ToList();
        }

    }
}
