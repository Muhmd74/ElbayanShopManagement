using ElbayanServices.Repository.Products.Product.Dtos;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Product.AllProduct
{
    public interface IViewAllProduct
    {
        Guna2TextBox SearchKeyword { get; set; }
        DataGridView ActiveObject { get; set; }
        DataGridView DeletedObject { get; set; }
        AllProductPresenter Presenter { set; }
    }
}
