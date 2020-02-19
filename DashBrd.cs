using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoStore
{
    public partial class DashBrd : UserControl
    {
        public DashBrd()
        {
            InitializeComponent();
            chart1.Series["inventory"].IsValueShownAsLabel = false;
            chart1.Series["inventory"].IsVisibleInLegend = false;
            chart1.Series["inventory"].Points.AddXY(" ", "10");
            chart1.Series["inventory"].Points.AddXY(" ", "30");
            chart1.Series["inventory"].Points.AddXY(" ", "40");
            chart1.Series["inventory"].Points.AddXY(" ", "20");

            chart1.Series["inventory"].Points[0].Color = Color.FromArgb(25, 218, 221);
            chart1.Series["inventory"].Points[1].Color = Color.FromArgb(249, 165, 48);
            chart1.Series["inventory"].Points[2].Color = Color.FromArgb(253, 166, 225);
            chart1.Series["inventory"].Points[3].Color = Color.FromArgb(124, 146, 250);
        }

        private void DashBrd_Load(object sender, EventArgs e)
        {

        }
    }
}
