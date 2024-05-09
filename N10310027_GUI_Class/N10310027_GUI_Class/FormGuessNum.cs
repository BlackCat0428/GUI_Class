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
    public partial class FormGuessNum : Form
    {
        int result = 0;
        int a = 0, b = 100;

        public FormGuessNum()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random r  = new Random();
            this.result = r.Next(100);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int input = Int32.Parse(tbGuess.Text);
            //Try Catch

            if(input ==  this.result)
            {
                MessageBox.Show("恭喜答對，答案為："+input);
            } 

            else if(input >= this.result && input <= this.b )
            {
                this.b = input;

                labClub.Text = "提示：請輸入" + this.a + "～" + this.b + "的數字";
            }


            else if (input >= this.a && input <= this.result)
            {
                this.a = input;

                labClub.Text = "提示：請輸入" + this.a + "～" + this.b + "的數字";
            }

            else
            {
                MessageBox.Show("提示：請輸入" + this.a + "～" + this.b + "的數字");
            }

        }
    }
}
