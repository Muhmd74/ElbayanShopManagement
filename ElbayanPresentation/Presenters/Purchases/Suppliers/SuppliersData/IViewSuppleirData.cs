using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.Suppliers.SuplliersData
{
    public interface IViewSuppleirData
    {
        Guna2TextBox SuppliersName { get; set; }
        Guna2TextBox SuppleirIdNumber { get; set; }
        Guna2TextBox FirmName { get; set; }
        Guna2TextBox Address { get; set; }
        Guna2TextBox CommercialRegister { get; set; }
        Guna2TextBox SupplierNumber { get; set; }
        Guna2TextBox Description  { get; set; }
        Guna2ComboBox CustomerType { get; set; }
        Guna2TextBox Mobile { get; set; }
        Guna2TextBox IDNumber { get; set; }
        Guna2TextBox TaxNumber { get; set; }
        Guna2TextBox SearchtxtBox { get; set; }
        NumericUpDown OpeningBalance { get; set; }

        RadioButton IsActiveSupplier { get; set; }
        DataGridView ActiveObject { get; set; }
        DataGridView DeletedObject { get; set; }
        TabControl tabControl { get; set; }

        Guna2Button btnAddNewObject { get; set; }
        Guna2Button btnUpdateObject { get; set; }
        Guna2Button btnDeleteObject { get; set; }


        PresenterSupplierData Presenter { get; set; }


    }
}
