using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Clints.Customer;
using ElbayanServices.Repository.Suppliers.Supplier;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.CommonPresenter
{
    public class PopulateActiveClients
    {
        private static readonly SupplierService _supplier = new SupplierService(new ConnectionOption());
        private static readonly CustomerService _customer = new CustomerService(new ConnectionOption());
        public static void PopulateSuppliers(ComboBox activeSupplier)
        {
            activeSupplier.DataSource = _supplier.GetAllSupplier();
            activeSupplier.DisplayMember = "Name";
            activeSupplier.ValueMember = "Id";
            activeSupplier.SelectedIndex = -1;
            activeSupplier.SelectedValue = "Id";
        } 
        public static void PopulateCustomers(ComboBox activeCustomer)
        {
            activeCustomer.DataSource = _customer.GetAllCustomer();
            activeCustomer.DisplayMember = "Name";
            activeCustomer.ValueMember = "Id";
            activeCustomer.SelectedIndex = -1;
            activeCustomer.SelectedValue = "Id";
        }
    }

}
