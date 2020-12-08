using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPersonal;

namespace Examen_Unidad_2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            string hora = "";
            string dia = "";

            lblhora.Text = Datos.Hora(hora);
            lblFecha.Text = Datos.Dia(dia);
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void cmdBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.InitialDirectory = "C:\\";

           // BuscarImagen.FileName = txtRutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
               txtRutaImagen.Text = BuscarImagen.FileName;
                Foto.ImageLocation = BuscarImagen.FileName;
                Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdDatos_Click(object sender, EventArgs e)
        {
            string Nombre, CURP, Correo, fecha, Celular;
            
            txtNombre.Enabled = true;
            txtFecha.Enabled = true;
            txtCURP.Enabled = true;
            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;

            Nombre = txtNombre.Text;
            CURP = txtCURP.Text;
            Correo = txtCorreo.Text;
            fecha = txtFecha.Text;
            Celular = txtCelular.Text;

            txtNombre.Text = Nombre;
            txtFecha.Text = fecha;
            txtCURP.Text = CURP;
            txtCorreo.Text = Correo;
            txtCelular.Text = Celular;
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtFecha.Enabled = false;
            txtCURP.Enabled = false;
            txtCorreo.Enabled = false;
            txtCelular.Enabled = false;
        }
    }
}
