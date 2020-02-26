namespace Recibo_Electricidad
{
    partial class frmElectridad
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
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblKw = new System.Windows.Forms.Label();
            this.lblCostoCorrespondiente = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.txtCantidadKw = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIngresar.Location = new System.Drawing.Point(56, 18);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(190, 16);
            this.lblIngresar.TabIndex = 0;
            this.lblIngresar.Text = "Ingrese la cantidad del Kw";
            // 
            // lblKw
            // 
            this.lblKw.AutoSize = true;
            this.lblKw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKw.Location = new System.Drawing.Point(199, 59);
            this.lblKw.Name = "lblKw";
            this.lblKw.Size = new System.Drawing.Size(24, 13);
            this.lblKw.TabIndex = 1;
            this.lblKw.Text = "Kw";
            // 
            // lblCostoCorrespondiente
            // 
            this.lblCostoCorrespondiente.AutoSize = true;
            this.lblCostoCorrespondiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoCorrespondiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCostoCorrespondiente.Location = new System.Drawing.Point(12, 204);
            this.lblCostoCorrespondiente.Name = "lblCostoCorrespondiente";
            this.lblCostoCorrespondiente.Size = new System.Drawing.Size(123, 20);
            this.lblCostoCorrespondiente.TabIndex = 2;
            this.lblCostoCorrespondiente.Text = "El costo es de";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(199, 255);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(87, 16);
            this.lblPesos.TabIndex = 3;
            this.lblPesos.Text = "pesos MXN";
            // 
            // txtCantidadKw
            // 
            this.txtCantidadKw.Location = new System.Drawing.Point(93, 56);
            this.txtCantidadKw.Name = "txtCantidadKw";
            this.txtCantidadKw.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadKw.TabIndex = 4;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(93, 252);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 5;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.BackColor = System.Drawing.Color.Red;
            this.btnCalcularCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCosto.ForeColor = System.Drawing.Color.White;
            this.btnCalcularCosto.Location = new System.Drawing.Point(82, 149);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(132, 29);
            this.btnCalcularCosto.TabIndex = 6;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = false;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(43, 102);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 16);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Hogar",
            "Negocio"});
            this.cmbTipo.Location = new System.Drawing.Point(93, 97);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(56, 252);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(16, 16);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "$";
            // 
            // frmElectridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(302, 304);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCantidadKw);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblCostoCorrespondiente);
            this.Controls.Add(this.lblKw);
            this.Controls.Add(this.lblIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmElectridad";
            this.Text = "CFE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblKw;
        private System.Windows.Forms.Label lblCostoCorrespondiente;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.TextBox txtCantidadKw;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblPrecio;
    }
}

