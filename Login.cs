using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void singIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Dashboard();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
