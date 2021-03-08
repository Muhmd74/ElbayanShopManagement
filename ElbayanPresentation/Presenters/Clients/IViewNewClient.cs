using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Clients
{
    public interface IViewNewClient
    {
        Guid ID { get; set; }
        Guna2TextBox RefSupplierNumber { get; set; }
        Guna2TextBox SuppliersName { get; set; }
        Guna2TextBox IdentityNumber { get; set; }
        Guna2TextBox Mobile { get; set; }
        Guna2TextBox Fax { get; set; }
        Guna2TextBox Email { get; set; }
        Guna2TextBox FirmName { get; set; }
        Guna2TextBox TradeLicense { get; set; }
        Guna2TextBox TaxNumber { get; set; }
        Guna2TextBox FirmPhoneNumber { get; set; }
        Guna2TextBox Address { get; set; }
        Guna2TextBox Note { get; set; }
        CheckBox IsActive { get; set; }
        NumericUpDown OpeningBalance { get; set; }
        NumericUpDown CurrentBalance { get; set; }
        Guna2Button AddNewObject { get; set; }
        Guna2Button UpdateObject { get; set; }
        Guna2Button DeleteObject { get; set; }
        Guna2Button BackToUc { get; set; }
        PresenterNewClient Presenter { get; set; }
    }
}
