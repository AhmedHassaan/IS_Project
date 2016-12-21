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
    public partial class EmpolyeeForm : Form
    {
        public EmpolyeeForm()
        {
            InitializeComponent();
        }

        private void EmpolyeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
