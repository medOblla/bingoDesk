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
            title.Text = product.product_title;
            description.Text = product.product_description;
            type.Text = product.product_category;
            brand.Text = product.product_brand;
            tags.Text = product.product_tags;
            price.Text = product.product_profit_price.ToString();
            compareToPrice.Text = product.product_compare_to_price.ToString();
            costPerItem.Text = product.cost_per_item.ToString();
            
            carrier.product_id = product.product_id;
            carrier.product_images = product.product_images;
            carrier.product_sku = product.product_sku;
            carrier.product_barcode = product.product_barcode;
            carrier.product_quantity = product.product_quantity;
            carrier.product_wheight = product.product_wheight;
            carrier.product_height = product.product_height;
        }

        private void next_Click(object sender, EventArgs e)
        {
            FinalProduct product = new FinalProduct();
            product.product_id = carrier.product_id;
            product.product_title = title.Text;
            product.product_description = description.Text;
            product.product_category = type.Text;
            product.product_brand = brand.Text;
            product.product_profit_price = double.Parse(price.Text);
            product.product_compare_to_price = double.Parse(compareToPrice.Text);
            product.cost_per_item = double.Parse(costPerItem.Text);
            product.product_images = carrier.product_images;
            product.product_sku = carrier.product_sku;
            product.product_barcode = carrier.product_barcode;
            product.product_quantity = carrier.product_quantity;
            product.product_wheight = carrier.product_wheight;
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
    }
}
