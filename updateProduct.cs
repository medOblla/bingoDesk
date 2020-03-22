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
using System.IO;
using Newtonsoft.Json;

namespace BingoStore
{
    public partial class updateProduct : UserControl
    {   public FinalProduct carrier = new FinalProduct();
       
        
        public updateProduct()
        {
            InitializeComponent();
        }
        public updateProduct(FinalProduct product)
        {
            InitializeComponent();
            title.Text = product.title;
            description.Text = product.description;
          //  category.Text = product.product_category.ToString();
           // brand.Text = product.product_brand;
            tags.Text = product.product_tags;
            price.Text = product.price.ToString();
            compareToPrice.Text = product.old_price.ToString();
            costPerItem.Text = product.cost_per_item.ToString();
            
            carrier.id = product.id;
            carrier.product_images = product.product_images;
            carrier.product_sku = product.product_sku;
            carrier.product_barcode = product.product_barcode;
            carrier.product_quantity = product.product_quantity;
            carrier.product_weight = product.product_weight;
            carrier.product_height = product.product_height;
        }

        private void next_Click(object sender, EventArgs e)
        {
            FinalProduct product = new FinalProduct();
            product.id = carrier.id;
            product.title = title.Text;
            product.product_gender = gender.selectedValue.ToString();
            product.description = description.Text;
            product.category_id = category.selectedIndex.ToString();
            product.product_brand = brand.selectedValue.ToString();
            product.price = double.Parse(price.Text);
            product.old_price = double.Parse(compareToPrice.Text);
            product.cost_per_item = double.Parse(costPerItem.Text);
            product.product_images = carrier.product_images;
            product.product_sku = carrier.product_sku;
            product.product_barcode = carrier.product_barcode;
            product.product_quantity = carrier.product_quantity;
            product.product_weight = carrier.product_weight;
            product.product_height = carrier.product_height;
            updateProduct02 nextStep = new updateProduct02(product);
            MainControlClass.showControl(nextStep, this);

        }



        private void firstImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string[] files = Directory.GetFiles(fbd.SelectedPath);
                        string jsonImages = JsonConvert.SerializeObject(files);
                        carrier.product_images = jsonImages;
                        firstImage.Image = Image.FromFile(files[0]);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discard_Click(object sender, EventArgs e)
        {
            DashBrd d1 = new DashBrd();
            MainControlClass.showControl(d1, this);
        }

        private void next_Click_1(object sender, EventArgs e)
        {

        }

        private void category_onItemSelected(object sender, EventArgs e)
        {

        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
