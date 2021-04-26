using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ElbayanServices.Repository.Suppliers.OrderProcurement.Dtos;

namespace ElbayaNPresentation.Presenters.Orders
{
    public interface IPresenterOrder
    {
        string PopulateUser();
        void PopulateClient(ComboBox cbxSupplier);
        void NewSupplier_OnCLick(object sender, EventArgs e);
        void PrintInvioce(Guid iD);
        List<OrderProductDto> GetOrderProducts(DataGridView OrderProduct);
        void PopulateQualityEdit(DataGridView OrderProduct);
        void AddProductToDGV(Guid ID, DataGridView OrderProduct, decimal LastPrice);
        ElbayanServices.Repository.Products.Product.Dtos.ProductDto GetProductID(Guna2TextBox BareCode);
        void DeleteFromDGV(DataGridView OrderProduct);
        void AddProductToDGVbtn(Guid ID, DataGridView OrderProduct, decimal LastPrice);
        void GetProduct(ElbayanServices.Repository.Products.Product.Dtos.ProductDto model, DataGridView OrderProduct, decimal LastPrice);
        void SelectLastRow(DataGridView OrderProduct);
        void cbxSupplier_SelectionChangeCommitted(object sender, EventArgs e);

    }
}
