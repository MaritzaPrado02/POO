namespace EmpleadoRestaurante
{
    partial class frmMesero
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
            this.lblDiasTrabajadosM = new System.Windows.Forms.Label();
            this.lblPropinaSemanalM = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtPropinaSemanalM = new System.Windows.Forms.TextBox();
            this.cmbDiasTrabajados = new System.Windows.Forms.ComboBox();
            this.lblSueldoFinal = new System.Windows.Forms.Label();
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldoDiario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDiasTrabajadosM
            // 
            this.lblDiasTrabajadosM.AutoSize = true;
            this.lblDiasTrabajadosM.Location = new System.Drawing.Point(39, 89);
            this.lblDiasTrabajadosM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasTrabajadosM.Name = "lblDiasTrabajadosM";
            this.lblDiasTrabajadosM.Size = new System.Drawing.Size(126, 18);
            this.lblDiasTrabajadosM.TabIndex = 0;
            this.lblDiasTrabajadosM.Text = "Días Trabajados:";
            // 
            // lblPropinaSemanalM
            // 
            this.lblPropinaSemanalM.AutoSize = true;
            this.lblPropinaSemanalM.Location = new System.Drawing.Point(39, 141);
            this.lblPropinaSemanalM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropinaSemanalM.Name = "lblPropinaSemanalM";
            this.lblPropinaSemanalM.Size = new System.Drawing.Size(167, 18);
            this.lblPropinaSemanalM.TabIndex = 1;
            this.lblPropinaSemanalM.Text = "Propina semanal:       $";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(15, 268);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(239, 16);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Su sueldo correspondiente es de    $";
            // 
            // txtPropinaSemanalM
            // 
            this.txtPropinaSemanalM.Location = new System.Drawing.Point(231, 137);
            this.txtPropinaSemanalM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropinaSemanalM.Name = "txtPropinaSemanalM";
            this.txtPropinaSemanalM.Size = new System.Drawing.Size(148, 26);
            this.txtPropinaSemanalM.TabIndex = 4;
            // 
            // cmbDiasTrabajados
            // 
            this.cmbDiasTrabajados.FormattingEnabled = true;
            this.cmbDiasTrabajados.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabajados.Location = new System.Drawing.Point(231, 86);
            this.cmbDiasTrabajados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDiasTrabajados.Name = "cmbDiasTrabajados";
            this.cmbDiasTrabajados.Size = new System.Drawing.Size(80, 26);
            this.cmbDiasTrabajados.TabIndex = 5;
            // 
            // lblSueldoFinal
            // 
            this.lblSueldoFinal.AutoSize = true;
            this.lblSueldoFinal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoFinal.ForeColor = System.Drawing.Color.Red;
            this.lblSueldoFinal.Location = new System.Drawing.Point(283, 266);
            this.lblSueldoFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldoFinal.Name = "lblSueldoFinal";
            this.lblSueldoFinal.Size = new System.Drawing.Size(0, 18);
            this.lblSueldoFinal.TabIndex = 6;
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCalcularSueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularSueldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSueldo.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalcularSueldo.Location = new System.Drawing.Point(127, 198);
            this.btnCalcularSueldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(156, 30);
            this.btnCalcularSueldo.TabIndex = 7;
            this.btnCalcularSueldo.Text = "Calcular sueldo";
            this.btnCalcularSueldo.UseVisualStyleBackColor = false;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sueldo por dia           $";
            // 
            // txtSueldoDiario
            // 
            this.txtSueldoDiario.Location = new System.Drawing.Point(229, 38);
            this.txtSueldoDiario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSueldoDiario.Name = "txtSueldoDiario";
            this.txtSueldoDiario.Size = new System.Drawing.Size(118, 26);
            this.txtSueldoDiario.TabIndex = 9;
            // 
            // frmMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 332);
            this.Controls.Add(this.txtSueldoDiario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.lblSueldoFinal);
            this.Controls.Add(this.cmbDiasTrabajados);
            this.Controls.Add(this.txtPropinaSemanalM);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblPropinaSemanalM);
            this.Controls.Add(this.lblDiasTrabajadosM);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMesero";
            this.Text = "Sueldo Mesero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiasTrabajadosM;
        private System.Windows.Forms.Label lblPropinaSemanalM;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtPropinaSemanalM;
        private System.Windows.Forms.ComboBox cmbDiasTrabajados;
        private System.Windows.Forms.Label lblSueldoFinal;
        private System.Windows.Forms.Button btnCalcularSueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldoDiario;
    }
}