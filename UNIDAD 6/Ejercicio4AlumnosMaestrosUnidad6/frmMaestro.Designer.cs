namespace Ejercicio4AlumnosMaestrosUnidad6
{
    partial class frmMaestro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbMaterias = new System.Windows.Forms.GroupBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.grbDatosEspecificos = new System.Windows.Forms.GroupBox();
            this.nudCantidadMaterias = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblSC = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCurp = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrarMaestros = new System.Windows.Forms.Button();
            this.nudCantidadMaestros = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadAlumnos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.grbMaterias.SuspendLayout();
            this.grbDatosEspecificos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMaterias)).BeginInit();
            this.grbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMaestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Red;
            this.btnGuardar.Location = new System.Drawing.Point(429, 409);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grbMaterias
            // 
            this.grbMaterias.Controls.Add(this.btnCapturar);
            this.grbMaterias.Controls.Add(this.txtMateria);
            this.grbMaterias.Controls.Add(this.lblNombreMateria);
            this.grbMaterias.Location = new System.Drawing.Point(261, 245);
            this.grbMaterias.Name = "grbMaterias";
            this.grbMaterias.Size = new System.Drawing.Size(285, 147);
            this.grbMaterias.TabIndex = 10;
            this.grbMaterias.TabStop = false;
            this.grbMaterias.Text = "Materias";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCapturar.Location = new System.Drawing.Point(107, 94);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 6;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(139, 40);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(116, 20);
            this.txtMateria.TabIndex = 2;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(22, 43);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(53, 13);
            this.lblNombreMateria.TabIndex = 0;
            this.lblNombreMateria.Text = "Materia:";
            // 
            // grbDatosEspecificos
            // 
            this.grbDatosEspecificos.Controls.Add(this.nudCantidadMaterias);
            this.grbDatosEspecificos.Controls.Add(this.btnRegistrar);
            this.grbDatosEspecificos.Controls.Add(this.txtSC);
            this.grbDatosEspecificos.Controls.Add(this.txtNumero);
            this.grbDatosEspecificos.Controls.Add(this.lblMaterias);
            this.grbDatosEspecificos.Controls.Add(this.lblSC);
            this.grbDatosEspecificos.Controls.Add(this.lblNumero);
            this.grbDatosEspecificos.Location = new System.Drawing.Point(261, 81);
            this.grbDatosEspecificos.Name = "grbDatosEspecificos";
            this.grbDatosEspecificos.Size = new System.Drawing.Size(286, 165);
            this.grbDatosEspecificos.TabIndex = 8;
            this.grbDatosEspecificos.TabStop = false;
            this.grbDatosEspecificos.Text = "Datos especificos";
            this.grbDatosEspecificos.Enter += new System.EventHandler(this.grbDatosEspecificos_Enter);
            // 
            // nudCantidadMaterias
            // 
            this.nudCantidadMaterias.Location = new System.Drawing.Point(41, 135);
            this.nudCantidadMaterias.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCantidadMaterias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadMaterias.Name = "nudCantidadMaterias";
            this.nudCantidadMaterias.Size = new System.Drawing.Size(42, 20);
            this.nudCantidadMaterias.TabIndex = 8;
            this.nudCantidadMaterias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Blue;
            this.btnRegistrar.Location = new System.Drawing.Point(107, 135);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtSC
            // 
            this.txtSC.Location = new System.Drawing.Point(22, 88);
            this.txtSC.Name = "txtSC";
            this.txtSC.Size = new System.Drawing.Size(150, 20);
            this.txtSC.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(22, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.Location = new System.Drawing.Point(22, 115);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(200, 13);
            this.lblMaterias.TabIndex = 2;
            this.lblMaterias.Text = "Cantidad de materias que imparte:";
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.Location = new System.Drawing.Point(22, 73);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(50, 13);
            this.lblSC.TabIndex = 1;
            this.lblSC.Text = "Sueldo:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(19, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(120, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número de maestro:";
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.txtEmail);
            this.grbDatosGenerales.Controls.Add(this.txtTelefono);
            this.grbDatosGenerales.Controls.Add(this.dtpFechaNacimiento);
            this.grbDatosGenerales.Controls.Add(this.txtCurp);
            this.grbDatosGenerales.Controls.Add(this.txtNombre);
            this.grbDatosGenerales.Controls.Add(this.lblEmail);
            this.grbDatosGenerales.Controls.Add(this.lblTelefono);
            this.grbDatosGenerales.Controls.Add(this.lblCurp);
            this.grbDatosGenerales.Controls.Add(this.lblFechaNacimiento);
            this.grbDatosGenerales.Controls.Add(this.lblNombre);
            this.grbDatosGenerales.Location = new System.Drawing.Point(12, 81);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(243, 311);
            this.grbDatosGenerales.TabIndex = 9;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos generales";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(22, 93);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(22, 145);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(195, 20);
            this.txtCurp.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 223);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(19, 176);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurp.Location = new System.Drawing.Point(19, 129);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(33, 13);
            this.lblCurp.TabIndex = 2;
            this.lblCurp.Text = "Curp";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(19, 77);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(125, 13);
            this.lblFechaNacimiento.TabIndex = 1;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnRegistrarMaestros
            // 
            this.btnRegistrarMaestros.Location = new System.Drawing.Point(279, 35);
            this.btnRegistrarMaestros.Name = "btnRegistrarMaestros";
            this.btnRegistrarMaestros.Size = new System.Drawing.Size(107, 23);
            this.btnRegistrarMaestros.TabIndex = 17;
            this.btnRegistrarMaestros.Text = "Registrar maestros";
            this.btnRegistrarMaestros.UseVisualStyleBackColor = true;
            this.btnRegistrarMaestros.Click += new System.EventHandler(this.btnRegistrarAlumnos_Click);
            // 
            // nudCantidadMaestros
            // 
            this.nudCantidadMaestros.Location = new System.Drawing.Point(201, 35);
            this.nudCantidadMaestros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadMaestros.Name = "nudCantidadMaestros";
            this.nudCantidadMaestros.Size = new System.Drawing.Size(47, 20);
            this.nudCantidadMaestros.TabIndex = 16;
            this.nudCantidadMaestros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidadAlumnos
            // 
            this.lblCantidadAlumnos.AutoSize = true;
            this.lblCantidadAlumnos.Location = new System.Drawing.Point(22, 37);
            this.lblCantidadAlumnos.Name = "lblCantidadAlumnos";
            this.lblCantidadAlumnos.Size = new System.Drawing.Size(161, 13);
            this.lblCantidadAlumnos.TabIndex = 15;
            this.lblCantidadAlumnos.Text = "Cantidad de maestros a registrar:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImprimir.Location = new System.Drawing.Point(238, 435);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(469, 465);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 19;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(469, 492);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 20;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 527);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnRegistrarMaestros);
            this.Controls.Add(this.nudCantidadMaestros);
            this.Controls.Add(this.lblCantidadAlumnos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbMaterias);
            this.Controls.Add(this.grbDatosEspecificos);
            this.Controls.Add(this.grbDatosGenerales);
            this.Name = "frmMaestro";
            this.Text = "frmMaestro";
            this.Load += new System.EventHandler(this.frmMaestro_Load);
            this.grbMaterias.ResumeLayout(false);
            this.grbMaterias.PerformLayout();
            this.grbDatosEspecificos.ResumeLayout(false);
            this.grbDatosEspecificos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMaterias)).EndInit();
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMaestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grbMaterias;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.GroupBox grbDatosEspecificos;
        private System.Windows.Forms.NumericUpDown nudCantidadMaterias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrarMaestros;
        private System.Windows.Forms.NumericUpDown nudCantidadMaestros;
        private System.Windows.Forms.Label lblCantidadAlumnos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnLeer;
    }
}