using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Suppliers.Supplier;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.CommonPresenter
{
    public class PopulateActiveSuppliers
    {
        private static SupplierService Supplier = new SupplierService(new ConnectionOption());
        public static void PopulateSuppliers(ComboBox activeSupplier)
        {
            activeSupplier.DataSource = Supplier.GetAllSupplier();
            activeSupplier.DisplayMember = "Name";
            activeSupplier.ValueMember = "Id";
            activeSupplier.SelectedIndex = -1;
            activeSupplier.SelectedValue = "Id";
        }
    }

}
