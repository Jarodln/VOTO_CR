using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarUsuario buscarUsuario = new frmBuscarUsuario();
            buscarUsuario.Show();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioAdmin admin = new frmInicioAdmin();
            admin.Show();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTimer timer = new frmTimer();
            timer.Show();
        }
    }
}
