using ElbayanServices.Repository.Products.Category.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Category.MainCategory
{
    public interface IViewMainCategory
    {
        Guid ID { get; set; }
        Guna2TextBox MainCategoryName { get; set; }
        Guna2TextBox MainCategoryDescription { get; set; }
        Guna2TextBox SearchBox { get; set; }

        Guna2Button AddNewObject { get; set; }
        Guna2Button UpdateObject { get; set; }
        Guna2Button DeleteObject { get; set; }
        TabControl dgvTabControl { get; set; }
        DataGridView ActiveObjects { get; set; }
        DataGridView DeletedObjects { get; set; }

        MainCategoryPresenter Presenter { set; }
    }
}
