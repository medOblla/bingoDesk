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
namespace BingoStore
{
    public partial class addProduct : UserControl
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            addProduct02 d1 = new addProduct02();
            MainControlClass.showControl(d1, this);
        }

        private void discard_Click(object sender, EventArgs e)
        {
            DashBrd d1 = new DashBrd();
            MainControlClass.showControl(d1, this);
        }
    }
}
