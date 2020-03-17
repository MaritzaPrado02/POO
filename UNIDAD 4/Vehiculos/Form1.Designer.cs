namespace Vehiculos
{
    partial class frmVehiculo
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
            this.gbDatoGrales = new System.Windows.Forms.GroupBox();
            this.txtNumVentanas = new System.Windows.Forms.TextBox();
            this.txtNumPuertas = new System.Windows.Forms.TextBox();
            this.txtNumLlantas = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtTipoCombustible = new System.Windows.Forms.TextBox();
            this.lblNumVentanas = new System.Windows.Forms.Label();
            this.lblNumPuertas = new System.Windows.Forms.Label();
            this.lblNumLlantas = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtNumHelices = new System.Windows.Forms.TextBox();
            this.txtNumTurbinas = new System.Windows.Forms.TextBox();
            this.txtNumAlas = new System.Windows.Forms.TextBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblNumHelices = new System.Windows.Forms.Label();
            this.lblNumTurbinas = new System.Windows.Forms.Label();
            this.lblNumAlas = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnArrancar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtEstadoVuelo = new System.Windows.Forms.TextBox();
            this.btnVolar = new System.Windows.Forms.Button();
            this.txtSonidoArrrancar = new System.Windows.Forms.TextBox();
            this.txtSonidoParar = new System.Windows.Forms.TextBox();
            this.gbDatoGrales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatoGrales
            // 
            this.gbDatoGrales.Controls.Add(this.txtNumVentanas);
            this.gbDatoGrales.Controls.Add(this.txtNumPuertas);
            this.gbDatoGrales.Controls.Add(this.txtNumLlantas);
            this.gbDatoGrales.Controls.Add(this.txtColor);
            this.gbDatoGrales.Controls.Add(this.txtTipoCombustible);
            this.gbDatoGrales.Controls.Add(this.lblNumVentanas);
            this.gbDatoGrales.Controls.Add(this.lblNumPuertas);
            this.gbDatoGrales.Controls.Add(this.lblNumLlantas);
            this.gbDatoGrales.Controls.Add(this.lblColor);
            this.gbDatoGrales.Controls.Add(this.lblTipoCombustible);
            this.gbDatoGrales.Location = new System.Drawing.Point(12, 12);
            this.gbDatoGrales.Name = "gbDatoGrales";
            this.gbDatoGrales.Size = new System.Drawing.Size(362, 231);
            this.gbDatoGrales.TabIndex = 0;
            this.gbDatoGrales.TabStop = false;
            this.gbDatoGrales.Text = "Datos generales del vehiculo";
            // 
            // txtNumVentanas
            // 
            this.txtNumVentanas.Location = new System.Drawing.Point(139, 185);
            this.txtNumVentanas.Name = "txtNumVentanas";
            this.txtNumVentanas.Size = new System.Drawing.Size(100, 20);
            this.txtNumVentanas.TabIndex = 9;
            // 
            // txtNumPuertas
            // 
            this.txtNumPuertas.Location = new System.Drawing.Point(139, 141);
            this.txtNumPuertas.Name = "txtNumPuertas";
            this.txtNumPuertas.Size = new System.Drawing.Size(100, 20);
            this.txtNumPuertas.TabIndex = 8;
            // 
            // txtNumLlantas
            // 
            this.txtNumLlantas.Location = new System.Drawing.Point(139, 101);
            this.txtNumLlantas.Name = "txtNumLlantas";
            this.txtNumLlantas.Size = new System.Drawing.Size(100, 20);
            this.txtNumLlantas.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(139, 68);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 6;
            // 
            // txtTipoCombustible
            // 
            this.txtTipoCombustible.Location = new System.Drawing.Point(139, 35);
            this.txtTipoCombustible.Name = "txtTipoCombustible";
            this.txtTipoCombustible.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCombustible.TabIndex = 5;
            // 
            // lblNumVentanas
            // 
            this.lblNumVentanas.AutoSize = true;
            this.lblNumVentanas.Location = new System.Drawing.Point(22, 188);
            this.lblNumVentanas.Name = "lblNumVentanas";
            this.lblNumVentanas.Size = new System.Drawing.Size(109, 13);
            this.lblNumVentanas.TabIndex = 4;
            this.lblNumVentanas.Text = "Número de ventanas:";
            // 
            // lblNumPuertas
            // 
            this.lblNumPuertas.AutoSize = true;
            this.lblNumPuertas.Location = new System.Drawing.Point(22, 144);
            this.lblNumPuertas.Name = "lblNumPuertas";
            this.lblNumPuertas.Size = new System.Drawing.Size(100, 13);
            this.lblNumPuertas.TabIndex = 3;
            this.lblNumPuertas.Text = "Número de puertas:";
            // 
            // lblNumLlantas
            // 
            this.lblNumLlantas.AutoSize = true;
            this.lblNumLlantas.Location = new System.Drawing.Point(22, 104);
            this.lblNumLlantas.Name = "lblNumLlantas";
            this.lblNumLlantas.Size = new System.Drawing.Size(95, 13);
            this.lblNumLlantas.TabIndex = 2;
            this.lblNumLlantas.Text = "Número de llantas:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(23, 71);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color:";
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Location = new System.Drawing.Point(22, 38);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(106, 13);
            this.lblTipoCombustible.TabIndex = 0;
            this.lblTipoCombustible.Text = "Tipo de Combustible:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.cmbTipoVehiculo);
            this.groupBox1.Controls.Add(this.txtNumHelices);
            this.groupBox1.Controls.Add(this.txtNumTurbinas);
            this.groupBox1.Controls.Add(this.txtNumAlas);
            this.groupBox1.Controls.Add(this.lblTipoVehiculo);
            this.groupBox1.Controls.Add(this.lblNumHelices);
            this.groupBox1.Controls.Add(this.lblNumTurbinas);
            this.groupBox1.Controls.Add(this.lblNumAlas);
            this.groupBox1.Location = new System.Drawing.Point(13, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos especificos aéreos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(280, 203);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Items.AddRange(new object[] {
            "Avión",
            "Helicoptero",
            "Avioneta",
            "Cohete",
            "Dirigible",
            "Ultralivano"});
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(129, 175);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVehiculo.TabIndex = 7;
            // 
            // txtNumHelices
            // 
            this.txtNumHelices.Location = new System.Drawing.Point(138, 129);
            this.txtNumHelices.Name = "txtNumHelices";
            this.txtNumHelices.Size = new System.Drawing.Size(100, 20);
            this.txtNumHelices.TabIndex = 6;
            // 
            // txtNumTurbinas
            // 
            this.txtNumTurbinas.Location = new System.Drawing.Point(138, 83);
            this.txtNumTurbinas.Name = "txtNumTurbinas";
            this.txtNumTurbinas.Size = new System.Drawing.Size(100, 20);
            this.txtNumTurbinas.TabIndex = 5;
            // 
            // txtNumAlas
            // 
            this.txtNumAlas.Location = new System.Drawing.Point(138, 41);
            this.txtNumAlas.Name = "txtNumAlas";
            this.txtNumAlas.Size = new System.Drawing.Size(100, 20);
            this.txtNumAlas.TabIndex = 4;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(24, 183);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(89, 13);
            this.lblTipoVehiculo.TabIndex = 3;
            this.lblTipoVehiculo.Text = "Tipo de vehiculo:";
            // 
            // lblNumHelices
            // 
            this.lblNumHelices.AutoSize = true;
            this.lblNumHelices.Location = new System.Drawing.Point(24, 132);
            this.lblNumHelices.Name = "lblNumHelices";
            this.lblNumHelices.Size = new System.Drawing.Size(98, 13);
            this.lblNumHelices.TabIndex = 2;
            this.lblNumHelices.Text = "Número de hélices:";
            // 
            // lblNumTurbinas
            // 
            this.lblNumTurbinas.AutoSize = true;
            this.lblNumTurbinas.Location = new System.Drawing.Point(24, 86);
            this.lblNumTurbinas.Name = "lblNumTurbinas";
            this.lblNumTurbinas.Size = new System.Drawing.Size(102, 13);
            this.lblNumTurbinas.TabIndex = 1;
            this.lblNumTurbinas.Text = "Número de turbinas:";
            // 
            // lblNumAlas
            // 
            this.lblNumAlas.AutoSize = true;
            this.lblNumAlas.Location = new System.Drawing.Point(24, 41);
            this.lblNumAlas.Name = "lblNumAlas";
            this.lblNumAlas.Size = new System.Drawing.Size(84, 13);
            this.lblNumAlas.TabIndex = 0;
            this.lblNumAlas.Text = "Número de alas:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(399, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnArrancar
            // 
            this.btnArrancar.Location = new System.Drawing.Point(230, 529);
            this.btnArrancar.Name = "btnArrancar";
            this.btnArrancar.Size = new System.Drawing.Size(75, 23);
            this.btnArrancar.TabIndex = 3;
            this.btnArrancar.Text = "Arrancar";
            this.btnArrancar.UseVisualStyleBackColor = true;
            this.btnArrancar.Click += new System.EventHandler(this.btnArrancar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(230, 600);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtEstadoVuelo
            // 
            this.txtEstadoVuelo.Location = new System.Drawing.Point(23, 563);
            this.txtEstadoVuelo.Name = "txtEstadoVuelo";
            this.txtEstadoVuelo.Size = new System.Drawing.Size(181, 20);
            this.txtEstadoVuelo.TabIndex = 5;
            this.txtEstadoVuelo.TextChanged += new System.EventHandler(this.txtEstadoVuelo_TextChanged);
            // 
            // btnVolar
            // 
            this.btnVolar.Location = new System.Drawing.Point(230, 563);
            this.btnVolar.Name = "btnVolar";
            this.btnVolar.Size = new System.Drawing.Size(75, 23);
            this.btnVolar.TabIndex = 6;
            this.btnVolar.Text = "Volar";
            this.btnVolar.UseVisualStyleBackColor = true;
            this.btnVolar.Click += new System.EventHandler(this.btnVolar_Click);
            // 
            // txtSonidoArrrancar
            // 
            this.txtSonidoArrrancar.Location = new System.Drawing.Point(23, 532);
            this.txtSonidoArrrancar.Name = "txtSonidoArrrancar";
            this.txtSonidoArrrancar.Size = new System.Drawing.Size(181, 20);
            this.txtSonidoArrrancar.TabIndex = 7;
            this.txtSonidoArrrancar.TextChanged += new System.EventHandler(this.txtSonidoArrrancar_TextChanged);
            // 
            // txtSonidoParar
            // 
            this.txtSonidoParar.Location = new System.Drawing.Point(23, 602);
            this.txtSonidoParar.Name = "txtSonidoParar";
            this.txtSonidoParar.Size = new System.Drawing.Size(181, 20);
            this.txtSonidoParar.TabIndex = 8;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 650);
            this.Controls.Add(this.txtSonidoParar);
            this.Controls.Add(this.txtSonidoArrrancar);
            this.Controls.Add(this.btnVolar);
            this.Controls.Add(this.txtEstadoVuelo);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnArrancar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatoGrales);
            this.Name = "frmVehiculo";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            this.gbDatoGrales.ResumeLayout(false);
            this.gbDatoGrales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatoGrales;
        private System.Windows.Forms.Label lblNumVentanas;
        private System.Windows.Forms.Label lblNumPuertas;
        private System.Windows.Forms.Label lblNumLlantas;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblNumHelices;
        private System.Windows.Forms.Label lblNumTurbinas;
        private System.Windows.Forms.Label lblNumAlas;
        private System.Windows.Forms.TextBox txtNumVentanas;
        private System.Windows.Forms.TextBox txtNumPuertas;
        private System.Windows.Forms.TextBox txtNumLlantas;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtTipoCombustible;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtNumHelices;
        private System.Windows.Forms.TextBox txtNumTurbinas;
        private System.Windows.Forms.TextBox txtNumAlas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnArrancar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtEstadoVuelo;
        private System.Windows.Forms.Button btnVolar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSonidoArrrancar;
        private System.Windows.Forms.TextBox txtSonidoParar;
    }
}

