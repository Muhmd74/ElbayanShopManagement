using System;

namespace ElbayanDatabase.DataClasses.Suppliers.SupplierOrder
{
  public  class SupplierOrderProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
        public Guid SupplierOrderId { get; set; }
        public SupplierOrder SupplierOrder { get; set; }
        public int Quantity { get; set; }
        public decimal PriceSale { get; set; } // ProductDefaultSale Or New Price
        public decimal SubTotalPrice { get; set; } // Quantity * PriceSale 
        public decimal Discount { get; set; }
        public decimal TotalProductPrice { get; set; } // subtotal-Discount
        public decimal Vat { get; set; } // price * vat in Product /100 
        public decimal TotalPrice { get; set; } // TotalProductPrice + vat

    }
}
