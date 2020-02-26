namespace Mayor_de_edad
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
            this.btnBotonEvaluarEdad = new System.Windows.Forms.Button();
            this.lblIngresarFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblMayorDeEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBotonEvaluarEdad
            // 
            this.btnBotonEvaluarEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBotonEvaluarEdad.Location = new System.Drawing.Point(88, 126);
            this.btnBotonEvaluarEdad.Name = "btnBotonEvaluarEdad";
            this.btnBotonEvaluarEdad.Size = new System.Drawing.Size(97, 23);
            this.btnBotonEvaluarEdad.TabIndex = 0;
            this.btnBotonEvaluarEdad.Text = "Evaluar edad";
            this.btnBotonEvaluarEdad.UseVisualStyleBackColor = false;
            this.btnBotonEvaluarEdad.Click += new System.EventHandler(this.btnBotonEvaluarEdad_Click);
            // 
            // lblIngresarFecha
            // 
            this.lblIngresarFecha.AutoSize = true;
            this.lblIngresarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarFecha.Location = new System.Drawing.Point(23, 29);
            this.lblIngresarFecha.Name = "lblIngresarFecha";
            this.lblIngresarFecha.Size = new System.Drawing.Size(207, 16);
            this.lblIngresarFecha.TabIndex = 1;
            this.lblIngresarFecha.Text = "Ingrese fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(85, 69);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // lblMayorDeEdad
            // 
            this.lblMayorDeEdad.AutoSize = true;
            this.lblMayorDeEdad.Location = new System.Drawing.Point(94, 165);
            this.lblMayorDeEdad.Name = "lblMayorDeEdad";
            this.lblMayorDeEdad.Size = new System.Drawing.Size(0, 13);
            this.lblMayorDeEdad.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.lblMayorDeEdad);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblIngresarFecha);
            this.Controls.Add(this.btnBotonEvaluarEdad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Mayor de edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBotonEvaluarEdad;
        private System.Windows.Forms.Label lblIngresarFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblMayorDeEdad;
    }
}

