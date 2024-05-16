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
        int input;

        public FormGuessNum()
        {
            InitializeComponent();

            btnGuess.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random r  = new Random();
            this.result = r.Next(100);

            btnGuess.Enabled = true;

            this.a = 0;
            this.b = 100;

            labClub.Text = "提示：請輸入" + this.a + "～" + this.b + "的數字";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.input = Int32.Parse(tbGuess.Text);
            }
            
            catch(System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }

            catch(System.Exception)
            {
                MessageBox.Show("發生錯誤");
            }

            if (this.input ==  this.result)
            {
                MessageBox.Show("恭喜答對，答案為："+this.input);

                btnGuess.Enabled = false;
            } 

            else if(this.input >= this.result && this.input <= this.b )
            {
                this.b = this.input;

                labClub.Text = "提示：請輸入" + this.a + "～" + this.b + "的數字";
            }


            else if (this.input >= this.a && this.input <= this.result)
            {
                this.a = this.input;

                labClub.Text = "提示：請輸入" + this.a + "～" + this.b + "的數字";
            }

            else
            {
                MessageBox.Show("提示：請輸入" + this.a + "～" + this.b + "的數字");
            }

        }
    }
}
