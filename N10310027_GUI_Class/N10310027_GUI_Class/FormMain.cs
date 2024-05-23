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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            Form form = new FormButton();
            form.Show();
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form form = new FormTextBox();
            form.Show();
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            Form form = new FormMid();
            form.Show();
        }

        private void btnHW2_Click(object sender, EventArgs e)
        {
            Form form = new FormHW2();
            form.Show();

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Form form = new FormTimer();
            form.Show();

        }

        private void btnGuessNum_Click(object sender, EventArgs e)
        {
            Form form = new FormGuessNum();
            form.Show();

        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            Form form = new FormFinal();
            form.Show();

        }
    }
}
