using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace Heimaverk_stae_Gudni_Johann
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IDictionary<double, double> dict = new Dictionary<double, double>();

        private void bt_submit_Click(object sender, EventArgs e)
        {
            Expression num = new Expression(tb_line.Text);

            for (int i = -50; i <= 50; i++)
            {
                num.Parameters["x"] = i;
                double number = Convert.ToDouble(num.Evaluate());

                MessageBox.Show(number.ToString());


            }


        }
    }
}
