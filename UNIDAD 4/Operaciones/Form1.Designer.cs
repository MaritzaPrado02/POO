namespace Operaciones
{
    partial class frmOperacion
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblResultadoSuma = new System.Windows.Forms.Label();
            this.lblResultadoResta = new System.Windows.Forms.Label();
            this.lblResultadoMultiplicacion = new System.Windows.Forms.Label();
            this.lblResultadoDivision = new System.Windows.Forms.Label();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 33);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(217, 31);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(342, 30);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(45, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "=";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(54, 166);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(0, 13);
            this.lblSuma.TabIndex = 5;
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(54, 208);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(0, 13);
            this.lblResta.TabIndex = 6;
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(54, 249);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(0, 13);
            this.lblMultiplicacion.TabIndex = 7;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(54, 292);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(0, 13);
            this.lblDivision.TabIndex = 8;
            // 
            // lblResultadoSuma
            // 
            this.lblResultadoSuma.AutoSize = true;
            this.lblResultadoSuma.Location = new System.Drawing.Point(176, 166);
            this.lblResultadoSuma.Name = "lblResultadoSuma";
            this.lblResultadoSuma.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoSuma.TabIndex = 9;
            // 
            // lblResultadoResta
            // 
            this.lblResultadoResta.AutoSize = true;
            this.lblResultadoResta.Location = new System.Drawing.Point(176, 208);
            this.lblResultadoResta.Name = "lblResultadoResta";
            this.lblResultadoResta.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoResta.TabIndex = 10;
            // 
            // lblResultadoMultiplicacion
            // 
            this.lblResultadoMultiplicacion.AutoSize = true;
            this.lblResultadoMultiplicacion.Location = new System.Drawing.Point(176, 249);
            this.lblResultadoMultiplicacion.Name = "lblResultadoMultiplicacion";
            this.lblResultadoMultiplicacion.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoMultiplicacion.TabIndex = 11;
            // 
            // lblResultadoDivision
            // 
            this.lblResultadoDivision.AutoSize = true;
            this.lblResultadoDivision.Location = new System.Drawing.Point(176, 292);
            this.lblResultadoDivision.Name = "lblResultadoDivision";
            this.lblResultadoDivision.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoDivision.TabIndex = 12;
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperadores.Location = new System.Drawing.Point(128, 32);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(74, 21);
            this.cmbOperadores.TabIndex = 13;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(402, 30);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 14;
            // 
            // frmOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 76);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cmbOperadores);
            this.Controls.Add(this.lblResultadoDivision);
            this.Controls.Add(this.lblResultadoMultiplicacion);
            this.Controls.Add(this.lblResultadoResta);
            this.Controls.Add(this.lblResultadoSuma);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "frmOperacion";
            this.Text = "Operaciones ";
            this.Load += new System.EventHandler(this.frmOperacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblResultadoSuma;
        private System.Windows.Forms.Label lblResultadoResta;
        private System.Windows.Forms.Label lblResultadoMultiplicacion;
        private System.Windows.Forms.Label lblResultadoDivision;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

