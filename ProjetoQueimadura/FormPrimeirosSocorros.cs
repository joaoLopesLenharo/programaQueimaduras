using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQueimadura
{
    public partial class FormPrimeirosSocorros : Form
    {
        public FormPrimeirosSocorros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            formMenu.WindowState = FormWindowState.Maximized;
        }
    }
}
