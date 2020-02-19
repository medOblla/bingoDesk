using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace BingoStore
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            sidePanel.Top = dshboard.Top;
        }

        private void dshboard_Click(object sender, EventArgs e)
        {
            sidePanel.Height = dshboard.Height;
            sidePanel.Top = dshboard.Top;
            DashBrd d1 = new DashBrd();
            MainControlClass.showControl(d1,content);
            
        }

        private void manageProduct_Click(object sender, EventArgs e)
        {
            sidePanel.Height = manageProduct.Height;
            sidePanel.Top = manageProduct.Top;
            ShowProducts tab = new ShowProducts();
            MainControlClass.showControl(tab, content);
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            sidePanel.Height = newProduct.Height;
            sidePanel.Top = newProduct.Top;
            addProduct tab = new addProduct();
            MainControlClass.showControl(tab, content);
        }

        private void reports_Click(object sender, EventArgs e)
        {
            sidePanel.Height = newProduct.Height;
            sidePanel.Top = reports.Top;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
