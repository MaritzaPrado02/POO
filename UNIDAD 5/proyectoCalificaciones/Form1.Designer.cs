namespace proyectoCalificaciones
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
            this.grbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.nudCantidadMaterias = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadAlumnos = new System.Windows.Forms.NumericUpDown();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.lblNumeroMaterias = new System.Windows.Forms.Label();
            this.lblNumeroAlumnos = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.grbAlumnos = new System.Windows.Forms.GroupBox();
            this.btnCapturarDatosAlumno = new System.Windows.Forms.Button();
            this.txtNumeroControl = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroControl = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCapturarCalificaciones = new System.Windows.Forms.Button();
            this.grbMaterias = new System.Windows.Forms.GroupBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnCapturarMateria = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnOtraCarrera = new System.Windows.Forms.Button();
            this.lblInstrucción = new System.Windows.Forms.Label();
            this.grbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAlumnos)).BeginInit();
            this.grbAlumnos.SuspendLayout();
            this.grbMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.nudCantidadMaterias);
            this.grbDatosGenerales.Controls.Add(this.nudCantidadAlumnos);
            this.grbDatosGenerales.Controls.Add(this.btnCapturar);
            this.grbDatosGenerales.Controls.Add(this.lblNumeroMaterias);
            this.grbDatosGenerales.Controls.Add(this.lblNumeroAlumnos);
            this.grbDatosGenerales.Controls.Add(this.cmbCarreras);
            this.grbDatosGenerales.Controls.Add(this.lblCarrera);
            this.grbDatosGenerales.Location = new System.Drawing.Point(11, 12);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(352, 144);
            this.grbDatosGenerales.TabIndex = 0;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos generales";
            // 
            // nudCantidadMaterias
            // 
            this.nudCantidadMaterias.Location = new System.Drawing.Point(151, 104);
            this.nudCantidadMaterias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadMaterias.Name = "nudCantidadMaterias";
            this.nudCantidadMaterias.Size = new System.Drawing.Size(42, 20);
            this.nudCantidadMaterias.TabIndex = 5;
            this.nudCantidadMaterias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCantidadAlumnos
            // 
            this.nudCantidadAlumnos.Location = new System.Drawing.Point(151, 68);
            this.nudCantidadAlumnos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadAlumnos.Name = "nudCantidadAlumnos";
            this.nudCantidadAlumnos.Size = new System.Drawing.Size(42, 20);
            this.nudCantidadAlumnos.TabIndex = 4;
            this.nudCantidadAlumnos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(246, 81);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // lblNumeroMaterias
            // 
            this.lblNumeroMaterias.AutoSize = true;
            this.lblNumeroMaterias.Location = new System.Drawing.Point(46, 106);
            this.lblNumeroMaterias.Name = "lblNumeroMaterias";
            this.lblNumeroMaterias.Size = new System.Drawing.Size(101, 13);
            this.lblNumeroMaterias.TabIndex = 3;
            this.lblNumeroMaterias.Text = "Número de materias";
            // 
            // lblNumeroAlumnos
            // 
            this.lblNumeroAlumnos.AutoSize = true;
            this.lblNumeroAlumnos.Location = new System.Drawing.Point(46, 70);
            this.lblNumeroAlumnos.Name = "lblNumeroAlumnos";
            this.lblNumeroAlumnos.Size = new System.Drawing.Size(104, 13);
            this.lblNumeroAlumnos.TabIndex = 2;
            this.lblNumeroAlumnos.Text = "Número de alumnos:";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Items.AddRange(new object[] {
            "IGE",
            "ITIC",
            "IIA"});
            this.cmbCarreras.Location = new System.Drawing.Point(151, 30);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(121, 21);
            this.cmbCarreras.TabIndex = 1;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(46, 33);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(99, 13);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Seleccione carrera:";
            // 
            // grbAlumnos
            // 
            this.grbAlumnos.Controls.Add(this.btnCapturarDatosAlumno);
            this.grbAlumnos.Controls.Add(this.txtNumeroControl);
            this.grbAlumnos.Controls.Add(this.txtNombre);
            this.grbAlumnos.Controls.Add(this.lblNumeroControl);
            this.grbAlumnos.Controls.Add(this.lblNombre);
            this.grbAlumnos.Location = new System.Drawing.Point(10, 291);
            this.grbAlumnos.Name = "grbAlumnos";
            this.grbAlumnos.Size = new System.Drawing.Size(353, 143);
            this.grbAlumnos.TabIndex = 2;
            this.grbAlumnos.TabStop = false;
            this.grbAlumnos.Text = "Datos alumnos";
            // 
            // btnCapturarDatosAlumno
            // 
            this.btnCapturarDatosAlumno.Location = new System.Drawing.Point(189, 103);
            this.btnCapturarDatosAlumno.Name = "btnCapturarDatosAlumno";
            this.btnCapturarDatosAlumno.Size = new System.Drawing.Size(126, 23);
            this.btnCapturarDatosAlumno.TabIndex = 4;
            this.btnCapturarDatosAlumno.Text = "Capturar datos alumno";
            this.btnCapturarDatosAlumno.UseVisualStyleBackColor = true;
            this.btnCapturarDatosAlumno.Click += new System.EventHandler(this.btnCapturarDatosAlumno_Click);
            // 
            // txtNumeroControl
            // 
            this.txtNumeroControl.Location = new System.Drawing.Point(118, 67);
            this.txtNumeroControl.Name = "txtNumeroControl";
            this.txtNumeroControl.Size = new System.Drawing.Size(134, 20);
            this.txtNumeroControl.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNumeroControl
            // 
            this.lblNumeroControl.AutoSize = true;
            this.lblNumeroControl.Location = new System.Drawing.Point(24, 70);
            this.lblNumeroControl.Name = "lblNumeroControl";
            this.lblNumeroControl.Size = new System.Drawing.Size(60, 13);
            this.lblNumeroControl.TabIndex = 1;
            this.lblNumeroControl.Text = "No. Control";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // btnCapturarCalificaciones
            // 
            this.btnCapturarCalificaciones.Location = new System.Drawing.Point(112, 440);
            this.btnCapturarCalificaciones.Name = "btnCapturarCalificaciones";
            this.btnCapturarCalificaciones.Size = new System.Drawing.Size(150, 23);
            this.btnCapturarCalificaciones.TabIndex = 3;
            this.btnCapturarCalificaciones.Text = "Capturar calificaciones";
            this.btnCapturarCalificaciones.UseVisualStyleBackColor = true;
            this.btnCapturarCalificaciones.Click += new System.EventHandler(this.btnCapturarCalificaciones_Click);
            // 
            // grbMaterias
            // 
            this.grbMaterias.Controls.Add(this.txtMateria);
            this.grbMaterias.Controls.Add(this.btnCapturarMateria);
            this.grbMaterias.Controls.Add(this.lblMateria);
            this.grbMaterias.Location = new System.Drawing.Point(10, 168);
            this.grbMaterias.Name = "grbMaterias";
            this.grbMaterias.Size = new System.Drawing.Size(353, 117);
            this.grbMaterias.TabIndex = 4;
            this.grbMaterias.TabStop = false;
            this.grbMaterias.Text = "Capture materias";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(102, 38);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(140, 20);
            this.txtMateria.TabIndex = 2;
            this.txtMateria.TextChanged += new System.EventHandler(this.txtMateria_TextChanged);
            // 
            // btnCapturarMateria
            // 
            this.btnCapturarMateria.Location = new System.Drawing.Point(210, 75);
            this.btnCapturarMateria.Name = "btnCapturarMateria";
            this.btnCapturarMateria.Size = new System.Drawing.Size(105, 23);
            this.btnCapturarMateria.TabIndex = 1;
            this.btnCapturarMateria.Text = "Capturar Materia";
            this.btnCapturarMateria.UseVisualStyleBackColor = true;
            this.btnCapturarMateria.Click += new System.EventHandler(this.btnCapturarMateria_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(40, 41);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(149, 547);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 23);
            this.btnInforme.TabIndex = 5;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnOtraCarrera
            // 
            this.btnOtraCarrera.Location = new System.Drawing.Point(246, 479);
            this.btnOtraCarrera.Name = "btnOtraCarrera";
            this.btnOtraCarrera.Size = new System.Drawing.Size(119, 23);
            this.btnOtraCarrera.TabIndex = 6;
            this.btnOtraCarrera.Text = "Capturar otra carrera ";
            this.btnOtraCarrera.UseVisualStyleBackColor = true;
            this.btnOtraCarrera.Click += new System.EventHandler(this.btnOtraCarrera_Click);
            // 
            // lblInstrucción
            // 
            this.lblInstrucción.AutoSize = true;
            this.lblInstrucción.Location = new System.Drawing.Point(12, 517);
            this.lblInstrucción.Name = "lblInstrucción";
            this.lblInstrucción.Size = new System.Drawing.Size(301, 13);
            this.lblInstrucción.TabIndex = 7;
            this.lblInstrucción.Text = "De Click en informe una vez haya registrado todas las carreras";
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 582);
            this.Controls.Add(this.lblInstrucción);
            this.Controls.Add(this.btnOtraCarrera);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.grbMaterias);
            this.Controls.Add(this.btnCapturarCalificaciones);
            this.Controls.Add(this.grbAlumnos);
            this.Controls.Add(this.grbDatosGenerales);
            this.Name = "frmDatos";
            this.Text = "Capturar Datos Calificaciones";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAlumnos)).EndInit();
            this.grbAlumnos.ResumeLayout(false);
            this.grbAlumnos.PerformLayout();
            this.grbMaterias.ResumeLayout(false);
            this.grbMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.NumericUpDown nudCantidadMaterias;
        private System.Windows.Forms.NumericUpDown nudCantidadAlumnos;
        private System.Windows.Forms.Label lblNumeroMaterias;
        private System.Windows.Forms.Label lblNumeroAlumnos;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.GroupBox grbAlumnos;
        private System.Windows.Forms.TextBox txtNumeroControl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumeroControl;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCapturarCalificaciones;
        private System.Windows.Forms.GroupBox grbMaterias;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnCapturarMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnCapturarDatosAlumno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnOtraCarrera;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Label lblInstrucción;
    }
}

