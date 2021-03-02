using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Customers.Building;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Store.Building
{
    public class BuildingPresenter
    {
        private readonly IViewBuilding _view;
        private readonly BuildingService buildingService = new BuildingService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public BuildingPresenter(IViewBuilding view)
        {
            _view = view;
        }

        public void OnloadUCBuilding()
        {
            DataGridViewStyle.StyleDatagridview(_view.dgvActiveObjects);
            DataGridViewStyle.StyleDatagridview(_view.dgvDeletedObjects);

            // Load Data Grid:
            PopualteActiveObjects();
            PopulateDeletedObject();
        }

        // Populate All Builing objects in Data Grid View
        public void PopualteActiveObjects()
        {
            _view.dgvActiveObjects.DataSource = buildingService.GetAllBuilding().ToList();
        }
        public void PopulateDeletedObject()
        {
            // _view.dgvDeletedObjects.DataSource = buildingService.GetAllBuilding().ToList();
        }
    }
}
