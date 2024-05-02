using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N10310027_GUI_Class
{
    public partial class FormTimer : Form
    {
        int sec = 0;

        public FormTimer()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            labSec.Text = sec.ToString()+"秒";
            this.sec++; //加佳
        }
    }
}
