using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acc_Click(object sender, EventArgs e)
        {

            this.Hide();
            PasswordRequest formm = new PasswordRequest();
            formm.ShowDialog();
        }

        private void emp_Click(object sender, EventArgs e)
        {

            this.Hide();
            EmpolyeeForm empForm = new EmpolyeeForm();
            empForm.ShowDialog();
        }
    }
}
