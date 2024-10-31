using System;
using System.Numerics;
using PeterO.Numbers;
using MathNet.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ProstoeNumber
{
    public partial class Form1 : Form
    {
        private bool checkPerfect(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        int intNum1 = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string clearTxt = textBox1.Text.Replace(" ", "");
            bool realNum = int.TryParse(clearTxt, out intNum1);

            if (realNum && clearTxt != "" && intNum1 >= 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perfectsBox.Text = "";
            int cnum = 1;
            int count = 0;
            while (count < intNum1)
            {
                if (checkPerfect(cnum))
                {
                    if (perfectsBox.Text != "")
                    {
                        perfectsBox.Text += ", ";
                    }
                    perfectsBox.Text += cnum;
                }
                cnum++;
                count++;
            }
        }
    }
}
