namespace Concierto
{
    partial class frmConcierto
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
            this.lblAsistentes = new System.Windows.Forms.Label();
            this.cmbAsistentes = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.btnContabilizar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblBebés = new System.Windows.Forms.Label();
            this.lblNiños = new System.Windows.Forms.Label();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.lblTerceraEdad = new System.Windows.Forms.Label();
            this.txtBebés = new System.Windows.Forms.TextBox();
            this.txtNiños = new System.Windows.Forms.TextBox();
            this.txtAdultos = new System.Windows.Forms.TextBox();
            this.txtTerceraEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAsistentes
            // 
            this.lblAsistentes.AutoSize = true;
            this.lblAsistentes.Location = new System.Drawing.Point(29, 54);
            this.lblAsistentes.Name = "lblAsistentes";
            this.lblAsistentes.Size = new System.Drawing.Size(96, 13);
            this.lblAsistentes.TabIndex = 0;
            this.lblAsistentes.Text = "Tipo de asistentes:";
            // 
            // cmbAsistentes
            // 
            this.cmbAsistentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistentes.FormattingEnabled = true;
            this.cmbAsistentes.Items.AddRange(new object[] {
            "Bebés",
            "Niños",
            "Adultos",
            "Personas de la tercera edad"});
            this.cmbAsistentes.Location = new System.Drawing.Point(131, 46);
            this.cmbAsistentes.Name = "cmbAsistentes";
            this.cmbAsistentes.Size = new System.Drawing.Size(121, 21);
            this.cmbAsistentes.TabIndex = 1;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(73, 107);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCantidad.Location = new System.Drawing.Point(162, 99);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(47, 21);
            this.cmbCantidad.TabIndex = 3;
            // 
            // btnContabilizar
            // 
            this.btnContabilizar.Location = new System.Drawing.Point(144, 155);
            this.btnContabilizar.Name = "btnContabilizar";
            this.btnContabilizar.Size = new System.Drawing.Size(75, 23);
            this.btnContabilizar.TabIndex = 4;
            this.btnContabilizar.Text = "Contabilizar";
            this.btnContabilizar.UseVisualStyleBackColor = true;
            this.btnContabilizar.Click += new System.EventHandler(this.btnContabilizar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(106, 199);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblBebés
            // 
            this.lblBebés.AutoSize = true;
            this.lblBebés.Location = new System.Drawing.Point(35, 250);
            this.lblBebés.Name = "lblBebés";
            this.lblBebés.Size = new System.Drawing.Size(40, 13);
            this.lblBebés.TabIndex = 6;
            this.lblBebés.Text = "Bebés:";
            // 
            // lblNiños
            // 
            this.lblNiños.AutoSize = true;
            this.lblNiños.Location = new System.Drawing.Point(35, 283);
            this.lblNiños.Name = "lblNiños";
            this.lblNiños.Size = new System.Drawing.Size(37, 13);
            this.lblNiños.TabIndex = 7;
            this.lblNiños.Text = "Niños:";
            // 
            // lblAdultos
            // 
            this.lblAdultos.AutoSize = true;
            this.lblAdultos.Location = new System.Drawing.Point(35, 312);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(45, 13);
            this.lblAdultos.TabIndex = 8;
            this.lblAdultos.Text = "Adultos:";
            // 
            // lblTerceraEdad
            // 
            this.lblTerceraEdad.AutoSize = true;
            this.lblTerceraEdad.Location = new System.Drawing.Point(35, 346);
            this.lblTerceraEdad.Name = "lblTerceraEdad";
            this.lblTerceraEdad.Size = new System.Drawing.Size(146, 13);
            this.lblTerceraEdad.TabIndex = 9;
            this.lblTerceraEdad.Text = "Personas de la tercera edad: ";
            // 
            // txtBebés
            // 
            this.txtBebés.Enabled = false;
            this.txtBebés.Location = new System.Drawing.Point(91, 247);
            this.txtBebés.Name = "txtBebés";
            this.txtBebés.Size = new System.Drawing.Size(75, 20);
            this.txtBebés.TabIndex = 10;
            // 
            // txtNiños
            // 
            this.txtNiños.Enabled = false;
            this.txtNiños.Location = new System.Drawing.Point(91, 280);
            this.txtNiños.Name = "txtNiños";
            this.txtNiños.Size = new System.Drawing.Size(75, 20);
            this.txtNiños.TabIndex = 11;
            // 
            // txtAdultos
            // 
            this.txtAdultos.Enabled = false;
            this.txtAdultos.Location = new System.Drawing.Point(91, 309);
            this.txtAdultos.Name = "txtAdultos";
            this.txtAdultos.Size = new System.Drawing.Size(75, 20);
            this.txtAdultos.TabIndex = 12;
            // 
            // txtTerceraEdad
            // 
            this.txtTerceraEdad.Enabled = false;
            this.txtTerceraEdad.Location = new System.Drawing.Point(187, 343);
            this.txtTerceraEdad.Name = "txtTerceraEdad";
            this.txtTerceraEdad.Size = new System.Drawing.Size(75, 20);
            this.txtTerceraEdad.TabIndex = 13;
            // 
            // frmConcierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 405);
            this.Controls.Add(this.txtTerceraEdad);
            this.Controls.Add(this.txtAdultos);
            this.Controls.Add(this.txtNiños);
            this.Controls.Add(this.txtBebés);
            this.Controls.Add(this.lblTerceraEdad);
            this.Controls.Add(this.lblAdultos);
            this.Controls.Add(this.lblNiños);
            this.Controls.Add(this.lblBebés);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnContabilizar);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbAsistentes);
            this.Controls.Add(this.lblAsistentes);
            this.Name = "frmConcierto";
            this.Text = "Concierto";
            this.Load += new System.EventHandler(this.frmConcierto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsistentes;
        private System.Windows.Forms.ComboBox cmbAsistentes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button btnContabilizar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblBebés;
        private System.Windows.Forms.Label lblNiños;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.Label lblTerceraEdad;
        private System.Windows.Forms.TextBox txtBebés;
        private System.Windows.Forms.TextBox txtNiños;
        private System.Windows.Forms.TextBox txtAdultos;
        private System.Windows.Forms.TextBox txtTerceraEdad;
    }
}

