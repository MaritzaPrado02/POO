namespace ProgramaTorneo
{
    partial class frmTorneo
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
            this.lblNombreTorneo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.nudNumeroEquipos = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblGanado = new System.Windows.Forms.Label();
            this.lblEmpate = new System.Windows.Forms.Label();
            this.lblPerdido = new System.Windows.Forms.Label();
            this.nudPuntosGanado = new System.Windows.Forms.NumericUpDown();
            this.nudPuntosEmpate = new System.Windows.Forms.NumericUpDown();
            this.nudPuntosPerdido = new System.Windows.Forms.NumericUpDown();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDatosGenerales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosGanado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosEmpate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosPerdido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosGenerales
            // 
            this.grbDatosGenerales.Controls.Add(this.dtpFechaFin);
            this.grbDatosGenerales.Controls.Add(this.dtpFechaInicio);
            this.grbDatosGenerales.Controls.Add(this.nudNumeroEquipos);
            this.grbDatosGenerales.Controls.Add(this.txtNombreTorneo);
            this.grbDatosGenerales.Controls.Add(this.groupBox1);
            this.grbDatosGenerales.Controls.Add(this.lblFechaFin);
            this.grbDatosGenerales.Controls.Add(this.lblFechaInicio);
            this.grbDatosGenerales.Controls.Add(this.label2);
            this.grbDatosGenerales.Controls.Add(this.lblNombreTorneo);
            this.grbDatosGenerales.Location = new System.Drawing.Point(13, 13);
            this.grbDatosGenerales.Name = "grbDatosGenerales";
            this.grbDatosGenerales.Size = new System.Drawing.Size(402, 289);
            this.grbDatosGenerales.TabIndex = 0;
            this.grbDatosGenerales.TabStop = false;
            this.grbDatosGenerales.Text = "Datos Torneo";
            // 
            // lblNombreTorneo
            // 
            this.lblNombreTorneo.AutoSize = true;
            this.lblNombreTorneo.Location = new System.Drawing.Point(32, 26);
            this.lblNombreTorneo.Name = "lblNombreTorneo";
            this.lblNombreTorneo.Size = new System.Drawing.Size(101, 13);
            this.lblNombreTorneo.TabIndex = 0;
            this.lblNombreTorneo.Text = "Nombre del Torneo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de equipos:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(32, 104);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(32, 150);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lblFechaFin.TabIndex = 3;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudPuntosPerdido);
            this.groupBox1.Controls.Add(this.nudPuntosEmpate);
            this.groupBox1.Controls.Add(this.nudPuntosGanado);
            this.groupBox1.Controls.Add(this.lblPerdido);
            this.groupBox1.Controls.Add(this.lblEmpate);
            this.groupBox1.Controls.Add(this.lblGanado);
            this.groupBox1.Location = new System.Drawing.Point(7, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntos por juego...";
            // 
            // txtNombreTorneo
            // 
            this.txtNombreTorneo.Location = new System.Drawing.Point(170, 23);
            this.txtNombreTorneo.Name = "txtNombreTorneo";
            this.txtNombreTorneo.Size = new System.Drawing.Size(129, 20);
            this.txtNombreTorneo.TabIndex = 5;
            // 
            // nudNumeroEquipos
            // 
            this.nudNumeroEquipos.Location = new System.Drawing.Point(170, 57);
            this.nudNumeroEquipos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumeroEquipos.Name = "nudNumeroEquipos";
            this.nudNumeroEquipos.Size = new System.Drawing.Size(40, 20);
            this.nudNumeroEquipos.TabIndex = 6;
            this.nudNumeroEquipos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(170, 96);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(170, 142);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 8;
            // 
            // lblGanado
            // 
            this.lblGanado.AutoSize = true;
            this.lblGanado.Location = new System.Drawing.Point(25, 31);
            this.lblGanado.Name = "lblGanado";
            this.lblGanado.Size = new System.Drawing.Size(45, 13);
            this.lblGanado.TabIndex = 0;
            this.lblGanado.Text = "Ganado";
            // 
            // lblEmpate
            // 
            this.lblEmpate.AutoSize = true;
            this.lblEmpate.Location = new System.Drawing.Point(25, 67);
            this.lblEmpate.Name = "lblEmpate";
            this.lblEmpate.Size = new System.Drawing.Size(43, 13);
            this.lblEmpate.TabIndex = 1;
            this.lblEmpate.Text = "Empate";
            // 
            // lblPerdido
            // 
            this.lblPerdido.AutoSize = true;
            this.lblPerdido.Location = new System.Drawing.Point(190, 26);
            this.lblPerdido.Name = "lblPerdido";
            this.lblPerdido.Size = new System.Drawing.Size(43, 13);
            this.lblPerdido.TabIndex = 2;
            this.lblPerdido.Text = "Perdido";
            // 
            // nudPuntosGanado
            // 
            this.nudPuntosGanado.Location = new System.Drawing.Point(112, 29);
            this.nudPuntosGanado.Name = "nudPuntosGanado";
            this.nudPuntosGanado.Size = new System.Drawing.Size(39, 20);
            this.nudPuntosGanado.TabIndex = 3;
            // 
            // nudPuntosEmpate
            // 
            this.nudPuntosEmpate.Location = new System.Drawing.Point(112, 65);
            this.nudPuntosEmpate.Name = "nudPuntosEmpate";
            this.nudPuntosEmpate.Size = new System.Drawing.Size(39, 20);
            this.nudPuntosEmpate.TabIndex = 4;
            // 
            // nudPuntosPerdido
            // 
            this.nudPuntosPerdido.Location = new System.Drawing.Point(267, 19);
            this.nudPuntosPerdido.Name = "nudPuntosPerdido";
            this.nudPuntosPerdido.Size = new System.Drawing.Size(38, 20);
            this.nudPuntosPerdido.TabIndex = 5;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(166, 308);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(158, 353);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(95, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir datos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 390);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.grbDatosGenerales);
            this.Name = "frmTorneo";
            this.Text = "Torneo";
            this.grbDatosGenerales.ResumeLayout(false);
            this.grbDatosGenerales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosGanado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosEmpate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosPerdido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosGenerales;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.NumericUpDown nudNumeroEquipos;
        private System.Windows.Forms.TextBox txtNombreTorneo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudPuntosPerdido;
        private System.Windows.Forms.NumericUpDown nudPuntosEmpate;
        private System.Windows.Forms.NumericUpDown nudPuntosGanado;
        private System.Windows.Forms.Label lblPerdido;
        private System.Windows.Forms.Label lblEmpate;
        private System.Windows.Forms.Label lblGanado;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreTorneo;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

