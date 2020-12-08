using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// LIBRERÍA QUE NOS AYUDA A MOVER LA BARRA SUPERIOR
using System.Runtime.InteropServices;
using LibreriaPersonal;
namespace Examen_Unidad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // BOTÓN DE SALIDA
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            AbrirSecundaria(new Inicio());
        }

        // BOTÓN DE MINIMIZAR
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // BOTÓN DE MAXIMIZAR
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cmdMaximizar.Visible = false;
            cmdRestaurar.Visible = true;
        }
        // BOTÓN DE RESTAURAR
        private void cmdRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            cmdRestaurar.Visible = false;
            cmdMaximizar.Visible = true;
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }

        // TODO ESTE CÓDIGO ES PARA PODER MOVER LA VENTANA CON LA BARRA SUPERIOR
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirSecundaria(object secundaria)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form AbrirSec = secundaria as Form;
            AbrirSec.TopLevel = false;
            AbrirSec.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(AbrirSec);
            this.PanelPrincipal.Tag = AbrirSec;
            AbrirSec.Show();
        }

        private void cmdEmpleados_Click(object sender, EventArgs e)
        {
            AbrirSecundaria(new Empleados());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BarraSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdContactos_Click(object sender, EventArgs e)
        {
            AbrirSecundaria(new Proveedores());
        }

    }
}
