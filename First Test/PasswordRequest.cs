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
    public partial class PasswordRequest : Form
    {
        public PasswordRequest()
        {
            InitializeComponent();
        }
        string s;
        private void getPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            s = passText.Text;
            if (s == "admin")
            {
                AccountantForm accForm = new AccountantForm();
                accForm.Show();
            }
            else
            {
                EmpolyeeForm empForm = new EmpolyeeForm();
                empForm.Show();
            }
        }
    }
}
