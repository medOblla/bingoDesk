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
    public partial class ShowReports : UserControl
    {
        public ShowReports()
        {
            InitializeComponent();

        }

        private void ShowReports_Load(object sender, EventArgs e)
        {
            sidePanel.Width = all.Width;
            sidePanel.Left = all.Left;
            int y = 32;
            List<ReviewClass> reviewList = Review.Page_load();
            foreach (ReviewClass review in reviewList)
            {
             
                Label used_email = new Label();
                Label rating = new Label();
                Label date = new Label();
                Button show_product = new Button();
                Button delete_product = new Button();
                // 
                // productTitle
                // 
                used_email.AutoSize = true;
                used_email.Location = new Point(65, y);
                used_email.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                used_email.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                used_email.Name = "productTitle";
                used_email.Text = review.email;
                // 
                // itemsInStock
                // 
                rating.AutoSize = true;
                rating.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                rating.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                rating.Location = new Point(329, y);
                rating.Name = "itemsInStock";
                rating.Size = new Size(18, 23);
                rating.TabIndex = 36;
                rating.Text = review.starts.ToString();
                // 
                // inStock
                // 
                date.AutoSize = true;
                date.Font = new Font("Poppins Medium", 13F, FontStyle.Regular, GraphicsUnit.Pixel, ((byte)(0)));
                date.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                date.Location = new Point(574, y);
                date.Name = "inStock";
                date.Size = new Size(59, y);
                date.TabIndex = 37;
                date.Text = review.date.ToString();
                // 
                // show
                // 
                show_product.FlatAppearance.BorderColor = Color.White;
                show_product.FlatAppearance.BorderSize = 0;
                show_product.FlatAppearance.MouseDownBackColor = Color.White;
                show_product.FlatAppearance.MouseOverBackColor = Color.White;
                show_product.FlatStyle = FlatStyle.Flat;
                show_product.BackgroundImage = Image.FromFile(@"D:\ProjectsGIT\FinalPFE\bingoDesk\assets\hide01.png");
                show_product.Location = new Point(871, y);
                show_product.Name = "show";
                show_product.Size = new Size(24, 24);
                show_product.TabIndex = 38;
                show_product.UseVisualStyleBackColor = true;
                // 
                // delete
                // 
                delete_product.FlatAppearance.BorderColor = Color.White;
                delete_product.FlatAppearance.BorderSize = 0;
                delete_product.FlatAppearance.MouseDownBackColor = Color.White;
                delete_product.FlatAppearance.MouseOverBackColor = Color.White;
                delete_product.FlatStyle = FlatStyle.Flat;
                delete_product.BackgroundImage = Image.FromFile(@"D:\ProjectsGIT\FinalPFE\bingoDesk\assets\trash01.png");
                delete_product.Location = new Point(931, y);
                delete_product.Name = "delete";
                delete_product.Size = new Size(24, 24);
                delete_product.TabIndex = 38;
                delete_product.UseVisualStyleBackColor = true;

                y += 35 + 10;

                this.scrollable.Controls.Add(used_email);
                this.scrollable.Controls.Add(rating);
                this.scrollable.Controls.Add(date);
                this.scrollable.Controls.Add(show_product);
                this.scrollable.Controls.Add(delete_product);

                scrollable.AutoScroll = false;
                scrollable.HorizontalScroll.Enabled = false;
                scrollable.HorizontalScroll.Visible = false;
                scrollable.HorizontalScroll.Maximum = 0;
                scrollable.AutoScroll = true;
                show_product.Click += (snd, EventArgs) =>
                {
                    ReplayRec d1 = new ReplayRec(review.review_id,review.email,review.last_name, review.first_name, review.review);
                    MainControlClass.showControl(d1, this);
                };
                delete_product.Click += (snd, EventArgs) => { Review.Delete_review(review.review_id); ShowReports_Load(sender,e); };
            }
        }
    }
}
