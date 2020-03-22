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
    public partial class addProduct02 : UserControl
    {
        public FinalProduct carrierProduct = new FinalProduct();
        public addProduct02()
        {
            InitializeComponent();
        }
        public addProduct02(FinalProduct product)
        {
            InitializeComponent();
            carrierProduct.product_id = product.product_id;
            carrierProduct.product_title = product.product_title;
            carrierProduct.product_description = product.product_description;
            carrierProduct.product_category = product.product_category;
            carrierProduct.product_brand = product.product_brand;
            carrierProduct.product_tags = product.product_tags;
            carrierProduct.product_gender = product.product_gender;
            carrierProduct.product_profit_price = product.product_profit_price;
            carrierProduct.product_compare_to_price = product.product_compare_to_price;
            carrierProduct.cost_per_item = product.cost_per_item;
            carrierProduct.product_images = product.product_images;
   
        }

        private void back_Click(object sender, EventArgs e)
        {
            addProduct d1 = new addProduct();
            MainControlClass.showControl(d1, this);
        }

        private void save_Click(object sender, EventArgs e)
        {
            FinalProduct product = new FinalProduct();
            product.product_id = carrierProduct.product_id;
            product.product_title = carrierProduct.product_title;
            product.product_description = carrierProduct.product_description;
            product.product_category = carrierProduct.product_category;
            product.product_brand = carrierProduct.product_brand;
            product.product_tags = carrierProduct.product_tags;
            product.product_gender = carrierProduct.product_gender;
            product.product_profit_price = carrierProduct.product_profit_price;
            product.product_compare_to_price = carrierProduct.product_compare_to_price;
            product.cost_per_item = carrierProduct.cost_per_item;
            product.product_images = carrierProduct.product_images;
            product.product_sku = sku.Text;
            product.product_barcode = barcode.Text;
            product.product_quantity = int.Parse(productQuantity.Text);
            product.product_wheight = double.Parse(weight.Text);
            product.product_height = double.Parse(height.Text);
            product.product_carrier = carrier.selectedValue.ToString();
            product.product_size = sizes.Text;
            product.product_colors = colors.Text;
            Product.Add_Product(product);
            MessageBox.Show("Succesfully Inserted !");
        }
    }
}
