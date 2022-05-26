using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int numUno = Convert.ToInt32(txtNumUno.Text);
                int numDos = Convert.ToInt32(txtNumDos.Text);
                txtRta.Text = Convert.ToString(numUno / numDos);


            }
            catch (DivideByZeroException) when (int.Parse(txtNumDos.Text)==0)
            {

                MessageBox.Show("Como vas a dividir por 0 kpo","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("que onda paco qliao");
        }
    }
}
