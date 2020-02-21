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
            int x = 87;
            int y = 189;
            List<Comments> objList = Product.Page_load();
            foreach (Comments product in objList)
            {
                //String product_id = dr["product_id"].ToString();
                Console.WriteLine(product.email.ToString());
                Bunifu.Framework.UI.BunifuCheckbox productCheck = new Bunifu.Framework.UI.BunifuCheckbox();
                PictureBox productPic = new PictureBox();
                RichTextBox product_title = new RichTextBox();
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
                productCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
                productCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                productCheck.ChechedOffColor = System.Drawing.Color.White;
                productCheck.Checked = false;
                productCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
                productCheck.ForeColor = System.Drawing.Color.White;
                productCheck.Location = new System.Drawing.Point(87, y);
                productCheck.Name = "checkProduct";
                productCheck.Size = new System.Drawing.Size(20, 20);
                productCheck.TabIndex = 26;
                // 
                // productPicture
                // 
                productPic.Location = new System.Drawing.Point(122, y);
                productPic.Name = "productPicture";
                productPic.Size = new System.Drawing.Size(81, 67);
                productPic.TabIndex = 27;
                productPic.TabStop = false;
                // 
                // productTitle
                // 
               product_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               product_title.Location = new System.Drawing.Point(303, y);
               product_title.Name = "productTitle";
               product_title.Size = new System.Drawing.Size(235, 75);
               product_title.TabIndex = 35;
               product_title.Text = product.email; // it should show something here
                // 
                // itemsInStock
                // 
               item_inStock.AutoSize = true;
               item_inStock.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
               item_inStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               item_inStock.Location = new System.Drawing.Point(599, y);
               item_inStock.Name = "itemsInStock";
               item_inStock.Size = new System.Drawing.Size(18, 23);
               item_inStock.TabIndex = 36;
               item_inStock.Text = product.id; // it should show something here
                // 
                // inStock
                // 
               in_stock.AutoSize = true;
               in_stock.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
               in_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
               in_stock.Location = new System.Drawing.Point(622, y);
               in_stock.Name = "inStock";
               in_stock.Size = new System.Drawing.Size(59,y);
               in_stock.TabIndex = 37;
               in_stock.Text = product.name; // it should show something here
                // 
                // type
                // 
                categories.AutoSize = true;
                categories.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                categories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                categories.Location = new System.Drawing.Point(741, y);
                categories.Name = "type";
                categories.Size = new System.Drawing.Size(84, 23);
                categories.TabIndex = 37;
                categories.Text = "Men\'s Wear";
                // 
                // brand
                // 
                brands.AutoSize = true;
                brands.Font = new System.Drawing.Font("Poppins Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                brands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                brands.Location = new System.Drawing.Point(881, y);
                brands.Name = "brand";
                brands.Size = new System.Drawing.Size(37, 23);
                brands.TabIndex = 37;
                brands.Text = "Nike";
                // 
                // hide
                // 
                hide_product.FlatAppearance.BorderColor = System.Drawing.Color.White;
                hide_product.FlatAppearance.BorderSize = 0;
                hide_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
                hide_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
                hide_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                hide_product.Image = ((System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject("hide.Image")));
                hide_product.Location = new System.Drawing.Point(983, y);
                hide_product.Name = "hide";
                hide_product.Size = new System.Drawing.Size(24, 24);
                hide_product.TabIndex = 38;
                hide_product.UseVisualStyleBackColor = true;
                // 
                // edit
                // 
               edit_product.FlatAppearance.BorderColor = System.Drawing.Color.White;
               edit_product.FlatAppearance.BorderSize = 0;
               edit_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
               edit_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
               edit_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               edit_product.Image = ((System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject("edit.Image")));
               edit_product.Location = new System.Drawing.Point(1016, y);
               edit_product.Name = "edit";
               edit_product.Size = new System.Drawing.Size(24, 27);
               edit_product.TabIndex = 38;
               edit_product.UseVisualStyleBackColor = true;
                // 
                // delete
                // 
                delete_product.FlatAppearance.BorderColor = System.Drawing.Color.White;
                delete_product.FlatAppearance.BorderSize = 0;
                delete_product.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
                delete_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
                delete_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                delete_product.Image = ((System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject("delete.Image")));
                delete_product.Location = new System.Drawing.Point(1048, y);
                delete_product.Name = "delete";
                delete_product.Size = new System.Drawing.Size(24, 24);
                delete_product.TabIndex = 38;
                delete_product.UseVisualStyleBackColor = true;
                //
                // separator
                //
                separator.BackColor = System.Drawing.Color.Red;
                separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                separator.ForeColor = System.Drawing.Color.Red;
                separator.Location = new System.Drawing.Point(64, y+10);
                separator.Name = "label8";
                separator.Size = new System.Drawing.Size(1008, 1);
                separator.TabIndex = 25;

                y += separator.Location.Y + 10;
                this.Controls.Add(productCheck);
                this.Controls.Add(productPic);
                this.Controls.Add(product_title);
                this.Controls.Add(item_inStock);
                this.Controls.Add(in_stock);
                this.Controls.Add(categories);
                this.Controls.Add(separator);
                this.Controls.Add(brands);
                this.Controls.Add(hide_product);
                this.Controls.Add(edit_product);
                this.Controls.Add(delete_product);

            }
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label1.DisplayRectangle, Color.Blue, ButtonBorderStyle.Solid);
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            sidePanel.Width = site.Width;
            sidePanel.Left = site.Left;
        }

        private void site_Click(object sender, EventArgs e)
        {
            sidePanel.Width = all.Width;
            sidePanel.Left = all.Left;
        }

        private void shop_Click(object sender, EventArgs e)
        {
            sidePanel.Width = shop.Width;
            sidePanel.Left = shop.Left;
        }
    }
}
