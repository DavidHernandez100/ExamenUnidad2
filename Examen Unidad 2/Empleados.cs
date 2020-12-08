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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
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

        private void cmdBuscarImagen5_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.InitialDirectory = "C:\\";

            // BuscarImagen.FileName = txtRutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen5.Text = BuscarImagen.FileName;
                Foto5.ImageLocation = BuscarImagen.FileName;
                Foto5.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cmdBuscarImagen6_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.InitialDirectory = "C:\\";

            // BuscarImagen.FileName = txtRutaImagen.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRutaImagen6.Text = BuscarImagen.FileName;
                Foto6.ImageLocation = BuscarImagen.FileName;
                Foto6.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void cmdDatos1_Click(object sender, EventArgs e)
        {
            string Nombre, Celular, Puesto;

            txtNombre.Enabled = true;
            txtPuesto1.Enabled = true;
            txtCelular1.Enabled = true;

            Nombre = txtNombre.Text;
            Puesto = txtPuesto1.Text;
            Celular = txtCelular1.Text;

            txtNombre.Text = Nombre;
            txtPuesto1.Text = Puesto;
            txtCelular1.Text = Celular;
        }

        private void cmdConfirmar1_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtPuesto1.Enabled = false;
            txtCelular1.Enabled = false;
        }

        private void cmdDatos2_Click(object sender, EventArgs e)
        {
            string Nombre, Celular, Puesto;

            txtNombre1.Enabled = true;
            txtPuesto2.Enabled = true;
            txtCelular2.Enabled = true;

            Nombre = txtNombre.Text;
            Puesto = txtPuesto2.Text;
            Celular = txtCelular2.Text;

            txtNombre1.Text = Nombre;
            txtPuesto2.Text = Puesto;
            txtCelular2.Text = Celular;
        }

        private void cmdConfirmar2_Click(object sender, EventArgs e)
        {
            txtNombre1.Enabled = false;
            txtPuesto2.Enabled = false;
            txtCelular2.Enabled = false;
        }

        private void cmdDatos3_Click(object sender, EventArgs e)
        {
            string Nombre, Celular, Puesto;

            txtNombre3.Enabled = true;
            txtPuesto3.Enabled = true;
            txtCelular3.Enabled = true;

            Nombre = txtNombre3.Text;
            Puesto = txtPuesto3.Text;
            Celular = txtCelular3.Text;

            txtNombre3.Text = Nombre;
            txtPuesto3.Text = Puesto;
            txtCelular3.Text = Celular;
        }

        private void cmdConfirmar3_Click(object sender, EventArgs e)
        {
            txtNombre3.Enabled = false;
            txtPuesto3.Enabled = false;
            txtCelular3.Enabled = false;
        }

        private void cmdDatos4_Click(object sender, EventArgs e)
        {
            string Nombre, Celular, Puesto;

            txtNombre4.Enabled = true;
            txtPuesto4.Enabled = true;
            txtCelular4.Enabled = true;

            Nombre = txtNombre4.Text;
            Puesto = txtPuesto4.Text;
            Celular = txtCelular4.Text;

            txtNombre4.Text = Nombre;
            txtPuesto4.Text = Puesto;
            txtCelular4.Text = Celular;
        }

        private void cmdConfirmar4_Click(object sender, EventArgs e)
        {
            txtNombre4.Enabled = false;
            txtPuesto4.Enabled = false;
            txtCelular4.Enabled = false;
        }

        private void cmdDatos5_Click(object sender, EventArgs e)
        {
            string Nombre, Celular, Puesto;

            txtNombre5.Enabled = true;
            txtPuesto5.Enabled = true;
            txtCelular5.Enabled = true;

            Nombre = txtNombre5.Text;
            Puesto = txtPuesto5.Text;
            Celular = txtCelular5.Text;

            txtNombre5.Text = Nombre;
            txtPuesto5.Text = Puesto;
            txtCelular5.Text = Celular;
        }

        private void cmdConfirmar5_Click(object sender, EventArgs e)
        {
            txtNombre5.Enabled = false;
            txtPuesto5.Enabled = false;
            txtCelular5.Enabled = false;
        }

        private void cmdDatos6_Click(object sender, EventArgs e)
        {
            string Nombre, Celular, Puesto;

            txtNombre6.Enabled = true;
            txtPuesto6.Enabled = true;
            txtCelular6.Enabled = true;

            Nombre = txtNombre6.Text;
            Puesto = txtPuesto6.Text;
            Celular = txtCelular6.Text;

            txtNombre6.Text = Nombre;
            txtPuesto6.Text = Puesto;
            txtCelular6.Text = Celular;
        }

        private void cmdConfirmar6_Click(object sender, EventArgs e)
        {
            txtNombre6.Enabled = false;
            txtPuesto6.Enabled = false;
            txtCelular6.Enabled = false;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            string hora = "";
            string dia = "";

            lblhora.Text = Datos.Hora(hora);
            lblFecha.Text = Datos.Dia(dia);
        }
    }
}
