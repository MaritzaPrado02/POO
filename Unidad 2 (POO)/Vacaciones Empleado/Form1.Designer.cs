namespace Vacaciones_Empleado
{
    partial class frmAñosTrabajadosEmpleado
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
            this.lblAñosTrabajados = new System.Windows.Forms.Label();
            this.txtAñosTrabajados = new System.Windows.Forms.TextBox();
            this.lblAños = new System.Windows.Forms.Label();
            this.btnCalcularVacaciones = new System.Windows.Forms.Button();
            this.lblCorrespondencia = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAñosTrabajados
            // 
            this.lblAñosTrabajados.AutoSize = true;
            this.lblAñosTrabajados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñosTrabajados.Location = new System.Drawing.Point(12, 54);
            this.lblAñosTrabajados.Name = "lblAñosTrabajados";
            this.lblAñosTrabajados.Size = new System.Drawing.Size(145, 20);
            this.lblAñosTrabajados.TabIndex = 0;
            this.lblAñosTrabajados.Text = "Años trabajados:";
            // 
            // txtAñosTrabajados
            // 
            this.txtAñosTrabajados.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAñosTrabajados.Location = new System.Drawing.Point(163, 54);
            this.txtAñosTrabajados.Name = "txtAñosTrabajados";
            this.txtAñosTrabajados.Size = new System.Drawing.Size(82, 20);
            this.txtAñosTrabajados.TabIndex = 1;
            // 
            // lblAños
            // 
            this.lblAños.AutoSize = true;
            this.lblAños.Location = new System.Drawing.Point(251, 59);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(30, 13);
            this.lblAños.TabIndex = 2;
            this.lblAños.Text = "años";
            // 
            // btnCalcularVacaciones
            // 
            this.btnCalcularVacaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalcularVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularVacaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalcularVacaciones.Location = new System.Drawing.Point(222, 100);
            this.btnCalcularVacaciones.Name = "btnCalcularVacaciones";
            this.btnCalcularVacaciones.Size = new System.Drawing.Size(168, 34);
            this.btnCalcularVacaciones.TabIndex = 3;
            this.btnCalcularVacaciones.Text = "Calcular Vacaciones";
            this.btnCalcularVacaciones.UseVisualStyleBackColor = false;
            this.btnCalcularVacaciones.Click += new System.EventHandler(this.btnCalcularVacaciones_Click);
            // 
            // lblCorrespondencia
            // 
            this.lblCorrespondencia.AutoSize = true;
            this.lblCorrespondencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrespondencia.Location = new System.Drawing.Point(13, 172);
            this.lblCorrespondencia.Name = "lblCorrespondencia";
            this.lblCorrespondencia.Size = new System.Drawing.Size(204, 18);
            this.lblCorrespondencia.TabIndex = 4;
            this.lblCorrespondencia.Text = "Al empleado le corresponden ";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(264, 172);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(134, 18);
            this.lblDias.TabIndex = 6;
            this.lblDias.Text = "días de vacaciones";
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Enabled = false;
            this.txtCantidadDias.Location = new System.Drawing.Point(218, 173);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(40, 20);
            this.txtCantidadDias.TabIndex = 7;
            // 
            // frmAñosTrabajadosEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(402, 226);
            this.Controls.Add(this.txtCantidadDias);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblCorrespondencia);
            this.Controls.Add(this.btnCalcularVacaciones);
            this.Controls.Add(this.lblAños);
            this.Controls.Add(this.txtAñosTrabajados);
            this.Controls.Add(this.lblAñosTrabajados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAñosTrabajadosEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frmAñosTrabajadosEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAñosTrabajados;
        private System.Windows.Forms.TextBox txtAñosTrabajados;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.Button btnCalcularVacaciones;
        private System.Windows.Forms.Label lblCorrespondencia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtCantidadDias;
    }
}

