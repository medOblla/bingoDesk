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
using BingoStore.APIs;

namespace BingoStore
{
    public partial class addProduct : UserControl
    {
        public addProduct()
        {
            InitializeComponent();
            List<Category> cates = Product.Categories();
        }
        FinalProduct product = new FinalProduct();
        
        private void next_Click(object sender, EventArgs e)
        {
            
            product.title = title.Text;
            product.description = description.Text;
            product.category_id = category.selectedIndex.ToString();
            product.product_brand = brand.selectedValue.ToString();
            product.product_tags = tags.Text;
            product.product_gender = gender.selectedValue.ToString();
            product.price = double.Parse(price.Text);
            product.old_price = double.Parse(compareToPrice.Text);
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
            string firstImg = " ";
            try
            {
                using(var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string sourcePath = fbd.SelectedPath.ToString();
                        string targetPath = @"C:\xampp\htdocs\bingoFinal\public\productImages\";
                        if (!Directory.Exists(targetPath))
                        {
                            Directory.CreateDirectory(targetPath);
                        }
                        string[] sourceFiles = Directory.GetFiles(sourcePath);
                        List<string> newDir = new List<string>();
                        foreach(string sourceFile in sourceFiles)
                        {
                            string fileName = Path.GetFileName(sourceFile);
                            string destFile = Path.Combine(targetPath, Path.GetFileNameWithoutExtension(fileName) + GetTimestamp(DateTime.Now) + Path.GetExtension(fileName));
                            firstImg = Path.Combine(targetPath,Path.GetFileName(destFile));
                            File.Move(sourceFile, destFile);
                            newDir.Add(Path.GetFileName(destFile).ToString());
                        }
                        string jsonImages = JsonConvert.SerializeObject(newDir);
                        product.product_images = jsonImages;
                        firstImage.Image = Image.FromFile(firstImg);
                    }
                }
            }
            catch (Exception io)
            {
                MessageBox.Show(io.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }

        private void category_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void category_onItemSelected(object sender, EventArgs e)
        {

        }

        private void firstPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void price_OnValueChanged(object sender, EventArgs e)
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
            if ((e.KeyChar == '.') )
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

        private void costPerItem_Enter(object sender, EventArgs e)
        {
            costPerItem.Text = "";
        }

        private void price_Enter(object sender, EventArgs e)
        {
            price.Text = "";
        }

        private void title_Enter(object sender, EventArgs e)
        {
            title.Text = "";
        }

        private void tags_Enter(object sender, EventArgs e)
        {
            tags.Text = "";
        }

        private void compareToPrice_Enter(object sender, EventArgs e)
        {
            compareToPrice.Text = "";
        }
    }
}
