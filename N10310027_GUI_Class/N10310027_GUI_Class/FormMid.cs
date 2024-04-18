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
    public partial class FormMid : Form
    {
        public FormMid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Int32.Parse(textBox1.Text);
            float ans = a*9/5+32;
            labAns.Text = ans.ToString()+"F";
        }
    }
}
