using ElbayanServices.Repository.Products.Category.Dtos;
using ElbayanServices.Repository.Products.SubCategory.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Category.SubCategory
{
    public interface IViewSubCategory
    {
        Guid ID { get; set; }
        Guna2TextBox SubCategoryName { get; set; }
        Guna2TextBox SubCategoryDescription { get; set; }
        Guna2TextBox SearchtxtBox { get; set; }
        Guna2ComboBox MainCategory { get; set; }
        Guna2Button AddObject { get; set; }
        Guna2Button UpdateObject { get; set; }
        Guna2Button DeleteObject { get; set; }
        DataGridView ActiveObject { get; set; }
        DataGridView DeletectObject { get; set; }
        SubCategoryPresenter Presenter { get;  set; }
        TabControl TabControlDGV { get; set; }
    }
}
