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
    public partial class frmTimer : Form
    {
        //Variables
        int horas;
        int minutos;
        int segundos;


        public frmTimer()
        {
            InitializeComponent();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            /*Ciclo para inicializar los valores de los combo box*/
            for (int i = 0; i < 60; i++)
            {
                cbMinutos.Items.Add(i);
                cbSegundos.Items.Add(i);
                if (i < 24)
                {
                    cbHoras.Items.Add(i);
                }
                cbMinutos.SelectedIndex = 0;
                cbSegundos.SelectedIndex = 0;
                cbHoras.SelectedIndex = 0;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                timer1.Start();
                btnIniciar.ForeColor = Color.Firebrick;
                btnPausar.Enabled = true;

                /*Asignación del valor a la variable segun seleccionado en comboBox*/
                horas = cbHoras.SelectedIndex;
                minutos = cbMinutos.SelectedIndex;
                segundos = cbSegundos.SelectedIndex;

                btnIniciar.Text = "Restablecer";
            }
            else
            {
                timer1.Stop();

                //Por si pasara algo reseteamos
                horas = 0;
                minutos = 0;
                segundos = 0;

                lblTiempo.Text = "00:00:00";
                btnIniciar.ForeColor = Color.ForestGreen;
                btnPausar.Enabled = false;
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
                btnIniciar.Text = "Iniciar";
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (btnPausar.Text == "Pausar")
            {
                timer1.Stop();
                btnPausar.ForeColor = Color.DarkOrange;
                btnPausar.Text = "Reanudar";
            }
            else
            {
                timer1.Start();
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*Seundos es = a segundos - 1*/
            segundos -= 1;

            /*Para convertir cada valor del tiempo en un texto*/
            string seg = segundos.ToString();
            string min = minutos.ToString();
            string hor = horas.ToString();

            /*Para agregar 0 delante de los valores menores a 10*/
            if (horas < 10)
            {
                hor = "0" + horas.ToString();
            }
            if (minutos < 10)
            {
                min = "0" + minutos.ToString();
            }
            if (segundos < 10)
            {
                seg = "0" + segundos.ToString();
            }

            /*Para restar valores*/
            if (segundos == 0 && minutos > 0)
            {
                minutos -= 1;
                segundos = 60;
            }
            if (minutos == 0 && horas > 0 && segundos == 0)
            {
                segundos = 60;
                horas -= 1;
                minutos = 59;
            }

            if (segundos == 0 && minutos == 0 && horas == 0)
            {
                timer1.Stop();
                MessageBox.Show("Se ha acabado el tiempo.", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPausar.Enabled = false;
                btnPausar.ForeColor = Color.RoyalBlue;
                btnPausar.Text = "Pausar";
            }
            lblTiempo.Text = hor + ":" + min + ":" + seg;
        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }
    }
}
