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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            string hora = "";
            string dia = "";

            lblhora.Text = Datos.Hora(hora);
            lblFecha.Text = Datos.Dia(dia);
        }

        private void cmdBuscarImagen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.InitialDirectory = "C:\\";

            // BuscarImagen.FileName = txtRutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen1.Text = BuscarImagen.FileName;
                Foto1.ImageLocation = BuscarImagen.FileName;
                Foto1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cmdBuscarImagen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.InitialDirectory = "C:\\";

            // BuscarImagen.FileName = txtRutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen2.Text = BuscarImagen.FileName;
                Foto2.ImageLocation = BuscarImagen.FileName;
                Foto2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cmdBuscarImagen3_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.InitialDirectory = "C:\\";

            // BuscarImagen.FileName = txtRutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen3.Text = BuscarImagen.FileName;
                Foto3.ImageLocation = BuscarImagen.FileName;
                Foto3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cmdBuscarImagen4_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.InitialDirectory = "C:\\";

            // BuscarImagen.FileName = txtRutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen4.Text = BuscarImagen.FileName;
                Foto4.ImageLocation = BuscarImagen.FileName;
                Foto4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cmdDatos1_Click(object sender, EventArgs e)
        {
            string Empresa, Celular, Correo;

            txtEmpresa.Enabled = true;
            txtCorreo.Enabled = true;
            txtCelular.Enabled = true;

            Empresa = txtEmpresa.Text;
            Correo = txtCorreo.Text;
            Celular = txtCelular.Text;

            txtEmpresa.Text = Empresa;
            txtCorreo.Text = Correo;
            txtCelular.Text = Celular;
        }

        private void cmdConfirmar1_Click(object sender, EventArgs e)
        {
            txtEmpresa.Enabled = false;
            txtCorreo.Enabled = false;
            txtCelular.Enabled = false;
        }

        private void cmdDatos2_Click(object sender, EventArgs e)
        {
            string Empresa, Celular, Correo;

            txtEmpresa1.Enabled = true;
            txtCorreo1.Enabled = true;
            txtCelular1.Enabled = true;

            Empresa = txtEmpresa1.Text;
            Correo = txtCorreo1.Text;
            Celular = txtCelular1.Text;

            txtEmpresa1.Text = Empresa;
            txtCorreo1.Text = Correo;
            txtCelular1.Text = Celular;
        }

        private void cmdConfirmar2_Click(object sender, EventArgs e)
        {
            txtEmpresa1.Enabled = false;
            txtCorreo1.Enabled = false;
            txtCelular1.Enabled = false;
        }

        private void cmdDatos3_Click(object sender, EventArgs e)
        {
            string Empresa, Celular, Correo;

            txtEmpresa2.Enabled = true;
            txtCorreo2.Enabled = true;
            txtCelular2.Enabled = true;

            Empresa = txtEmpresa2.Text;
            Correo = txtCorreo2.Text;
            Celular = txtCelular2.Text;

            txtEmpresa2.Text = Empresa;
            txtCorreo2.Text = Correo;
            txtCelular2.Text = Celular;
        }

        private void cmdConfirmar3_Click(object sender, EventArgs e)
        {
            txtEmpresa2.Enabled = false;
            txtCorreo2.Enabled = false;
            txtCelular2.Enabled = false;
        }

        private void cmdDatos4_Click(object sender, EventArgs e)
        {
            string Empresa, Celular, Correo;

            txtEmpresa3.Enabled = true;
            txtCorreo3.Enabled = true;
            txtCelular3.Enabled = true;

            Empresa = txtEmpresa3.Text;
            Correo = txtCorreo3.Text;
            Celular = txtCelular3.Text;

            txtEmpresa3.Text = Empresa;
            txtCorreo3.Text = Correo;
            txtCelular3.Text = Celular;
        }

        private void cmdConfirmar4_Click(object sender, EventArgs e)
        {
            txtEmpresa3.Enabled = false;
            txtCorreo3.Enabled = false;
            txtCelular3.Enabled = false;
        }
    }
}
