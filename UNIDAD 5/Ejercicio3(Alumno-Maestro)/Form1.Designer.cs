namespace Ejercicio3_Alumno_Maestro_
{
    partial class frmDatos
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
            this.components = new System.ComponentModel.Container();
            this.lblSeleccionarPersona = new System.Windows.Forms.Label();
            this.cmbOcupacion = new System.Windows.Forms.ComboBox();
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grbDatosEspecificos = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblSC = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.grbMaterias = new System.Windows.Forms.GroupBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nudCantidadMaterias = new System.Windows.Forms.TextBox();
            this.grbDatosGenerales.SuspendLayout();
            this.grbDatosEspecificos.SuspendLayout();
            this.grbMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionarPersona
            // 
            this.lblSeleccionarPersona.AutoSize = true;
            this.lblSeleccionarPersona.Location = new System.Drawing.Point(31, 31);
            this.lblSeleccionarPersona.Name = "lblSeleccionarPersona";
            this.lblSeleccionarPersona.Size = new System.Drawing.Size(116, 13);
            this.lblSeleccionarPersona.TabIndex = 0;
            this.lblSeleccionarPersona.Text = "Seleccione ocupación:";
            // 
            // cmbOcupacion
            // 
            this.cmbOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcupacion.FormattingEnabled = true;
            this.cmbOcupacion.Items.AddRange(new object[] {
            "Alumno",
            "Maestro"});
            this.cmbOcupacion.Location = new System.Drawing.Point(183, 28);
            this.cmbOcupacion.Name = "cmbOcupacion";
            this.cmbOcupacion.Size = new System.Drawing.Size(121, 21);
            this.cmbOcupacion.TabIndex = 1;
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
            this.grbDatosGenerales.Location = new System.Drawing.Point(12, 78);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(243, 275);
            this.grbDatosGenerales.TabIndex = 2;
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
            this.txtCurp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSeleccionar.Location = new System.Drawing.Point(327, 26);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(88, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnImprimir.Location = new System.Drawing.Point(469, 445);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            this.grbDatosEspecificos.Location = new System.Drawing.Point(261, 78);
            this.grbDatosEspecificos.Name = "grbDatosEspecificos";
            this.grbDatosEspecificos.Size = new System.Drawing.Size(286, 165);
            this.grbDatosEspecificos.TabIndex = 0;
            this.grbDatosEspecificos.TabStop = false;
            this.grbDatosEspecificos.Text = "Datos especificos";
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
            this.btnRegistrar.Click += new System.EventHandler(this.ctnRegistrar_Click);
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
            this.lblMaterias.Size = new System.Drawing.Size(0, 13);
            this.lblMaterias.TabIndex = 2;
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.Location = new System.Drawing.Point(22, 73);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(0, 13);
            this.lblSC.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(19, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 13);
            this.lblNumero.TabIndex = 0;
            // 
            // grbMaterias
            // 
            this.grbMaterias.Controls.Add(this.txtCalificacion);
            this.grbMaterias.Controls.Add(this.txtMateria);
            this.grbMaterias.Controls.Add(this.lblCalificacion);
            this.grbMaterias.Controls.Add(this.lblNombreMateria);
            this.grbMaterias.Location = new System.Drawing.Point(261, 242);
            this.grbMaterias.Name = "grbMaterias";
            this.grbMaterias.Size = new System.Drawing.Size(285, 111);
            this.grbMaterias.TabIndex = 5;
            this.grbMaterias.TabStop = false;
            this.grbMaterias.Text = "Materias";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(139, 71);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(116, 20);
            this.txtCalificacion.TabIndex = 3;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(139, 40);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(116, 20);
            this.txtMateria.TabIndex = 2;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(22, 74);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(0, 13);
            this.lblCalificacion.TabIndex = 1;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMateria.Location = new System.Drawing.Point(22, 43);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(0, 13);
            this.lblNombreMateria.TabIndex = 0;
            this.lblNombreMateria.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCapturar.Location = new System.Drawing.Point(368, 359);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 6;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Red;
            this.btnGuardar.Location = new System.Drawing.Point(229, 399);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // nudCantidadMaterias
            // 
            this.nudCantidadMaterias.Location = new System.Drawing.Point(36, 137);
            this.nudCantidadMaterias.Name = "nudCantidadMaterias";
            this.nudCantidadMaterias.Size = new System.Drawing.Size(43, 20);
            this.nudCantidadMaterias.TabIndex = 8;
            this.nudCantidadMaterias.TextChanged += new System.EventHandler(this.nudCantidadMaterias_TextChanged);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 480);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.grbMaterias);
            this.Controls.Add(this.grbDatosEspecificos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.grbDatosGenerales);
            this.Controls.Add(this.cmbOcupacion);
            this.Controls.Add(this.lblSeleccionarPersona);
            this.Name = "frmDatos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            this.grbDatosEspecificos.ResumeLayout(false);
            this.grbDatosEspecificos.PerformLayout();
            this.grbMaterias.ResumeLayout(false);
            this.grbMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarPersona;
        private System.Windows.Forms.ComboBox cmbOcupacion;
        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox grbDatosEspecificos;
        private System.Windows.Forms.GroupBox grbMaterias;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox nudCantidadMaterias;
    }
}

