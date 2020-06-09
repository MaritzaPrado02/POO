namespace Ejercicio1PropuestoUnidad6
{
    partial class frmCombinacionColores
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
            this.grbPrimarioPrimario = new System.Windows.Forms.GroupBox();
            this.btnCombinarPP = new System.Windows.Forms.Button();
            this.lblNColorS = new System.Windows.Forms.Label();
            this.lblColorPP = new System.Windows.Forms.Label();
            this.lblMasPP = new System.Windows.Forms.Label();
            this.cmbPrimario2 = new System.Windows.Forms.ComboBox();
            this.cmbPrimario1 = new System.Windows.Forms.ComboBox();
            this.grbPrimarioSecundario = new System.Windows.Forms.GroupBox();
            this.btnCombinarPS = new System.Windows.Forms.Button();
            this.lblNColorT = new System.Windows.Forms.Label();
            this.lblColorPS = new System.Windows.Forms.Label();
            this.lblMasPS = new System.Windows.Forms.Label();
            this.cmbSecundario = new System.Windows.Forms.ComboBox();
            this.cmbPrimario3 = new System.Windows.Forms.ComboBox();
            this.pcbColores = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.grbPrimarioPrimario.SuspendLayout();
            this.grbPrimarioSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColores)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPrimarioPrimario
            // 
            this.grbPrimarioPrimario.Controls.Add(this.btnCombinarPP);
            this.grbPrimarioPrimario.Controls.Add(this.lblNColorS);
            this.grbPrimarioPrimario.Controls.Add(this.lblColorPP);
            this.grbPrimarioPrimario.Controls.Add(this.lblMasPP);
            this.grbPrimarioPrimario.Controls.Add(this.cmbPrimario2);
            this.grbPrimarioPrimario.Controls.Add(this.cmbPrimario1);
            this.grbPrimarioPrimario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrimarioPrimario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbPrimarioPrimario.Location = new System.Drawing.Point(12, 98);
            this.grbPrimarioPrimario.Name = "grbPrimarioPrimario";
            this.grbPrimarioPrimario.Size = new System.Drawing.Size(335, 200);
            this.grbPrimarioPrimario.TabIndex = 0;
            this.grbPrimarioPrimario.TabStop = false;
            this.grbPrimarioPrimario.Text = "Primario + Primario = SECUNDARIO";
            // 
            // btnCombinarPP
            // 
            this.btnCombinarPP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombinarPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombinarPP.ForeColor = System.Drawing.Color.Purple;
            this.btnCombinarPP.Location = new System.Drawing.Point(123, 90);
            this.btnCombinarPP.Name = "btnCombinarPP";
            this.btnCombinarPP.Size = new System.Drawing.Size(85, 23);
            this.btnCombinarPP.TabIndex = 5;
            this.btnCombinarPP.Text = "Combinar";
            this.btnCombinarPP.UseVisualStyleBackColor = true;
            this.btnCombinarPP.Click += new System.EventHandler(this.btnCombinarPP_Click);
            // 
            // lblNColorS
            // 
            this.lblNColorS.AutoSize = true;
            this.lblNColorS.ForeColor = System.Drawing.Color.Black;
            this.lblNColorS.Location = new System.Drawing.Point(150, 143);
            this.lblNColorS.Name = "lblNColorS";
            this.lblNColorS.Size = new System.Drawing.Size(0, 16);
            this.lblNColorS.TabIndex = 4;
            // 
            // lblColorPP
            // 
            this.lblColorPP.AutoSize = true;
            this.lblColorPP.ForeColor = System.Drawing.Color.Black;
            this.lblColorPP.Location = new System.Drawing.Point(64, 143);
            this.lblColorPP.Name = "lblColorPP";
            this.lblColorPP.Size = new System.Drawing.Size(46, 16);
            this.lblColorPP.TabIndex = 3;
            this.lblColorPP.Text = "Color:";
            // 
            // lblMasPP
            // 
            this.lblMasPP.AutoSize = true;
            this.lblMasPP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasPP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMasPP.Location = new System.Drawing.Point(149, 38);
            this.lblMasPP.Name = "lblMasPP";
            this.lblMasPP.Size = new System.Drawing.Size(21, 22);
            this.lblMasPP.TabIndex = 2;
            this.lblMasPP.Text = "+";
            // 
            // cmbPrimario2
            // 
            this.cmbPrimario2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPrimario2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimario2.FormattingEnabled = true;
            this.cmbPrimario2.Location = new System.Drawing.Point(176, 36);
            this.cmbPrimario2.Name = "cmbPrimario2";
            this.cmbPrimario2.Size = new System.Drawing.Size(121, 24);
            this.cmbPrimario2.TabIndex = 1;
            // 
            // cmbPrimario1
            // 
            this.cmbPrimario1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPrimario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimario1.FormattingEnabled = true;
            this.cmbPrimario1.Location = new System.Drawing.Point(22, 36);
            this.cmbPrimario1.Name = "cmbPrimario1";
            this.cmbPrimario1.Size = new System.Drawing.Size(121, 24);
            this.cmbPrimario1.TabIndex = 0;
            // 
            // grbPrimarioSecundario
            // 
            this.grbPrimarioSecundario.Controls.Add(this.btnCombinarPS);
            this.grbPrimarioSecundario.Controls.Add(this.lblNColorT);
            this.grbPrimarioSecundario.Controls.Add(this.lblColorPS);
            this.grbPrimarioSecundario.Controls.Add(this.lblMasPS);
            this.grbPrimarioSecundario.Controls.Add(this.cmbSecundario);
            this.grbPrimarioSecundario.Controls.Add(this.cmbPrimario3);
            this.grbPrimarioSecundario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrimarioSecundario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbPrimarioSecundario.Location = new System.Drawing.Point(13, 305);
            this.grbPrimarioSecundario.Name = "grbPrimarioSecundario";
            this.grbPrimarioSecundario.Size = new System.Drawing.Size(335, 200);
            this.grbPrimarioSecundario.TabIndex = 1;
            this.grbPrimarioSecundario.TabStop = false;
            this.grbPrimarioSecundario.Text = "Primario + Secundario = TERCIARIO";
            // 
            // btnCombinarPS
            // 
            this.btnCombinarPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombinarPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombinarPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCombinarPS.Location = new System.Drawing.Point(122, 97);
            this.btnCombinarPS.Name = "btnCombinarPS";
            this.btnCombinarPS.Size = new System.Drawing.Size(85, 23);
            this.btnCombinarPS.TabIndex = 5;
            this.btnCombinarPS.Text = "Combinar";
            this.btnCombinarPS.UseVisualStyleBackColor = true;
            this.btnCombinarPS.Click += new System.EventHandler(this.btnCombinarPS_Click);
            // 
            // lblNColorT
            // 
            this.lblNColorT.AutoSize = true;
            this.lblNColorT.ForeColor = System.Drawing.Color.Black;
            this.lblNColorT.Location = new System.Drawing.Point(149, 147);
            this.lblNColorT.Name = "lblNColorT";
            this.lblNColorT.Size = new System.Drawing.Size(0, 16);
            this.lblNColorT.TabIndex = 4;
            // 
            // lblColorPS
            // 
            this.lblColorPS.AutoSize = true;
            this.lblColorPS.ForeColor = System.Drawing.Color.Black;
            this.lblColorPS.Location = new System.Drawing.Point(63, 147);
            this.lblColorPS.Name = "lblColorPS";
            this.lblColorPS.Size = new System.Drawing.Size(46, 16);
            this.lblColorPS.TabIndex = 3;
            this.lblColorPS.Text = "Color:";
            // 
            // lblMasPS
            // 
            this.lblMasPS.AutoSize = true;
            this.lblMasPS.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMasPS.Location = new System.Drawing.Point(148, 37);
            this.lblMasPS.Name = "lblMasPS";
            this.lblMasPS.Size = new System.Drawing.Size(21, 22);
            this.lblMasPS.TabIndex = 2;
            this.lblMasPS.Text = "+";
            // 
            // cmbSecundario
            // 
            this.cmbSecundario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSecundario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecundario.FormattingEnabled = true;
            this.cmbSecundario.Location = new System.Drawing.Point(175, 37);
            this.cmbSecundario.Name = "cmbSecundario";
            this.cmbSecundario.Size = new System.Drawing.Size(121, 24);
            this.cmbSecundario.TabIndex = 1;
            // 
            // cmbPrimario3
            // 
            this.cmbPrimario3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPrimario3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimario3.FormattingEnabled = true;
            this.cmbPrimario3.Location = new System.Drawing.Point(21, 37);
            this.cmbPrimario3.Name = "cmbPrimario3";
            this.cmbPrimario3.Size = new System.Drawing.Size(121, 24);
            this.cmbPrimario3.TabIndex = 0;
            // 
            // pcbColores
            // 
            this.pcbColores.BackgroundImage = global::Ejercicio1PropuestoUnidad6.Properties.Resources.Colores_Prim;
            this.pcbColores.Location = new System.Drawing.Point(76, 12);
            this.pcbColores.Name = "pcbColores";
            this.pcbColores.Size = new System.Drawing.Size(200, 80);
            this.pcbColores.TabIndex = 2;
            this.pcbColores.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 511);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(272, 511);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(273, 545);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmCombinacionColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 580);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pcbColores);
            this.Controls.Add(this.grbPrimarioSecundario);
            this.Controls.Add(this.grbPrimarioPrimario);
            this.Name = "frmCombinacionColores";
            this.Text = "Combinar colores";
            this.Load += new System.EventHandler(this.frmCombinacionColores_Load);
            this.grbPrimarioPrimario.ResumeLayout(false);
            this.grbPrimarioPrimario.PerformLayout();
            this.grbPrimarioSecundario.ResumeLayout(false);
            this.grbPrimarioSecundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrimarioPrimario;
        private System.Windows.Forms.GroupBox grbPrimarioSecundario;
        private System.Windows.Forms.PictureBox pcbColores;
        private System.Windows.Forms.Button btnCombinarPP;
        private System.Windows.Forms.Label lblNColorS;
        private System.Windows.Forms.Label lblColorPP;
        private System.Windows.Forms.Label lblMasPP;
        private System.Windows.Forms.ComboBox cmbPrimario2;
        private System.Windows.Forms.ComboBox cmbPrimario1;
        private System.Windows.Forms.Button btnCombinarPS;
        private System.Windows.Forms.Label lblNColorT;
        private System.Windows.Forms.Label lblColorPS;
        private System.Windows.Forms.Label lblMasPS;
        private System.Windows.Forms.ComboBox cmbSecundario;
        private System.Windows.Forms.ComboBox cmbPrimario3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnAbrir;
    }
}

