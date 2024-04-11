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
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            labInput.Text = tbInput.Text;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(tbCount1.Text);
            int num2 = Int32.Parse(tbCount2.Text);

            labAns.Text = (num1 + num2).ToString();
        }

        private void btnCount2_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(tbCount3.Text);
            int num2 = Int32.Parse(tbCount4.Text);

            labAns2.Text = (num1 - num2).ToString();

        }

        private void btnCount3_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(tbCount5.Text);
            int num2 = Int32.Parse(tbCount6.Text);

            labAns3.Text = (num1 * num2).ToString();
        }

        private void btnCount4_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(tbCount7.Text);
            int num2 = Int32.Parse(tbCount8.Text);

            labAns4.Text = (num1 / num2).ToString();
        }
    }
}
