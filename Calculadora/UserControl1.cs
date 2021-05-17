using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class UserControl1 : UserControl
    {
        string last = "";
        String operation = "";
        public UserControl1()
        {
            InitializeComponent();
        }
        #region numbers
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += ".";
        }
        #endregion

        private void buttonSum_Click(object sender, EventArgs e)
        {
            last = textBoxRes.Text;
            textBoxRes.Text = "";
            operation = "Sum";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "Sum":
                        int sum = int.Parse(last) + int.Parse(textBoxRes.Text);
                        textBoxRes.Text = sum.ToString();
                        break;
                    case "Res":
                        int res = int.Parse(last) - int.Parse(textBoxRes.Text);
                        textBoxRes.Text = res.ToString();
                        break;
                    case "Multi":
                        int multi = int.Parse(last) - int.Parse(textBoxRes.Text);
                        textBoxRes.Text = multi.ToString();
                        break;
                    case "Divi":
                        float divi = int.Parse(last) - int.Parse(textBoxRes.Text);
                        textBoxRes.Text = divi.ToString();
                        break;

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            last = textBoxRes.Text;
            textBoxRes.Text = "";
            operation = "Res";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            last = textBoxRes.Text;
            textBoxRes.Text = "";
            operation = "Multi";
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
