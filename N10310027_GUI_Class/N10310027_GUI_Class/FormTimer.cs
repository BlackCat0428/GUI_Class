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

            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            labSec.Text = sec.ToString()+"秒";
            this.sec++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.sec = 0;
            labSec.Text = "0秒";
        }
    }
}
