﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BingoStore.Models;
using BingoStore.APIs;

namespace BingoStore
{
    public partial class updateProduct02 : UserControl
    {
        public FinalProduct productCarrier = new FinalProduct();
        public updateProduct02(FinalProduct product)
        {
            InitializeComponent();
            productCarrier.id = product.id;
            productCarrier.title = product.title;
            productCarrier.description = product.description;
            productCarrier.product_gender = product.product_gender;
            productCarrier.category_id = product.category_id;
            productCarrier.product_brand = product.product_brand;
            productCarrier.product_tags = product.product_tags;
            productCarrier.price = product.price;
            productCarrier.old_price = product.old_price;
            productCarrier.cost_per_item = product.cost_per_item;
            productCarrier.product_images = product.product_images;
            sku.Text = product.product_sku;
            barcode.Text = product.product_barcode;
            productQuantity.Text = product.product_quantity.ToString();
            weight.Text = product.product_weight.ToString();
            height.Text = product.product_height.ToString();
            //carrier.Text = product.product_carrier.ToString();
            //colors.Text = (product.product_colors != null) ? product.product_colors.ToString() : null;
            //sizes.Text = (product.product_size != null) ? product.product_size.ToString() : null;
        }

        private void save_Click(object sender, EventArgs e)
        {
            FinalProduct product = new FinalProduct();
            product.id = productCarrier.id;
            product.title = productCarrier.title;
            product.description = productCarrier.description;
            product.product_gender = productCarrier.product_gender;
            product.category_id = productCarrier.category_id;
            product.product_brand = productCarrier.product_brand;
            product.product_tags = productCarrier.product_tags;
            product.price = productCarrier.price;
            product.old_price = productCarrier.old_price;
            product.cost_per_item = productCarrier.cost_per_item;
            product.product_images = productCarrier.product_images;
            product.product_sku = sku.Text;
            product.product_barcode = barcode.Text;
            product.product_quantity = int.Parse(productQuantity.Text);
            product.product_weight = double.Parse(weight.Text);
            product.product_height = double.Parse(height.Text);
            product.product_carrier = carrier.selectedValue.ToString();
            product.product_size = double.Parse(sizes.selectedValue);
            product.product_colors = colors.selectedValue;
            if (localStore.Checked && localWeb.Checked)
            {
                product.local = "WebnStore";
            }
            else if (localWeb.Checked && !localStore.Checked)
            {
                product.local = "Web";
            }
            else if (!localWeb.Checked && localStore.Checked)
            {
                product.local = "Store";
            }
            Product.Edit_product(product);
            MessageBox.Show("The products is updated succesfully");
        }

        private void back_Click(object sender, EventArgs e)
        {
            updateProduct d1 = new updateProduct();
            MainControlClass.showControl(d1, this);
        }
    }
}
