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
            product.product_category = category.Text;
            product.product_brand = brand.Text;
            product.product_tags = tags.Text;
            product.product_gender = gender.Text;
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
            string firstImg = " ";
            try
            {
                using(var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string sourcePath = fbd.SelectedPath.ToString();
                        string targetPath = @"C:\xampp\htdocs\Bng\bingoFinal\public\productImages\";
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
                            Console.WriteLine("---------------------------");

                            Console.WriteLine(firstImg);

                        }
                        string jsonImages = JsonConvert.SerializeObject(newDir);
                        product.product_images = jsonImages;
                        Console.WriteLine(jsonImages);
                        Console.WriteLine(newDir.ElementAt(0));
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
    }
}
