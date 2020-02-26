using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using BingoStore.Models;
using BingoStore.APIs;


namespace BingoStore
{
    public partial class ShowProducts : UserControl
    {   
        
        public ShowProducts()
        {
            InitializeComponent();
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label1.DisplayRectangle, Color.Blue, ButtonBorderStyle.Solid);
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            sidePanel.Width = all.Width;
            sidePanel.Left = all.Left;
            int y = 32;
            List<FinalProduct> productList = Product.Page_load();
            foreach(FinalProduct product in productList)
            {
                Bunifu.Framework.UI.BunifuCheckbox productCheck = new Bunifu.Framework.UI.BunifuCheckbox();
                PictureBox productPic = new PictureBox();
                Label product_title = new Label();
                Label item_inStock = new Label();
                Label in_stock = new Label();
                Label categories = new Label();
                Label separator = new Label();
                Label brands = new Label();
                Button hide_product = new Button();
                Button edit_product = new Button();
                Button delete_product = new Button();
                // 
                // checkProduct
                // 
                productCheck.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
                productCheck.BorderStyle = BorderStyle.FixedSingle;
                productCheck.ChechedOffColor = Color.White;
                productCheck.Checked = true;
                productCheck.CheckedOnColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
                productCheck.ForeColor = Color.White;
                productCheck.Location = new Point(24, y);
                productCheck.Name = "checkProduct";
                productCheck.Size = new Size(20, 20);
                productCheck.TabIndex = 26;
                // 
                // productPicture
                // 
                productPic.Location = new Point(54, y-30);
                productPic.Name = "productPicture";
                productPic.Size = new Size(155, 81);
                productPic.TabIndex = 27;
                productPic.SizeMode = PictureBoxSizeMode.StretchImage;
                productPic.TabStop = false;
                productPic.ImageLocation = "C:/Users/sparo/Desktop/trial.jpeg";//product.product_images[1];
                // 
                // productTitle
                // 
                product_title.AutoSize = true;
                product_title.Location = new Point(235, y);
                product_title.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                product_title.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                product_title.Name = "productTitle";
                item_inStock.Size = new Size(18, 23);
                product_title.Text = product.product_title; // it should show something here
                // 
                // itemsInStock
                // 
                item_inStock.AutoSize = true;
                item_inStock.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                item_inStock.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                item_inStock.Location = new Point(535, y);
                item_inStock.Name = "itemsInStock";
                item_inStock.Size = new Size(18, 23);
                item_inStock.TabIndex = 36;
                item_inStock.Text = product.product_quantity.ToString();// product.product_quantity; // it should show something here
                // 
                // inStock
                // 
                in_stock.AutoSize = true;
                in_stock.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                in_stock.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                in_stock.Location = new Point(566, y);
                in_stock.Name = "inStock";
                in_stock.Size = new Size(59, y);
                in_stock.TabIndex = 37;
                in_stock.Text = "In Stock"; // it should show something here
                // 
                // type
                // 
                categories.AutoSize = true;
                categories.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                categories.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                categories.Location = new Point(693, y);
                categories.Name = "type";
                categories.Size = new Size(84, 23);
                categories.TabIndex = 37;
                categories.Text = "Mens shit";// product.product_category;
                // 
                // brand
                // 
                brands.AutoSize = true;
                brands.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                brands.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                brands.Location = new Point(809, y);
                brands.Name = "brand";
                brands.Size = new Size(37, 23);
                brands.TabIndex = 37;
                brands.Text = "Nike";// product.product_brand;
                // 
                // hide
                // 
                hide_product.FlatAppearance.BorderColor = Color.White;
                hide_product.FlatAppearance.BorderSize = 0;
                hide_product.FlatAppearance.MouseDownBackColor = Color.White;
                hide_product.FlatAppearance.MouseOverBackColor = Color.White;
                hide_product.FlatStyle = FlatStyle.Flat;
                hide_product.BackgroundImage = Image.FromFile(@"D:\Projects GIT\StoreApp\BingoStore\assets\hide01.png");
                hide_product.Location = new Point(910, y);
                hide_product.Name = "hide";
                hide_product.Size = new Size(24, 24);
                hide_product.TabIndex = 38;
                hide_product.UseVisualStyleBackColor = true;
                // 
                // edit
                // 
                edit_product.FlatAppearance.BorderColor = Color.White;
                edit_product.FlatAppearance.BorderSize = 0;
                edit_product.FlatAppearance.MouseDownBackColor = Color.White;
                edit_product.FlatAppearance.MouseOverBackColor = Color.White;
                edit_product.FlatStyle = FlatStyle.Flat;
                edit_product.BackgroundImage = Image.FromFile(@"D:\Projects GIT\StoreApp\BingoStore\assets\gear01.png");
                edit_product.Location = new Point(940, y);
                edit_product.Name = "edit";
                edit_product.Size = new Size(24, 27);
                edit_product.TabIndex = 38;
                edit_product.UseVisualStyleBackColor = true;
                // 
                // delete
                // 
                delete_product.FlatAppearance.BorderColor = Color.White;
                delete_product.FlatAppearance.BorderSize = 0;
                delete_product.FlatAppearance.MouseDownBackColor = Color.White;
                delete_product.FlatAppearance.MouseOverBackColor = Color.White;
                delete_product.FlatStyle = FlatStyle.Flat;
                delete_product.BackgroundImage = Image.FromFile(@"D:\Projects GIT\StoreApp\BingoStore\assets\trash01.png");
                delete_product.Location = new Point(970, y);
                delete_product.Name = "delete";
                delete_product.Size = new Size(24, 24);
                delete_product.TabIndex = 38;
                delete_product.UseVisualStyleBackColor = true;
                //
                // separator
                //
                separator.BackColor = Color.Red;
                separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                separator.ForeColor = Color.Red;
                separator.Location = new Point(64, y + 10);
                separator.Name = "label8";
                separator.Size = new Size(1008, 1);
                separator.TabIndex = 25;

                y += productPic.Height + 10;
                
                this.scrollable.Controls.Add(productCheck);
                this.scrollable.Controls.Add(productPic);
                this.scrollable.Controls.Add(product_title);
                this.scrollable.Controls.Add(item_inStock);
                this.scrollable.Controls.Add(in_stock);
                this.scrollable.Controls.Add(categories);
                this.scrollable.Controls.Add(hide_product);
                this.scrollable.Controls.Add(edit_product);
                this.scrollable.Controls.Add(delete_product);
              
                scrollable.AutoScroll = false;
                scrollable.HorizontalScroll.Enabled = false;
                scrollable.HorizontalScroll.Visible = false;
                scrollable.HorizontalScroll.Maximum = 0;
                scrollable.AutoScroll = true;

                delete_product.Click += Delete_product_Click(sender, e, product.product_id);
                hide_product.Click += Hide_product_Click(sender, e, product.product_id);
                edit_product.Click += Edit_product_Click(sender, e, product);
            }

        }

        private EventHandler Edit_product_Click(Object sender, EventArgs e, FinalProduct product)
        {
            updateProduct update = new updateProduct(product);
            MainControlClass.showControl(update, this);
            return null;
        }

        private EventHandler Hide_product_Click(object sender, EventArgs e, int product_id)
        {
            Product.Hide_product(product_id);
            return null;
        }

        private EventHandler Delete_product_Click(object sender, EventArgs e, int product_id)
        {
            Product.Delete_product(product_id);
            return null;
        }

        private void site_Click(object sender, EventArgs e)
        {
            sidePanel.Width = site.Width;
            sidePanel.Left = site.Left;
        }

        private void shop_Click(object sender, EventArgs e)
        {
            sidePanel.Width = shop.Width;
            sidePanel.Left = shop.Left;
        }

        private void all_Click(object sender, EventArgs e)
        {
            sidePanel.Width = all.Width;
            sidePanel.Left = all.Left;
        }
    }
}
