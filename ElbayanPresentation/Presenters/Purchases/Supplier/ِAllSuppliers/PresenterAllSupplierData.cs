using System.Linq;
using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Presenters.Purchases.Suppliers.SuplliersData;
using ElbayaNPresentation.Views.Client.Suppliers.SupplierData;
using ElbayanServices.Repository.Clints.Supplier;

namespace ElbayaNPresentation.Presenters.Purchases.Supplier._ِAllSuppliers
{
    public class PresenterSupplierData
    {
        private readonly IViewAllSuppleir _view;
        private readonly SupplierService supplierService = new SupplierService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public PresenterSupplierData(IViewAllSuppleir view)
        {
            _view = view;
        }
        public void OnLoadUC()
        {
            DataGridViewStyle.StyleDatagridview(_view.ActiveObject);
            DataGridViewStyle.StyleDatagridview(_view.DeletedObject);

            //// Load Data Grid:
            PopualteActiveObjects();
            PopulateDeletedObject();

        }

        // Populate All Builing objects in Data Grid View
        // 2- Read:
        public void PopualteActiveObjects()
        {
            _view.ActiveObject.DataSource = supplierService.GetAllSupplier().ToList();
        }
        public void PopulateDeletedObject()
        {
            _view.DeletedObject.DataSource = supplierService.GetAllSupplierNotActive().ToList();
        }

        public void OnClickbtnAddNewObject()
        {
            //frmNewSupplier.Instance.ShowDialog();
        }
       
        // Search ->
        public void OnTextChnagedtxtSearch()
        {
            //if (_view.tabControl.SelectedIndex == 0)
            //{
            //    _view.ActiveObject.DataSource = supplierService.GetAllCustomer().
            //         Where(d => d.Name.Contains(_view.SearchtxtBox.Text)
            //         || d.SupplierNumber.ToString().Contains(_view.SearchtxtBox.Text)).ToList();
            //}
            //else
            //{
            //    _view.DeletedObject.DataSource = supplierService.GetAllCustomerNotActive().
            //        Where(d => d.Name.Contains(_view.SearchtxtBox.Text)
            //        || d.SupplierNumber.ToString().Contains(_view.SearchtxtBox.Text)).ToList();
            //}
        }

    }
}
