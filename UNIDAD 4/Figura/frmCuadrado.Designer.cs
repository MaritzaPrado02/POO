namespace Figura
{
    partial class frmCuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadrado));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRPerimetro = new System.Windows.Forms.Label();
            this.lblRArea = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblcm = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 215);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(59, 38);
            this.lblLado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(44, 16);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Lado:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(67, 127);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(75, 16);
            this.lblPerimetro.TabIndex = 2;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(67, 189);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Área:";
            // 
            // lblRPerimetro
            // 
            this.lblRPerimetro.AutoSize = true;
            this.lblRPerimetro.ForeColor = System.Drawing.Color.Red;
            this.lblRPerimetro.Location = new System.Drawing.Point(158, 127);
            this.lblRPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRPerimetro.Name = "lblRPerimetro";
            this.lblRPerimetro.Size = new System.Drawing.Size(0, 16);
            this.lblRPerimetro.TabIndex = 4;
            // 
            // lblRArea
            // 
            this.lblRArea.AutoSize = true;
            this.lblRArea.ForeColor = System.Drawing.Color.Red;
            this.lblRArea.Location = new System.Drawing.Point(158, 189);
            this.lblRArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRArea.Name = "lblRArea";
            this.lblRArea.Size = new System.Drawing.Size(0, 16);
            this.lblRArea.TabIndex = 5;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(137, 34);
            this.txtLado.Margin = new System.Windows.Forms.Padding(4);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(86, 22);
            this.txtLado.TabIndex = 6;
            this.txtLado.TextChanged += new System.EventHandler(this.txtLado_TextChanged);
            // 
            // lblcm
            // 
            this.lblcm.AutoSize = true;
            this.lblcm.Location = new System.Drawing.Point(243, 38);
            this.lblcm.Name = "lblcm";
            this.lblcm.Size = new System.Drawing.Size(27, 16);
            this.lblcm.TabIndex = 7;
            this.lblcm.Text = "cm";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(198, 214);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 33);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 259);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblcm);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblRArea);
            this.Controls.Add(this.lblRPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Purple;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCuadrado";
            this.Text = "Cuadrado";
            this.Load += new System.EventHandler(this.frmCuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRPerimetro;
        private System.Windows.Forms.Label lblRArea;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblcm;
        private System.Windows.Forms.Button btnCalcular;
    }
}