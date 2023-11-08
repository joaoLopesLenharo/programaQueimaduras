using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQueimadura
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnPrimeirosSocorros_Click(object sender, EventArgs e)
        {
          FormPrimeirosSocorros formPrimeirosSocorros = new FormPrimeirosSocorros();
          formPrimeirosSocorros.Show();

          this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
