namespace Figura
{
    partial class frmTri_Equilatero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTri_Equilatero));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRPerimetro = new System.Windows.Forms.Label();
            this.lblRArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblcmL = new System.Windows.Forms.Label();
            this.lblCmP = new System.Windows.Forms.Label();
            this.lblCmA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 227);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(37, 34);
            this.lblLado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(48, 16);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Lado: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(37, 134);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(75, 16);
            this.lblPerimetro.TabIndex = 2;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(37, 196);
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
            this.lblRPerimetro.Location = new System.Drawing.Point(157, 134);
            this.lblRPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRPerimetro.Name = "lblRPerimetro";
            this.lblRPerimetro.Size = new System.Drawing.Size(0, 16);
            this.lblRPerimetro.TabIndex = 4;
            // 
            // lblRArea
            // 
            this.lblRArea.AutoSize = true;
            this.lblRArea.ForeColor = System.Drawing.Color.Red;
            this.lblRArea.Location = new System.Drawing.Point(157, 196);
            this.lblRArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRArea.Name = "lblRArea";
            this.lblRArea.Size = new System.Drawing.Size(0, 16);
            this.lblRArea.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(174, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 29);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(104, 31);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 22);
            this.txtLado.TabIndex = 7;
            // 
            // lblcmL
            // 
            this.lblcmL.AutoSize = true;
            this.lblcmL.Location = new System.Drawing.Point(219, 37);
            this.lblcmL.Name = "lblcmL";
            this.lblcmL.Size = new System.Drawing.Size(27, 16);
            this.lblcmL.TabIndex = 8;
            this.lblcmL.Text = "cm";
            // 
            // lblCmP
            // 
            this.lblCmP.AutoSize = true;
            this.lblCmP.Location = new System.Drawing.Point(278, 134);
            this.lblCmP.Name = "lblCmP";
            this.lblCmP.Size = new System.Drawing.Size(27, 16);
            this.lblCmP.TabIndex = 9;
            this.lblCmP.Text = "cm";
            // 
            // lblCmA
            // 
            this.lblCmA.AutoSize = true;
            this.lblCmA.Location = new System.Drawing.Point(278, 196);
            this.lblCmA.Name = "lblCmA";
            this.lblCmA.Size = new System.Drawing.Size(27, 16);
            this.lblCmA.TabIndex = 10;
            this.lblCmA.Text = "cm";
            // 
            // frmTri_Equilatero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 317);
            this.Controls.Add(this.lblCmA);
            this.Controls.Add(this.lblCmP);
            this.Controls.Add(this.lblcmL);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRArea);
            this.Controls.Add(this.lblRPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTri_Equilatero";
            this.Text = "Triangulo Equilatero";
            this.Load += new System.EventHandler(this.frmTri_Equilatero_Load);
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
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblcmL;
        private System.Windows.Forms.Label lblCmP;
        private System.Windows.Forms.Label lblCmA;
    }
}