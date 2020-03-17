namespace EmpleadoRestaurante
{
    partial class frmRepartidor
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
            this.lblSueldoDiarioRep = new System.Windows.Forms.Label();
            this.lblDiasTrabajadosRep = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.lblCantidadPedidos = new System.Windows.Forms.Label();
            this.lblSueldoCorrespondiente = new System.Windows.Forms.Label();
            this.lblSueldoFinalRep = new System.Windows.Forms.Label();
            this.txtSueldoDiarioRep = new System.Windows.Forms.TextBox();
            this.cmbDiasTrabajadosRep = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.txtCantidadPedidos = new System.Windows.Forms.TextBox();
            this.btnCalcularSueldoRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSueldoDiarioRep
            // 
            this.lblSueldoDiarioRep.AutoSize = true;
            this.lblSueldoDiarioRep.Location = new System.Drawing.Point(29, 28);
            this.lblSueldoDiarioRep.Name = "lblSueldoDiarioRep";
            this.lblSueldoDiarioRep.Size = new System.Drawing.Size(151, 18);
            this.lblSueldoDiarioRep.TabIndex = 0;
            this.lblSueldoDiarioRep.Text = "Sueldo por dia        $";
            // 
            // lblDiasTrabajadosRep
            // 
            this.lblDiasTrabajadosRep.AutoSize = true;
            this.lblDiasTrabajadosRep.Location = new System.Drawing.Point(29, 75);
            this.lblDiasTrabajadosRep.Name = "lblDiasTrabajadosRep";
            this.lblDiasTrabajadosRep.Size = new System.Drawing.Size(127, 18);
            this.lblDiasTrabajadosRep.TabIndex = 1;
            this.lblDiasTrabajadosRep.Text = "Dias Trabajados:";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(29, 124);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(43, 18);
            this.lblZona.TabIndex = 2;
            this.lblZona.Text = "Zona";
            // 
            // lblCantidadPedidos
            // 
            this.lblCantidadPedidos.AutoSize = true;
            this.lblCantidadPedidos.Location = new System.Drawing.Point(29, 167);
            this.lblCantidadPedidos.Name = "lblCantidadPedidos";
            this.lblCantidadPedidos.Size = new System.Drawing.Size(159, 18);
            this.lblCantidadPedidos.TabIndex = 3;
            this.lblCantidadPedidos.Text = "Cantidad de pedidos:";
            // 
            // lblSueldoCorrespondiente
            // 
            this.lblSueldoCorrespondiente.AutoSize = true;
            this.lblSueldoCorrespondiente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoCorrespondiente.Location = new System.Drawing.Point(11, 260);
            this.lblSueldoCorrespondiente.Name = "lblSueldoCorrespondiente";
            this.lblSueldoCorrespondiente.Size = new System.Drawing.Size(255, 16);
            this.lblSueldoCorrespondiente.TabIndex = 4;
            this.lblSueldoCorrespondiente.Text = "Su sueldo correspondiente es de        $";
            // 
            // lblSueldoFinalRep
            // 
            this.lblSueldoFinalRep.AutoSize = true;
            this.lblSueldoFinalRep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoFinalRep.ForeColor = System.Drawing.Color.Red;
            this.lblSueldoFinalRep.Location = new System.Drawing.Point(272, 258);
            this.lblSueldoFinalRep.Name = "lblSueldoFinalRep";
            this.lblSueldoFinalRep.Size = new System.Drawing.Size(0, 19);
            this.lblSueldoFinalRep.TabIndex = 5;
            // 
            // txtSueldoDiarioRep
            // 
            this.txtSueldoDiarioRep.Location = new System.Drawing.Point(187, 25);
            this.txtSueldoDiarioRep.Name = "txtSueldoDiarioRep";
            this.txtSueldoDiarioRep.Size = new System.Drawing.Size(100, 26);
            this.txtSueldoDiarioRep.TabIndex = 6;
            // 
            // cmbDiasTrabajadosRep
            // 
            this.cmbDiasTrabajadosRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasTrabajadosRep.FormattingEnabled = true;
            this.cmbDiasTrabajadosRep.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabajadosRep.Location = new System.Drawing.Point(187, 72);
            this.cmbDiasTrabajadosRep.Name = "cmbDiasTrabajadosRep";
            this.cmbDiasTrabajadosRep.Size = new System.Drawing.Size(56, 26);
            this.cmbDiasTrabajadosRep.TabIndex = 7;
            // 
            // cmbZona
            // 
            this.cmbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbZona.Location = new System.Drawing.Point(187, 116);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(56, 26);
            this.cmbZona.TabIndex = 8;
            // 
            // txtCantidadPedidos
            // 
            this.txtCantidadPedidos.Location = new System.Drawing.Point(187, 159);
            this.txtCantidadPedidos.Name = "txtCantidadPedidos";
            this.txtCantidadPedidos.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadPedidos.TabIndex = 9;
            // 
            // btnCalcularSueldoRep
            // 
            this.btnCalcularSueldoRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcularSueldoRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularSueldoRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularSueldoRep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSueldoRep.Location = new System.Drawing.Point(119, 210);
            this.btnCalcularSueldoRep.Name = "btnCalcularSueldoRep";
            this.btnCalcularSueldoRep.Size = new System.Drawing.Size(124, 25);
            this.btnCalcularSueldoRep.TabIndex = 10;
            this.btnCalcularSueldoRep.Text = "Calcular sueldo";
            this.btnCalcularSueldoRep.UseVisualStyleBackColor = false;
            this.btnCalcularSueldoRep.Click += new System.EventHandler(this.btnCalcularSueldoRep_Click);
            // 
            // frmRepartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 296);
            this.Controls.Add(this.btnCalcularSueldoRep);
            this.Controls.Add(this.txtCantidadPedidos);
            this.Controls.Add(this.cmbZona);
            this.Controls.Add(this.cmbDiasTrabajadosRep);
            this.Controls.Add(this.txtSueldoDiarioRep);
            this.Controls.Add(this.lblSueldoFinalRep);
            this.Controls.Add(this.lblSueldoCorrespondiente);
            this.Controls.Add(this.lblCantidadPedidos);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.lblDiasTrabajadosRep);
            this.Controls.Add(this.lblSueldoDiarioRep);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRepartidor";
            this.Text = "Sueldo repartidor";
            this.Load += new System.EventHandler(this.frmRepartidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSueldoDiarioRep;
        private System.Windows.Forms.Label lblDiasTrabajadosRep;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label lblCantidadPedidos;
        private System.Windows.Forms.Label lblSueldoCorrespondiente;
        private System.Windows.Forms.Label lblSueldoFinalRep;
        private System.Windows.Forms.TextBox txtSueldoDiarioRep;
        private System.Windows.Forms.ComboBox cmbDiasTrabajadosRep;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.TextBox txtCantidadPedidos;
        private System.Windows.Forms.Button btnCalcularSueldoRep;
    }
}