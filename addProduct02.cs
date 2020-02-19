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
    public partial class addProduct02 : UserControl
    {
        public addProduct02()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            addProduct d1 = new addProduct();
            MainControlClass.showControl(d1, this);
        }
    }
}
