namespace MatrizSumaFCD
{
    partial class frmMatrizSumaFCD
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
            this.grbFilas = new System.Windows.Forms.GroupBox();
            this.btnSumarFila = new System.Windows.Forms.Button();
            this.txtSumaSumaFila = new System.Windows.Forms.TextBox();
            this.rtbSumaFila = new System.Windows.Forms.RichTextBox();
            this.lblSumaSumaFila = new System.Windows.Forms.Label();
            this.lblSumaFilas = new System.Windows.Forms.Label();
            this.grbColumnas = new System.Windows.Forms.GroupBox();
            this.lblSumaSumaColumnas = new System.Windows.Forms.Label();
            this.lblSumaColumna = new System.Windows.Forms.Label();
            this.btnSumarColumnas = new System.Windows.Forms.Button();
            this.txtSumaSumaColumna = new System.Windows.Forms.TextBox();
            this.rtbSumaColumnas = new System.Windows.Forms.RichTextBox();
            this.grbDiagonal = new System.Windows.Forms.GroupBox();
            this.lblSumaDiagonal = new System.Windows.Forms.Label();
            this.lblElementosDiagonal = new System.Windows.Forms.Label();
            this.btnSumarDiagonal = new System.Windows.Forms.Button();
            this.txtSumaDiagonal = new System.Windows.Forms.TextBox();
            this.rtbElementosDiagonal = new System.Windows.Forms.RichTextBox();
            this.lblTamanioMatriz = new System.Windows.Forms.Label();
            this.nudTamanioMatriz = new System.Windows.Forms.NumericUpDown();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.rtbMatrizI = new System.Windows.Forms.RichTextBox();
            this.btnImprimirMatriz = new System.Windows.Forms.Button();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.grbFilas.SuspendLayout();
            this.grbColumnas.SuspendLayout();
            this.grbDiagonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFilas
            // 
            this.grbFilas.Controls.Add(this.btnSumarFila);
            this.grbFilas.Controls.Add(this.txtSumaSumaFila);
            this.grbFilas.Controls.Add(this.rtbSumaFila);
            this.grbFilas.Controls.Add(this.lblSumaSumaFila);
            this.grbFilas.Controls.Add(this.lblSumaFilas);
            this.grbFilas.Location = new System.Drawing.Point(12, 179);
            this.grbFilas.Name = "grbFilas";
            this.grbFilas.Size = new System.Drawing.Size(250, 160);
            this.grbFilas.TabIndex = 0;
            this.grbFilas.TabStop = false;
            this.grbFilas.Text = "Sumar Filas";
            // 
            // btnSumarFila
            // 
            this.btnSumarFila.Location = new System.Drawing.Point(160, 131);
            this.btnSumarFila.Name = "btnSumarFila";
            this.btnSumarFila.Size = new System.Drawing.Size(84, 23);
            this.btnSumarFila.TabIndex = 4;
            this.btnSumarFila.Text = "Sumar Filas";
            this.btnSumarFila.UseVisualStyleBackColor = true;
            this.btnSumarFila.Click += new System.EventHandler(this.btnSumarFila_Click);
            // 
            // txtSumaSumaFila
            // 
            this.txtSumaSumaFila.Enabled = false;
            this.txtSumaSumaFila.Location = new System.Drawing.Point(81, 117);
            this.txtSumaSumaFila.Name = "txtSumaSumaFila";
            this.txtSumaSumaFila.Size = new System.Drawing.Size(48, 20);
            this.txtSumaSumaFila.TabIndex = 3;
            // 
            // rtbSumaFila
            // 
            this.rtbSumaFila.Location = new System.Drawing.Point(63, 57);
            this.rtbSumaFila.Name = "rtbSumaFila";
            this.rtbSumaFila.Size = new System.Drawing.Size(100, 23);
            this.rtbSumaFila.TabIndex = 2;
            this.rtbSumaFila.Text = "";
            // 
            // lblSumaSumaFila
            // 
            this.lblSumaSumaFila.AutoSize = true;
            this.lblSumaSumaFila.Location = new System.Drawing.Point(26, 95);
            this.lblSumaSumaFila.Name = "lblSumaSumaFila";
            this.lblSumaSumaFila.Size = new System.Drawing.Size(146, 13);
            this.lblSumaSumaFila.TabIndex = 1;
            this.lblSumaSumaFila.Text = "Suma de la suma de cada fila";
            // 
            // lblSumaFilas
            // 
            this.lblSumaFilas.AutoSize = true;
            this.lblSumaFilas.Location = new System.Drawing.Point(26, 32);
            this.lblSumaFilas.Name = "lblSumaFilas";
            this.lblSumaFilas.Size = new System.Drawing.Size(92, 13);
            this.lblSumaFilas.TabIndex = 0;
            this.lblSumaFilas.Text = "Suma de cada fila";
            this.lblSumaFilas.Click += new System.EventHandler(this.label2_Click);
            // 
            // grbColumnas
            // 
            this.grbColumnas.Controls.Add(this.lblSumaSumaColumnas);
            this.grbColumnas.Controls.Add(this.lblSumaColumna);
            this.grbColumnas.Controls.Add(this.btnSumarColumnas);
            this.grbColumnas.Controls.Add(this.txtSumaSumaColumna);
            this.grbColumnas.Controls.Add(this.rtbSumaColumnas);
            this.grbColumnas.Location = new System.Drawing.Point(268, 13);
            this.grbColumnas.Name = "grbColumnas";
            this.grbColumnas.Size = new System.Drawing.Size(250, 160);
            this.grbColumnas.TabIndex = 1;
            this.grbColumnas.TabStop = false;
            this.grbColumnas.Text = "Sumar columnas";
            // 
            // lblSumaSumaColumnas
            // 
            this.lblSumaSumaColumnas.AutoSize = true;
            this.lblSumaSumaColumnas.Location = new System.Drawing.Point(28, 88);
            this.lblSumaSumaColumnas.Name = "lblSumaSumaColumnas";
            this.lblSumaSumaColumnas.Size = new System.Drawing.Size(173, 13);
            this.lblSumaSumaColumnas.TabIndex = 8;
            this.lblSumaSumaColumnas.Text = "Suma de la suma de cada columna";
            // 
            // lblSumaColumna
            // 
            this.lblSumaColumna.AutoSize = true;
            this.lblSumaColumna.Location = new System.Drawing.Point(28, 30);
            this.lblSumaColumna.Name = "lblSumaColumna";
            this.lblSumaColumna.Size = new System.Drawing.Size(119, 13);
            this.lblSumaColumna.TabIndex = 7;
            this.lblSumaColumna.Text = "Suma de cada columna";
            // 
            // btnSumarColumnas
            // 
            this.btnSumarColumnas.Location = new System.Drawing.Point(150, 131);
            this.btnSumarColumnas.Name = "btnSumarColumnas";
            this.btnSumarColumnas.Size = new System.Drawing.Size(94, 23);
            this.btnSumarColumnas.TabIndex = 6;
            this.btnSumarColumnas.Text = "Sumar Columnas";
            this.btnSumarColumnas.UseVisualStyleBackColor = true;
            this.btnSumarColumnas.Click += new System.EventHandler(this.btnSumarColumnas_Click);
            // 
            // txtSumaSumaColumna
            // 
            this.txtSumaSumaColumna.Enabled = false;
            this.txtSumaSumaColumna.Location = new System.Drawing.Point(90, 109);
            this.txtSumaSumaColumna.Name = "txtSumaSumaColumna";
            this.txtSumaSumaColumna.Size = new System.Drawing.Size(54, 20);
            this.txtSumaSumaColumna.TabIndex = 5;
            // 
            // rtbSumaColumnas
            // 
            this.rtbSumaColumnas.Location = new System.Drawing.Point(73, 48);
            this.rtbSumaColumnas.Name = "rtbSumaColumnas";
            this.rtbSumaColumnas.Size = new System.Drawing.Size(100, 23);
            this.rtbSumaColumnas.TabIndex = 3;
            this.rtbSumaColumnas.Text = "";
            // 
            // grbDiagonal
            // 
            this.grbDiagonal.Controls.Add(this.lblSumaDiagonal);
            this.grbDiagonal.Controls.Add(this.lblElementosDiagonal);
            this.grbDiagonal.Controls.Add(this.btnSumarDiagonal);
            this.grbDiagonal.Controls.Add(this.txtSumaDiagonal);
            this.grbDiagonal.Controls.Add(this.rtbElementosDiagonal);
            this.grbDiagonal.Location = new System.Drawing.Point(268, 179);
            this.grbDiagonal.Name = "grbDiagonal";
            this.grbDiagonal.Size = new System.Drawing.Size(250, 160);
            this.grbDiagonal.TabIndex = 1;
            this.grbDiagonal.TabStop = false;
            this.grbDiagonal.Text = "Sumar Diagonal";
            // 
            // lblSumaDiagonal
            // 
            this.lblSumaDiagonal.AutoSize = true;
            this.lblSumaDiagonal.Location = new System.Drawing.Point(28, 95);
            this.lblSumaDiagonal.Name = "lblSumaDiagonal";
            this.lblSumaDiagonal.Size = new System.Drawing.Size(179, 13);
            this.lblSumaDiagonal.TabIndex = 10;
            this.lblSumaDiagonal.Text = "Suma de los elementos de la digonal";
            // 
            // lblElementosDiagonal
            // 
            this.lblElementosDiagonal.AutoSize = true;
            this.lblElementosDiagonal.Location = new System.Drawing.Point(28, 32);
            this.lblElementosDiagonal.Name = "lblElementosDiagonal";
            this.lblElementosDiagonal.Size = new System.Drawing.Size(125, 13);
            this.lblElementosDiagonal.TabIndex = 9;
            this.lblElementosDiagonal.Text = "Elementos de la diagonal";
            // 
            // btnSumarDiagonal
            // 
            this.btnSumarDiagonal.Location = new System.Drawing.Point(150, 131);
            this.btnSumarDiagonal.Name = "btnSumarDiagonal";
            this.btnSumarDiagonal.Size = new System.Drawing.Size(94, 23);
            this.btnSumarDiagonal.TabIndex = 5;
            this.btnSumarDiagonal.Text = "Sumar Diagonal";
            this.btnSumarDiagonal.UseVisualStyleBackColor = true;
            this.btnSumarDiagonal.Click += new System.EventHandler(this.btnSumarDiagonal_Click);
            // 
            // txtSumaDiagonal
            // 
            this.txtSumaDiagonal.Enabled = false;
            this.txtSumaDiagonal.Location = new System.Drawing.Point(95, 117);
            this.txtSumaDiagonal.Name = "txtSumaDiagonal";
            this.txtSumaDiagonal.Size = new System.Drawing.Size(49, 20);
            this.txtSumaDiagonal.TabIndex = 4;
            // 
            // rtbElementosDiagonal
            // 
            this.rtbElementosDiagonal.Location = new System.Drawing.Point(73, 57);
            this.rtbElementosDiagonal.Name = "rtbElementosDiagonal";
            this.rtbElementosDiagonal.Size = new System.Drawing.Size(100, 23);
            this.rtbElementosDiagonal.TabIndex = 4;
            this.rtbElementosDiagonal.Text = "";
            // 
            // lblTamanioMatriz
            // 
            this.lblTamanioMatriz.AutoSize = true;
            this.lblTamanioMatriz.Location = new System.Drawing.Point(9, 28);
            this.lblTamanioMatriz.Name = "lblTamanioMatriz";
            this.lblTamanioMatriz.Size = new System.Drawing.Size(77, 13);
            this.lblTamanioMatriz.TabIndex = 2;
            this.lblTamanioMatriz.Text = "Tamaño Matriz";
            // 
            // nudTamanioMatriz
            // 
            this.nudTamanioMatriz.Location = new System.Drawing.Point(103, 21);
            this.nudTamanioMatriz.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTamanioMatriz.Name = "nudTamanioMatriz";
            this.nudTamanioMatriz.Size = new System.Drawing.Size(48, 20);
            this.nudTamanioMatriz.TabIndex = 3;
            this.nudTamanioMatriz.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(172, 21);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 4;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click_1);
            // 
            // rtbMatrizI
            // 
            this.rtbMatrizI.Location = new System.Drawing.Point(41, 61);
            this.rtbMatrizI.Name = "rtbMatrizI";
            this.rtbMatrizI.Size = new System.Drawing.Size(100, 96);
            this.rtbMatrizI.TabIndex = 5;
            this.rtbMatrizI.Text = "";
            // 
            // btnImprimirMatriz
            // 
            this.btnImprimirMatriz.Location = new System.Drawing.Point(157, 91);
            this.btnImprimirMatriz.Name = "btnImprimirMatriz";
            this.btnImprimirMatriz.Size = new System.Drawing.Size(90, 23);
            this.btnImprimirMatriz.TabIndex = 6;
            this.btnImprimirMatriz.Text = "Imprimir Matriz";
            this.btnImprimirMatriz.UseVisualStyleBackColor = true;
            this.btnImprimirMatriz.Click += new System.EventHandler(this.btnImprimirMatriz_Click_1);
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Location = new System.Drawing.Point(219, 355);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(95, 23);
            this.btnGuardarDatos.TabIndex = 7;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(437, 379);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(437, 409);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmMatrizSumaFCD
            // 
            this.ClientSize = new System.Drawing.Size(529, 436);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.btnImprimirMatriz);
            this.Controls.Add(this.rtbMatrizI);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.nudTamanioMatriz);
            this.Controls.Add(this.lblTamanioMatriz);
            this.Controls.Add(this.grbDiagonal);
            this.Controls.Add(this.grbColumnas);
            this.Controls.Add(this.grbFilas);
            this.Name = "frmMatrizSumaFCD";
            this.Text = "Matriz FCD";
            this.Load += new System.EventHandler(this.frmMatrizSumaFCD_Load);
            this.grbFilas.ResumeLayout(false);
            this.grbFilas.PerformLayout();
            this.grbColumnas.ResumeLayout(false);
            this.grbColumnas.PerformLayout();
            this.grbDiagonal.ResumeLayout(false);
            this.grbDiagonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanioMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.GroupBox grbFilas;
        private System.Windows.Forms.TextBox txtSumaSumaFila;
        private System.Windows.Forms.RichTextBox rtbSumaFila;
        private System.Windows.Forms.Label lblSumaSumaFila;
        private System.Windows.Forms.Label lblSumaFilas;
        private System.Windows.Forms.GroupBox grbColumnas;
        private System.Windows.Forms.TextBox txtSumaSumaColumna;
        private System.Windows.Forms.RichTextBox rtbSumaColumnas;
        private System.Windows.Forms.GroupBox grbDiagonal;
        private System.Windows.Forms.TextBox txtSumaDiagonal;
        private System.Windows.Forms.RichTextBox rtbElementosDiagonal;
        private System.Windows.Forms.Label lblTamanioMatriz;
        private System.Windows.Forms.NumericUpDown nudTamanioMatriz;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.RichTextBox rtbMatrizI;
        private System.Windows.Forms.Button btnImprimirMatriz;
        private System.Windows.Forms.Button btnSumarFila;
        private System.Windows.Forms.Button btnSumarColumnas;
        private System.Windows.Forms.Button btnSumarDiagonal;
        private System.Windows.Forms.Label lblSumaSumaColumnas;
        private System.Windows.Forms.Label lblSumaColumna;
        private System.Windows.Forms.Label lblSumaDiagonal;
        private System.Windows.Forms.Label lblElementosDiagonal;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnAbrir;
    }
}

