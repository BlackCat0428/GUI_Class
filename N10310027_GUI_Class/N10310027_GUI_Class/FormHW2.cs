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
    public partial class FormHW2 : Form
    {
        public FormHW2()
        {
            InitializeComponent();
        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            double a, b, ans;
            try
            {
                a = double.Parse(tB11.Text);
                b = double.Parse(tB12.Text);

                ans = Math.Round(a + b,4);
                labAns1.Text = ans.ToString();

            }

            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }

            catch (System.Exception)
            {
                MessageBox.Show("發生錯誤");
            }

        }

        private void btnAns2_Click(object sender, EventArgs e)
        {
            double a, b, ans;
            try
            {
                a = double.Parse(tB21.Text);
                b = double.Parse(tB22.Text);

                ans = Math.Round(a - b, 4);
                labAns2.Text = ans.ToString();

            }

            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }

            catch (System.Exception)
            {
                MessageBox.Show("發生錯誤");
            }

        }

        private void btnAns3_Click(object sender, EventArgs e)
        {
            double a, b, ans;
            try
            {
                a = double.Parse(tB31.Text);
                b = double.Parse(tB32.Text);

                ans = Math.Round(a * b, 4);
                labAns3.Text = ans.ToString();

            }

            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }

            catch (System.Exception)
            {
                MessageBox.Show("發生錯誤");
            }

        }

        private void btnAns4_Click(object sender, EventArgs e)
        {
            double a, b, ans;
            
            try
            {
                a = double.Parse(tB41.Text);
                b = double.Parse(tB42.Text);

                if (b == 0)
                {
                    MessageBox.Show("分母不可為0");

                }

                else
                {
                    
                    ans = Math.Round(a / b, 4);
                    labAns4.Text = ans.ToString();

                }

            }

            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }

            catch (System.Exception)
            {
                MessageBox.Show("發生錯誤");
            }
           
            
        }
    }
}
