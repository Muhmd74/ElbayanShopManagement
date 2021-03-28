﻿using ElbayanDatabase.ConnectionTools;
using ElbayanServices.Repository.Products.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.CommonPresenter
{
    public class PopulateActiveProduct
    {
        private static ProductService Product = new ProductService(new ConnectionOption());
        public static void PopulateProducts(ComboBox activeProduct)
        {
            activeProduct.DisplayMember = "Name";
            activeProduct.SelectedIndex = -1;
            activeProduct.SelectedValue = "Id";
            activeProduct.DataSource = Product.GetAll();
        }
    }
}
