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
    public partial class frmBuscarUsuario : Form
    {
        public frmBuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*Acá se van a hacer las condiciones para ver si el usuario esta en la base de datos.
             if ()
            {

            }
             */
            this.Hide();
            frmRegistrarUsuario registrarUsuario = new frmRegistrarUsuario();
            registrarUsuario.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain();
            main.Show();
        }
    }
}
