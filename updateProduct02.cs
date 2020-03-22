using System;
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
            productCarrier.product_id = product.product_id;
            productCarrier.product_title = product.product_title;
            productCarrier.product_description = product.product_description;
            productCarrier.product_category = product.product_category;
            productCarrier.product_brand = product.product_brand;
            productCarrier.product_tags = product.product_tags;
            productCarrier.product_profit_price = product.product_profit_price;
            productCarrier.product_compare_to_price = product.product_compare_to_price;
            productCarrier.cost_per_item = product.cost_per_item;
            productCarrier.product_images = product.product_images;
            sku.Text = product.product_sku;
            barcode.Text = product.product_barcode;
            productQuantity.Text = product.product_quantity.ToString();
            weight.Text = product.product_wheight.ToString();
            height.Text = product.product_height.ToString();
            carrier.Text = product.product_carrier.ToString();
            colors.Text = (product.product_colors != null) ? product.product_colors.ToString() : null;
            sizes.Text = (product.product_size != null) ? product.product_size.ToString() : null;
        }

        private void save_Click(object sender, EventArgs e)
        {
            FinalProduct product = new FinalProduct();
            product.product_id = productCarrier.product_id;
            product.product_title = productCarrier.product_title;
            product.product_description = productCarrier.product_description;
            product.product_category = productCarrier.product_category;
            product.product_brand = productCarrier.product_brand;
            product.product_tags = productCarrier.product_tags;
            product.product_profit_price = productCarrier.product_profit_price;
            product.product_compare_to_price = productCarrier.product_compare_to_price;
            product.cost_per_item = productCarrier.cost_per_item;
            product.product_images = productCarrier.product_images;
            product.product_sku = sku.Text;
            product.product_barcode = barcode.Text;
            product.product_quantity = int.Parse(productQuantity.Text);
            product.product_wheight = double.Parse(weight.Text);
            product.product_height = double.Parse(height.Text);
            product.product_carrier = carrier.selectedValue.ToString();
            product.product_size = (sizes.Text != null) ? "null" : sizes.Text;
            product.product_colors = (colors.Text != null) ? "null" : colors.Text;
            Product.Edit_product(product);
        }

        private void back_Click(object sender, EventArgs e)
        {
            updateProduct d1 = new updateProduct();
            MainControlClass.showControl(d1, this);
        }
    }
}
