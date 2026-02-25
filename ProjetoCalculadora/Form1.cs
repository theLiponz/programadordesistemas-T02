using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class frmCalculadora : Form
    {
        String currentInput = "";
        double result = 0;
        
       
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            currentInput += btn1.Text;
            txtVisor.Text = currentInput;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Button btnLimpar = (Button)sender;
            currentInput = btnLimpar.Text;
            txtVisor.Text = currentInput;
        }
     }
    }
}


