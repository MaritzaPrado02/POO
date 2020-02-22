namespace ConvertidorGrados
{
    partial class frmConvertidor
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
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.cmbTemperatura = new System.Windows.Forms.ComboBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblIgual = new System.Windows.Forms.Label();
            this.txtResultadoConversion = new System.Windows.Forms.TextBox();
            this.lblGradosResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblIndicacion.Location = new System.Drawing.Point(83, 31);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(164, 16);
            this.lblIndicacion.TabIndex = 0;
            this.lblIndicacion.Text = "Ingrese la temperatura";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTemperatura.Location = new System.Drawing.Point(12, 73);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(97, 16);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(115, 69);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(70, 20);
            this.txtTemperatura.TabIndex = 2;
            // 
            // cmbTemperatura
            // 
            this.cmbTemperatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemperatura.FormattingEnabled = true;
            this.cmbTemperatura.Items.AddRange(new object[] {
            "Centigrados",
            "Fahrenheit"});
            this.cmbTemperatura.Location = new System.Drawing.Point(211, 68);
            this.cmbTemperatura.Name = "cmbTemperatura";
            this.cmbTemperatura.Size = new System.Drawing.Size(101, 21);
            this.cmbTemperatura.TabIndex = 3;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.BackColor = System.Drawing.Color.Transparent;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(189, 57);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(16, 20);
            this.lblGrado.TabIndex = 4;
            this.lblGrado.Text = "◦";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConvertir.Location = new System.Drawing.Point(150, 111);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(97, 28);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(53, 165);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 6;
            this.lblIgual.Text = "=";
            // 
            // txtResultadoConversion
            // 
            this.txtResultadoConversion.Enabled = false;
            this.txtResultadoConversion.Location = new System.Drawing.Point(86, 162);
            this.txtResultadoConversion.Name = "txtResultadoConversion";
            this.txtResultadoConversion.Size = new System.Drawing.Size(115, 20);
            this.txtResultadoConversion.TabIndex = 7;
            // 
            // lblGradosResultado
            // 
            this.lblGradosResultado.AutoSize = true;
            this.lblGradosResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosResultado.Location = new System.Drawing.Point(207, 158);
            this.lblGradosResultado.Name = "lblGradosResultado";
            this.lblGradosResultado.Size = new System.Drawing.Size(16, 20);
            this.lblGradosResultado.TabIndex = 8;
            this.lblGradosResultado.Text = "◦";
            this.lblGradosResultado.Click += new System.EventHandler(this.lblGradosResultado_Click);
            // 
            // frmConvertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(320, 224);
            this.Controls.Add(this.lblGradosResultado);
            this.Controls.Add(this.txtResultadoConversion);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.cmbTemperatura);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblIndicacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConvertidor";
            this.Text = "Convertidor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.ComboBox cmbTemperatura;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.TextBox txtResultadoConversion;
        private System.Windows.Forms.Label lblGradosResultado;
    }
}

