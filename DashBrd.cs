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
    public partial class DashBrd : UserControl
    {
        public DashBrd()
        {
            InitializeComponent();
            Statistics  myStats = Product.Get_Stats();
            List<FinalProduct> productList = Product.Page_load();

            label5.Text = myStats.nbProducts.ToString();
            customernb.Text = myStats.nbUsers.ToString();
            label2.Text = myStats.nbsales.ToString();

            chart1.Series["inventory"].IsValueShownAsLabel = false;
            chart1.Series["inventory"].IsVisibleInLegend = false;
            chart1.Series["inventory"].Points.AddXY(" ", myStats.access.ToString());
            chart1.Series["inventory"].Points.AddXY(" ", myStats.men.ToString());
            chart1.Series["inventory"].Points.AddXY(" ", myStats.women.ToString());
            chart1.Series["inventory"].Points.AddXY(" ", myStats.kids.ToString());

            chart1.Series["inventory"].Points[0].Color = Color.FromArgb(25, 218, 221);
            chart1.Series["inventory"].Points[1].Color = Color.FromArgb(249, 165, 48);
            chart1.Series["inventory"].Points[2].Color = Color.FromArgb(253, 166, 225);
            chart1.Series["inventory"].Points[3].Color = Color.FromArgb(124, 146, 250);

            int i = 0;
            string[] row;
            foreach (FinalProduct product in productList)
            {
                if (i < 13)
                {
                    row = new[] { product.title, product.product_quantity.ToString(), product.nb_sales.ToString(), (product.product_quantity - product.nb_sales).ToString(), product.product_gender };
                    detailsTable.Rows.Add(row);
                }
                else
                    break;
                i++;
            }
        }

        private void DashBrd_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
