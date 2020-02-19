using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoStore
{
    class MainControlClass
    {
        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control Content)
        {
            Content.Controls.Clear();
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            Content.Controls.Add(control);

        }
    }
}
