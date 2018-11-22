using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorClient
{
    public partial class Form1 : Form
    {
        ServiceReference1.CalculatorServiceClient _client = new ServiceReference1.CalculatorServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(_client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text)));
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(_client.sub(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text)));
        }
    }
}
