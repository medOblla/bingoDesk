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
            

            sidePanel.Top = dshboard.Top;
        }

        private void dshboard_Click(object sender, EventArgs e)
        {
            sidePanel.Height = dshboard.Height;
            DashBrd d1 = new DashBrd();
            MainControlClass.showControl(d1, this);
            sidePanel.Top = dshboard.Top;
        }

        private void manageProduct_Click(object sender, EventArgs e)
        {
            sidePanel.Height = manageProduct.Height;
            sidePanel.Top = manageProduct.Top;
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            sidePanel.Height = newProduct.Height;
            sidePanel.Top = newProduct.Top;
        }

        private void reports_Click(object sender, EventArgs e)
        {
            sidePanel.Height = newProduct.Height;
            sidePanel.Top = reports.Top;
        }
    }
}
