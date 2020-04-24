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
            carrierProduct.id = product.id;
            carrierProduct.title = product.title;
            carrierProduct.description = product.description;
            carrierProduct.category_id = product.category_id;
            carrierProduct.product_brand = product.product_brand;
            carrierProduct.product_tags = product.product_tags;
            carrierProduct.product_gender = product.product_gender;
            carrierProduct.price = product.price;
            carrierProduct.old_price = product.old_price;
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
            product.id = carrierProduct.id;
            product.title = carrierProduct.title;
            product.description = carrierProduct.description;
            product.category_id = carrierProduct.category_id;
            product.product_brand = carrierProduct.product_brand;
            product.product_tags = carrierProduct.product_tags;
            product.product_gender = carrierProduct.product_gender;
            product.price = carrierProduct.price;
            product.old_price = carrierProduct.old_price;
            product.cost_per_item = carrierProduct.cost_per_item;
            product.product_images = carrierProduct.product_images;
            product.product_sku = sku.Text;
            product.product_barcode = barcode.Text;
            product.product_quantity = int.Parse(productQuantity.Text);
            product.product_weight = double.Parse(weight.Text);
            product.product_height = double.Parse(height.Text);
            product.product_carrier = carrier.selectedValue.ToString();
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
            product.product_size = double.Parse(sizes.selectedValue);
            product.product_colors = colors.selectedValue;
            Product.Add_Product(product);
            MessageBox.Show("The products is added succesfully");
            
        }

        private void sku_Enter(object sender, EventArgs e)
        {
            sku.Text = "";
        }

        private void barcode_Enter(object sender, EventArgs e)
        {
            barcode.Text = "";
        }

        private void productQuantity_Enter(object sender, EventArgs e)
        {
            productQuantity.Text = "";
        }

        private void weight_Enter(object sender, EventArgs e)
        {
            weight.Text = "";
        }

        private void height_Enter(object sender, EventArgs e)
        {
            height.Text = "";
        }
    }
}
