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
            category.selectedIndex = int.Parse(product.category_id);
            //gender.selectedValue = product.product_gender;
            brand.Text = product.product_brand;
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
            product.product_tags = tags.Text;
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

        private void category_onItemSelected(object sender, EventArgs e)
        {

        }

        public bool flag = false;
        public int counter = 0;
        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (price.Text.Contains('.')) flag = true; else flag = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.'))
            {
                counter++;

                if (counter > 1 && flag) e.Handled = true;
            }
        }

        public bool flag1 = false;
        public int counter1 = 0;
        private void compareToPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (compareToPrice.Text.Contains('.')) flag1 = true; else flag1 = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.'))
            {
                counter1++;

                if (counter1 > 1 && flag1) e.Handled = true;
            }
        }

        public bool flag2 = false;
        public int counter2 = 0;
        private void costPerItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (costPerItem.Text.Contains('.')) flag2 = true; else flag2 = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.'))
            {
                counter2++;

                if (counter2 > 1 && flag2) e.Handled = true;
            }


        }

    }
}
