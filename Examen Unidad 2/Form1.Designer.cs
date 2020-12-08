namespace Examen_Unidad_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.cmdInicio = new System.Windows.Forms.PictureBox();
            this.BarraIzquierda = new System.Windows.Forms.Panel();
            this.cmdRestaurar = new System.Windows.Forms.PictureBox();
            this.cmdMinimizar = new System.Windows.Forms.PictureBox();
            this.cmdMaximizar = new System.Windows.Forms.PictureBox();
            this.cmdCerrar = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.cmdEmpleados = new System.Windows.Forms.Button();
            this.cmdContactos = new System.Windows.Forms.Button();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdInicio)).BeginInit();
            this.BarraIzquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.Black;
            this.BarraSuperior.Controls.Add(this.cmdContactos);
            this.BarraSuperior.Controls.Add(this.cmdEmpleados);
            this.BarraSuperior.Controls.Add(this.cmdInicio);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1300, 60);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraSuperior_Paint);
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // cmdInicio
            // 
            this.cmdInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdInicio.Image = ((System.Drawing.Image)(resources.GetObject("cmdInicio.Image")));
            this.cmdInicio.Location = new System.Drawing.Point(0, 3);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(100, 60);
            this.cmdInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdInicio.TabIndex = 3;
            this.cmdInicio.TabStop = false;
            this.cmdInicio.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // BarraIzquierda
            // 
            this.BarraIzquierda.BackColor = System.Drawing.Color.SlateBlue;
            this.BarraIzquierda.Controls.Add(this.cmdRestaurar);
            this.BarraIzquierda.Controls.Add(this.cmdMinimizar);
            this.BarraIzquierda.Controls.Add(this.cmdMaximizar);
            this.BarraIzquierda.Controls.Add(this.cmdCerrar);
            this.BarraIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraIzquierda.Location = new System.Drawing.Point(0, 60);
            this.BarraIzquierda.Name = "BarraIzquierda";
            this.BarraIzquierda.Size = new System.Drawing.Size(40, 590);
            this.BarraIzquierda.TabIndex = 1;
            // 
            // cmdRestaurar
            // 
            this.cmdRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("cmdRestaurar.Image")));
            this.cmdRestaurar.Location = new System.Drawing.Point(8, 524);
            this.cmdRestaurar.Name = "cmdRestaurar";
            this.cmdRestaurar.Size = new System.Drawing.Size(25, 25);
            this.cmdRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdRestaurar.TabIndex = 3;
            this.cmdRestaurar.TabStop = false;
            this.cmdRestaurar.Visible = false;
            this.cmdRestaurar.Click += new System.EventHandler(this.cmdRestaurar_Click);
            // 
            // cmdMinimizar
            // 
            this.cmdMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimizar.Image")));
            this.cmdMinimizar.Location = new System.Drawing.Point(8, 493);
            this.cmdMinimizar.Name = "cmdMinimizar";
            this.cmdMinimizar.Size = new System.Drawing.Size(25, 25);
            this.cmdMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdMinimizar.TabIndex = 2;
            this.cmdMinimizar.TabStop = false;
            this.cmdMinimizar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // cmdMaximizar
            // 
            this.cmdMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMaximizar.Image")));
            this.cmdMaximizar.Location = new System.Drawing.Point(8, 524);
            this.cmdMaximizar.Name = "cmdMaximizar";
            this.cmdMaximizar.Size = new System.Drawing.Size(25, 25);
            this.cmdMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdMaximizar.TabIndex = 1;
            this.cmdMaximizar.TabStop = false;
            this.cmdMaximizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(8, 555);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(25, 25);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdCerrar.TabIndex = 0;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(40, 60);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1260, 590);
            this.PanelPrincipal.TabIndex = 2;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // cmdEmpleados
            // 
            this.cmdEmpleados.BackColor = System.Drawing.Color.Black;
            this.cmdEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdEmpleados.FlatAppearance.BorderSize = 0;
            this.cmdEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.cmdEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEmpleados.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEmpleados.ForeColor = System.Drawing.Color.White;
            this.cmdEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("cmdEmpleados.Image")));
            this.cmdEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEmpleados.Location = new System.Drawing.Point(166, 2);
            this.cmdEmpleados.Name = "cmdEmpleados";
            this.cmdEmpleados.Size = new System.Drawing.Size(241, 58);
            this.cmdEmpleados.TabIndex = 4;
            this.cmdEmpleados.Text = "Empleados";
            this.cmdEmpleados.UseVisualStyleBackColor = false;
            this.cmdEmpleados.Click += new System.EventHandler(this.cmdEmpleados_Click);
            // 
            // cmdContactos
            // 
            this.cmdContactos.BackColor = System.Drawing.Color.Black;
            this.cmdContactos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdContactos.FlatAppearance.BorderSize = 0;
            this.cmdContactos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.cmdContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdContactos.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdContactos.ForeColor = System.Drawing.Color.White;
            this.cmdContactos.Image = ((System.Drawing.Image)(resources.GetObject("cmdContactos.Image")));
            this.cmdContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdContactos.Location = new System.Drawing.Point(643, 2);
            this.cmdContactos.Name = "cmdContactos";
            this.cmdContactos.Size = new System.Drawing.Size(348, 58);
            this.cmdContactos.TabIndex = 5;
            this.cmdContactos.Text = "Contactos / Proveedores";
            this.cmdContactos.UseVisualStyleBackColor = false;
            this.cmdContactos.Click += new System.EventHandler(this.cmdContactos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.BarraIzquierda);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdInicio)).EndInit();
            this.BarraIzquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmdRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Panel BarraIzquierda;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox cmdInicio;
        private System.Windows.Forms.PictureBox cmdMinimizar;
        private System.Windows.Forms.PictureBox cmdMaximizar;
        private System.Windows.Forms.PictureBox cmdCerrar;
        private System.Windows.Forms.PictureBox cmdRestaurar;
        private System.Windows.Forms.Button cmdEmpleados;
        private System.Windows.Forms.Button cmdContactos;
    }
}

