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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            String num = label_Num.Text;
            int add = Int32.Parse(num) +1;
            label_Num.Text = add.ToString();
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            String num = label_Num.Text;
            int sub = Int32.Parse(num) -1;
            label_Num.Text = sub.ToString();
        }
    }
}
