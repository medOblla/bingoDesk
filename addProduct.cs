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

namespace BingoStore
{
    public partial class addProduct : UserControl
    {
        public addProduct()
        {
            InitializeComponent();
        }
        FinalProduct product = new FinalProduct();

        private void next_Click(object sender, EventArgs e)
        {
            
            product.product_title = title.Text;
            product.product_description = description.Text;
            product.product_category = type.Text;
            product.product_brand = brand.Text;
            product.product_profit_price = double.Parse(price.Text);
            product.product_compare_to_price = double.Parse(compareToPrice.Text);
            product.cost_per_item = double.Parse(costPerItem.Text);
            addProduct02 d1 = new addProduct02(product);
            MainControlClass.showControl(d1, this);
        }

        private void discard_Click(object sender, EventArgs e)
        {
            DashBrd d1 = new DashBrd();
            MainControlClass.showControl(d1, this);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*|";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    product.product_images = dialog.FileName;
                    DirectoryInfo uploadedFile = new DirectoryInfo(dialog.FileName);
                    var frontImage = uploadedFile.EnumerateFiles().Select(f => f.Name).FirstOrDefault();
                    firstImage.Image = Image.FromFile(frontImage);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
