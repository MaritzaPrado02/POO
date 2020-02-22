namespace Calificaciones
{
    partial class frmCalificaciones
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
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.lblNumAprob = new System.Windows.Forms.Label();
            this.lblReprobados = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtNumAprob = new System.Windows.Forms.TextBox();
            this.txtNumReprob = new System.Windows.Forms.TextBox();
            this.txtPromedioGral = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(34, 40);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(101, 13);
            this.lblCalificacion.TabIndex = 0;
            this.lblCalificacion.Text = "Ingrese calificacion:";
            this.lblCalificacion.Click += new System.EventHandler(this.lblCalificacion_Click);
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(155, 37);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(77, 20);
            this.txtCalificacion.TabIndex = 1;
            // 
            // btnCaptura
            // 
            this.btnCaptura.Location = new System.Drawing.Point(145, 93);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(75, 23);
            this.btnCaptura.TabIndex = 2;
            this.btnCaptura.Text = "Capturar";
            this.btnCaptura.UseVisualStyleBackColor = true;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // lblNumAprob
            // 
            this.lblNumAprob.AutoSize = true;
            this.lblNumAprob.Location = new System.Drawing.Point(37, 151);
            this.lblNumAprob.Name = "lblNumAprob";
            this.lblNumAprob.Size = new System.Drawing.Size(61, 13);
            this.lblNumAprob.TabIndex = 3;
            this.lblNumAprob.Text = "Aprobados:";
            // 
            // lblReprobados
            // 
            this.lblReprobados.AutoSize = true;
            this.lblReprobados.Location = new System.Drawing.Point(37, 185);
            this.lblReprobados.Name = "lblReprobados";
            this.lblReprobados.Size = new System.Drawing.Size(68, 13);
            this.lblReprobados.TabIndex = 4;
            this.lblReprobados.Text = "Reprobados:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(117, 219);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "Promedio:";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(90, 295);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 23);
            this.btnReporte.TabIndex = 6;
            this.btnReporte.Text = "Reporte Grupal";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtNumAprob
            // 
            this.txtNumAprob.Location = new System.Drawing.Point(120, 144);
            this.txtNumAprob.Name = "txtNumAprob";
            this.txtNumAprob.Size = new System.Drawing.Size(51, 20);
            this.txtNumAprob.TabIndex = 7;
            // 
            // txtNumReprob
            // 
            this.txtNumReprob.Location = new System.Drawing.Point(120, 178);
            this.txtNumReprob.Name = "txtNumReprob";
            this.txtNumReprob.Size = new System.Drawing.Size(47, 20);
            this.txtNumReprob.TabIndex = 8;
            // 
            // txtPromedioGral
            // 
            this.txtPromedioGral.Location = new System.Drawing.Point(90, 249);
            this.txtPromedioGral.Name = "txtPromedioGral";
            this.txtPromedioGral.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioGral.TabIndex = 9;
            // 
            // frmCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 342);
            this.Controls.Add(this.txtPromedioGral);
            this.Controls.Add(this.txtNumReprob);
            this.Controls.Add(this.txtNumAprob);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblReprobados);
            this.Controls.Add(this.lblNumAprob);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Name = "frmCalificaciones";
            this.Text = "Calificaciones ";
            this.Load += new System.EventHandler(this.frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Label lblNumAprob;
        private System.Windows.Forms.Label lblReprobados;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtNumAprob;
        private System.Windows.Forms.TextBox txtNumReprob;
        private System.Windows.Forms.TextBox txtPromedioGral;
    }
}

