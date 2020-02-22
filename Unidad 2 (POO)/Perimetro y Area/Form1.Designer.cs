namespace Perimetro_y_Area
{
    partial class frmCuadrado
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
            this.lblndicacionMedida = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblCm = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblCmPer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCmArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblndicacionMedida
            // 
            this.lblndicacionMedida.AutoSize = true;
            this.lblndicacionMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblndicacionMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblndicacionMedida.Location = new System.Drawing.Point(12, 25);
            this.lblndicacionMedida.Name = "lblndicacionMedida";
            this.lblndicacionMedida.Size = new System.Drawing.Size(298, 16);
            this.lblndicacionMedida.TabIndex = 0;
            this.lblndicacionMedida.Text = "Ingrese la medida del lado del cuadrado: ";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.ForeColor = System.Drawing.Color.Blue;
            this.lblLado.Location = new System.Drawing.Point(68, 69);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(43, 15);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Lado:";
            // 
            // txtLado
            // 
            this.txtLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado.ForeColor = System.Drawing.Color.Red;
            this.txtLado.Location = new System.Drawing.Point(117, 69);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(50, 20);
            this.txtLado.TabIndex = 2;
            this.txtLado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCm.Location = new System.Drawing.Point(176, 69);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(26, 15);
            this.lblCm.TabIndex = 3;
            this.lblCm.Text = "cm";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Indigo;
            this.btnCalcular.Location = new System.Drawing.Point(204, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPerimetro.Location = new System.Drawing.Point(12, 150);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(83, 16);
            this.lblPerimetro.TabIndex = 5;
            this.lblPerimetro.Text = "Perímetro: ";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.ForeColor = System.Drawing.Color.Red;
            this.txtPerimetro.Location = new System.Drawing.Point(90, 146);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(77, 20);
            this.txtPerimetro.TabIndex = 6;
            // 
            // lblCmPer
            // 
            this.lblCmPer.AutoSize = true;
            this.lblCmPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCmPer.Location = new System.Drawing.Point(173, 150);
            this.lblCmPer.Name = "lblCmPer";
            this.lblCmPer.Size = new System.Drawing.Size(28, 16);
            this.lblCmPer.TabIndex = 7;
            this.lblCmPer.Text = "cm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Área:";
            // 
            // lblCmArea
            // 
            this.lblCmArea.AutoSize = true;
            this.lblCmArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCmArea.Location = new System.Drawing.Point(173, 179);
            this.lblCmArea.Name = "lblCmArea";
            this.lblCmArea.Size = new System.Drawing.Size(26, 15);
            this.lblCmArea.TabIndex = 9;
            this.lblCmArea.Text = "cm";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.ForeColor = System.Drawing.Color.Red;
            this.txtArea.Location = new System.Drawing.Point(90, 179);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(77, 20);
            this.txtArea.TabIndex = 10;
            // 
            // frmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(321, 249);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblCmArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCmPer);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCm);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblndicacionMedida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCuadrado";
            this.Text = "Calcular área y perímetro de un cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblndicacionMedida;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblCmPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCmArea;
        private System.Windows.Forms.TextBox txtArea;
    }
}

