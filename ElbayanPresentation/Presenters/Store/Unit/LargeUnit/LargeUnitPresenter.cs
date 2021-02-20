using ElbayanServices.Repository.Products.Units.LargeUnit;
using ElbayanServices.Repository.Products.Units.LargeUnit.Dtos;
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
            largeUnit.Add(new LargeUnitDto
            {
                Name = _view.LargeUnitName,
                Description = _view.LargeUnitDescirption
            });
        }

        public List<LargeUnitDto> GetAllLargeUnit()
        {
            //if (!largeUnit.GetAllLargeUnit().Any())
            //{
                 _view.LargeUnit = largeUnit.GetAllLargeUnit();
            //}

            return _view.LargeUnit.ToList();
        }

        public void OnClickUpdatebtn(Guid ID)
        {
            largeUnit.Update(new LargeUnitDto
            {
                Id = ID,
                Name = _view.LargeUnitName,
                Description = _view.LargeUnitDescirption
            });
        }

        public List<LargeUnitDto> GetAllDeltetdUnits()
        {
            _view.LargeUnit =  largeUnit.GetAllLargeUnitDeleted();

            return _view.LargeUnit.ToList();
        }

        public void DeletedOrRestore(Guid ID)
        {
            largeUnit.DeleteOrRestore(ID);
        }

        public List<LargeUnitDto> FilterDataGridView()
        {
            _view.LargeUnit = largeUnit.GetAllLargeUnit().Where(x => x.Name.Contains(_view.SearchKeyword) || x.Description.Contains(_view.SearchKeyword)).ToList();
            return _view.LargeUnit.ToList();
        }     
        public List<LargeUnitDto> FilterDataGridViewDeleted()
        {
            _view.LargeUnit = largeUnit.GetAllLargeUnitDeleted().Where(x => x.Name.Contains(_view.SearchKeyword) || x.Description.Contains(_view.SearchKeyword)).ToList();
            return _view.LargeUnit.ToList();
        }
    }
}
