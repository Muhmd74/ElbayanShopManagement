using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayaNPresentation.Views.Client;
using ElbayanServices.Repository.Clints.OrderProcurement;
using ElbayanServices.Repository.Clints.OrderProcurement.Dtos;
using ElbayanServices.Repository.Clints.Supplier;
using ElbayanServices.Repository.Products.Product;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Purchases.ProcurementOrder
{
    public class PresenterProcurementOrder
    {
        private readonly IViewProcurementOrder _view;
        private readonly OrderProcurementService orderProcuremnt = new OrderProcurementService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        private readonly SupplierService Supplier = new SupplierService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        private readonly ProductService Product = new ProductService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterProcurementOrder(IViewProcurementOrder view)
        {
            _view = view;
        }

        internal void OnLoad()
        {
            PopulateSuppliers();
            PopulateProducts();
            _view.OrderNumber.Text = orderProcuremnt.GenerateSequenceNumberSupplier().ToString();
        }

        private void PopulateProducts()
        {
            _view.Products.DisplayMember = "Name";
            _view.Products.ValueMember = "Id";
            _view.Products.SelectedValue = "Id";
            _view.Products.DataSource = Product.GetAll();
            _view.Products.Text = "أختر منتج";
            //_view.Suppliers.SelectedIndex = 0;
            //_view.Products.AutoCompleteMode = AutoCompleteMode.Suggest;
            //_view.Products.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //_view.Products.AutoCompleteCustomSource = new AutoCompleteStringCollection();

        }

        private void PopulateSuppliers()
        {
            _view.Suppliers.DisplayMember = "Name";
            _view.Suppliers.ValueMember = "Id";
            _view.Suppliers.SelectedValue = "Id";
            var model = Supplier.GetAllSupplier();
            _view.Suppliers.DataSource = model;
            _view.Suppliers.SelectedIndex = -1;
        }
        internal void NewSupplier_OnCLick()
        {
            frmNewClient.Instance.ShowDialog();
        }
        internal void CreateSupplierOrder()
        {
            if(_view.OrderProduct.Rows.Count >= 1)
            {
                if(_view.Suppliers.SelectedIndex == -1)
                {
                try
                {
                        orderProcuremnt.CreateSupplierOrder(new OrderDto
                        {
                            EmployeeId = new Guid("7b706e91-4784-eb11-84c2-80a5899d8326"),
                            IsDeferred = _view.IsDeferred.Checked,
                            Deferred = 0.0m,
                            DateTime = _view.OrderDate.Value,
                            Payment = Convert.ToDecimal(_view.TotalOrder.Text),
                            OrderNumber = long.Parse(_view.OrderNumber.Text),
                            ClintId = new Guid(_view.Suppliers.SelectedValue.ToString()),
                            DueDatePayingOff = _view.OrderDeferredDate.Value,
                            OrderProductDto = GetOrderProducts().ToList(),
                            TotalDiscount = 1,
                            SubTotalWithoutDiscount = 1,
                            TotalAfterDiscount = 1,
                            PosId = new Guid("90cd83b1-cf81-eb11-84c2-80a5899d8326"),
                        });
                        MessageBox.Show("DONE");
                        ClearControl();
                    
                }
                catch (Exception e) {
                        MessageBox.Show(e.InnerException.Message);
                    }
                }
                else
                {
                    MessageBox.Show("كرما أختر مورد أولا");
                    return;
                }
            }
            else
            {
                MessageBox.Show("كرما أضف منتجات للفاتورة أولا");
                return;
            }
        }
        private List<OrderProductDto> GetOrderProducts()
        {
            List<OrderProductDto> orderProducts = new List<OrderProductDto>();
            for(int i = 0; i <= _view.OrderProduct.Rows.Count -1; i++)
            {
                var orderProduct = new OrderProductDto()
                {
                    ProductId = new Guid(_view.OrderProduct.Rows[i].Cells["OrderProductId"].Value.ToString()),
                    ProductName = _view.OrderProduct.Rows[i].Cells["ProductName"].Value.ToString(),
                    Discount = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Discount"].Value),
                    PriceSale = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceIncVat"].Value),
                    SubTotalPrice = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["Subtotal"].Value),
                    OrderId = _view.ID,
                    Quantity = Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["Qunatity"].Value),
                    TotalPrice = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceIncVat"].Value),
                    TotalProductPrice = Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells["PriceIncVat"].Value),
                    Vat = Convert.ToInt32(_view.OrderProduct.Rows[i].Cells["PriceIncVat"].Value)
                };
                orderProducts.Add(orderProduct);
            }
            return orderProducts;


        }
        internal void AddProductToDGV()
        {
            if (string.IsNullOrWhiteSpace(_view.BareCode.Text) || string.IsNullOrEmpty(_view.BareCode.Text))
            {
                MessageBox.Show(" يجب ادخال رقم منتج أو باركود الشركة أو باركود دولي صحيح", "تأكيد");
                return;
            }
            if(_view.BareCode.Text.Trim() == string.Empty || _view.BareCode.Text.Trim().Length < 0)
            {
                MessageBox.Show("يجب ادخال رقم منتج أو باركود الشركة أو باركود دولي  صحيح", "تأكيد");
                return;
            }
            long? Barcode = NullableNumber.BarecodeNumber(_view.BareCode.Text);
            int? PSNumber = NullableNumber.ProductNumber(_view.BareCode.Text);
            int? UCP = NullableNumber.ProductNumber(_view.BareCode.Text);
            var model = Product.GetProductByBarcodeOrProductNumber(Barcode, PSNumber, UCP);
            if(model != null)
            {
                var index = _view.OrderProduct.Rows.Add();
                _view.OrderProduct.Rows[index].Cells["OrderProductId"].Value = model.Id.ToString();
                _view.OrderProduct.Rows[index].Cells["PSNumber"].Value = model.ProductNumber;
                _view.OrderProduct.Rows[index].Cells["ProductName"].Value = model.Name;
                _view.OrderProduct.Rows[index].Cells["Unit"].Value = model.IsMAinSalesUnit;
                _view.OrderProduct.Rows[index].Cells["Qunatity"].Value = 1;
                decimal PriceIncludeVAT = Convert.ToDecimal(model.PurchaseDefaultPrice + (model.PurchaseDefaultPrice * (model.Vat / 100)));
                _view.OrderProduct.Rows[index].Cells["PriceIncVat"].Value = PriceIncludeVAT;
                _view.OrderProduct.Rows[index].Cells["Discount"].Value = model.Discount;
                decimal SubtotalQuantity = Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["Qunatity"].Value)
                    * Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["PriceIncVat"].Value);
                decimal Subtotal = SubtotalQuantity - (model.PurchaseDefaultPrice * (model.Discount / 100));
                _view.OrderProduct.Rows[index].Cells["Subtotal"].Value = Subtotal;
                ClaculateTotalOrderAmount();
                SelectLastRow();
            }
            
        }
        internal void DeleteFromDGV()
        {
            if(_view.OrderProduct.Rows.Count >= 1)
            {
                int currentRow = _view.OrderProduct.SelectedRows[0].Index;
                _view.OrderProduct.Rows.RemoveAt(currentRow);
                if(_view.OrderProduct.Rows.Count <= 0)
                {
                    _view.TotalOrder.Text = "0.0";
                }
                ClaculateTotalOrderAmount();
                SelectLastRow();
            }
        }
        internal void AddProductToDGVbtn()
        {
            if(_view.Products.Text == "أختر منتج")
            {
                MessageBox.Show("يجب يجب اختيار منتج", "تأكيد");
                return;
            }
            if (_view.Products.Items.Count <= 0)
            {
                MessageBox.Show("يجب اختيار منتج", "تأكيد");
                return;
            }
            var model = Product.GetById(new Guid(_view.Products.SelectedValue.ToString()));
            var index = _view.OrderProduct.Rows.Add();
            _view.OrderProduct.Rows[index].Cells["OrderProductId"].Value = model.Id.ToString();
            _view.OrderProduct.Rows[index].Cells["PSNumber"].Value = model.ProductNumber;
            _view.OrderProduct.Rows[index].Cells["ProductName"].Value = model.Name;
            _view.OrderProduct.Rows[index].Cells["Unit"].Value = model.IsMAinSalesUnit;
            _view.OrderProduct.Rows[index].Cells["Qunatity"].Value = 1;
            decimal PriceIncludeVAT = Convert.ToDecimal(model.PurchaseDefaultPrice + (model.PurchaseDefaultPrice * (model.Vat / 100)));
            _view.OrderProduct.Rows[index].Cells["PriceIncVat"].Value = PriceIncludeVAT;
            _view.OrderProduct.Rows[index].Cells["Discount"].Value = model.Discount;
            decimal SubtotalQuantity = Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["Qunatity"].Value)
                * Convert.ToDecimal(_view.OrderProduct.Rows[index].Cells["PriceIncVat"].Value);
            decimal Subtotal = SubtotalQuantity - (model.PurchaseDefaultPrice * (model.Discount / 100));
            _view.OrderProduct.Rows[index].Cells["Subtotal"].Value = Subtotal;
            ClaculateTotalOrderAmount();
            SelectLastRow();
        }
        internal void ClaculateTotalOrderAmount()
        {
            try
            {
                decimal TotalOrderAmount = 0;
                for(int i = 0; i <= _view.OrderProduct.Rows.Count -1; i++)
                {
                    TotalOrderAmount +=  Convert.ToDecimal(_view.OrderProduct.Rows[i].Cells[7].Value);
                }
                _view.TotalOrder.Text = Math.Round(TotalOrderAmount, 2).ToString();
                _view.ItemCounts.Text = _view.OrderProduct.Rows.Count.ToString();
            }
            catch (Exception) {}
        }
        internal void ClearControl()
        {
            _view.OrderNumber.Text = orderProcuremnt.GenerateSequenceNumberSupplier().ToString();
            _view.BareCode.Clear();
            _view.BareCode.Select();
            _view.ItemCounts.Clear();
            _view.TotalOrder.Clear();
            _view.BareCode.Focus();
            _view.Suppliers.Text = "";
            _view.Products.Text = "أختر منتج";
            _view.IsDeferred.Checked = false;
            _view.OrderDate.Value = DateTime.Now;
            _view.OrderDeferredDate.Value = DateTime.Now;
            _view.OrderProduct.Rows.Clear();

        }
        private void SelectLastRow()
        {
            if(_view.OrderProduct.Rows.Count >= 1)
            {
                _view.OrderProduct.ClearSelection();
                int nRowIndex = _view.OrderProduct.Rows.Count - 1;
                _view.OrderProduct.Rows[nRowIndex].Selected = true;
                _view.OrderProduct.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            else
            {
                MessageBox.Show("لم يعد هنا صفوف منتجات");
            }
        }
    }
}
