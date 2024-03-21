using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N10310027_GUI_Class
{
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (btnClick.Text == "請按我一下")
                btnClick.Text = "我已經被按過了";

            else if (btnClick.Text == "我已經被按過了")
                btnClick.Text = "請按我一下";
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            labDont.Text = "就叫你不要按";
            btnLabel.Text = "按的是小狗";
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(labCount.Text);
            count = count+1;
            labCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            int count = Int32.Parse(labCount.Text);
            count = count-1;
            labCount.Text = count.ToString();
        }
    }
}
