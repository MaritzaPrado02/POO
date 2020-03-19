namespace EmpleadoRestaurante
{
    partial class frmCajero
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiasTrabajadosCaj = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblSueldoCaj = new System.Windows.Forms.Label();
            this.txtSueldoDiarioCaj = new System.Windows.Forms.TextBox();
            this.cmbDiasTrabajadosCaj = new System.Windows.Forms.ComboBox();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.lblSueldoFinalCaj = new System.Windows.Forms.Label();
            this.btnCalcularSueldoCaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo por día        $";
            // 
            // lblDiasTrabajadosCaj
            // 
            this.lblDiasTrabajadosCaj.AutoSize = true;
            this.lblDiasTrabajadosCaj.Location = new System.Drawing.Point(39, 85);
            this.lblDiasTrabajadosCaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiasTrabajadosCaj.Name = "lblDiasTrabajadosCaj";
            this.lblDiasTrabajadosCaj.Size = new System.Drawing.Size(126, 18);
            this.lblDiasTrabajadosCaj.TabIndex = 1;
            this.lblDiasTrabajadosCaj.Text = "Días Trabajados:";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Location = new System.Drawing.Point(66, 138);
            this.lblCaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(45, 18);
            this.lblCaja.TabIndex = 2;
            this.lblCaja.Text = "Caja:";
            // 
            // lblSueldoCaj
            // 
            this.lblSueldoCaj.AutoSize = true;
            this.lblSueldoCaj.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoCaj.Location = new System.Drawing.Point(26, 249);
            this.lblSueldoCaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldoCaj.Name = "lblSueldoCaj";
            this.lblSueldoCaj.Size = new System.Drawing.Size(222, 14);
            this.lblSueldoCaj.TabIndex = 3;
            this.lblSueldoCaj.Text = "Su sueldo correspondiente es de        $";
            // 
            // txtSueldoDiarioCaj
            // 
            this.txtSueldoDiarioCaj.Location = new System.Drawing.Point(202, 33);
            this.txtSueldoDiarioCaj.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldoDiarioCaj.Name = "txtSueldoDiarioCaj";
            this.txtSueldoDiarioCaj.Size = new System.Drawing.Size(148, 26);
            this.txtSueldoDiarioCaj.TabIndex = 4;
            // 
            // cmbDiasTrabajadosCaj
            // 
            this.cmbDiasTrabajadosCaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasTrabajadosCaj.FormattingEnabled = true;
            this.cmbDiasTrabajadosCaj.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabajadosCaj.Location = new System.Drawing.Point(202, 82);
            this.cmbDiasTrabajadosCaj.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiasTrabajadosCaj.Name = "cmbDiasTrabajadosCaj";
            this.cmbDiasTrabajadosCaj.Size = new System.Drawing.Size(88, 26);
            this.cmbDiasTrabajadosCaj.TabIndex = 5;
            // 
            // cmbCaja
            // 
            this.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCaja.Location = new System.Drawing.Point(202, 130);
            this.cmbCaja.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(68, 26);
            this.cmbCaja.TabIndex = 6;
            // 
            // lblSueldoFinalCaj
            // 
            this.lblSueldoFinalCaj.AutoSize = true;
            this.lblSueldoFinalCaj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoFinalCaj.ForeColor = System.Drawing.Color.Red;
            this.lblSueldoFinalCaj.Location = new System.Drawing.Point(266, 247);
            this.lblSueldoFinalCaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldoFinalCaj.Name = "lblSueldoFinalCaj";
            this.lblSueldoFinalCaj.Size = new System.Drawing.Size(0, 16);
            this.lblSueldoFinalCaj.TabIndex = 7;
            // 
            // btnCalcularSueldoCaj
            // 
            this.btnCalcularSueldoCaj.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCalcularSueldoCaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularSueldoCaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularSueldoCaj.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSueldoCaj.ForeColor = System.Drawing.Color.Red;
            this.btnCalcularSueldoCaj.Location = new System.Drawing.Point(142, 193);
            this.btnCalcularSueldoCaj.Name = "btnCalcularSueldoCaj";
            this.btnCalcularSueldoCaj.Size = new System.Drawing.Size(106, 23);
            this.btnCalcularSueldoCaj.TabIndex = 8;
            this.btnCalcularSueldoCaj.Text = "Calcular sueldo";
            this.btnCalcularSueldoCaj.UseVisualStyleBackColor = false;
            this.btnCalcularSueldoCaj.Click += new System.EventHandler(this.btnCalcularSueldoCaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 287);
            this.Controls.Add(this.btnCalcularSueldoCaj);
            this.Controls.Add(this.lblSueldoFinalCaj);
            this.Controls.Add(this.cmbCaja);
            this.Controls.Add(this.cmbDiasTrabajadosCaj);
            this.Controls.Add(this.txtSueldoDiarioCaj);
            this.Controls.Add(this.lblSueldoCaj);
            this.Controls.Add(this.lblCaja);
            this.Controls.Add(this.lblDiasTrabajadosCaj);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCajero";
            this.Text = "Sueldo cajero";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiasTrabajadosCaj;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label lblSueldoCaj;
        private System.Windows.Forms.TextBox txtSueldoDiarioCaj;
        private System.Windows.Forms.ComboBox cmbDiasTrabajadosCaj;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.Label lblSueldoFinalCaj;
        private System.Windows.Forms.Button btnCalcularSueldoCaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}