namespace Figura
{
    partial class frmCirculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCirculo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRadio = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRPerimetro = new System.Windows.Forms.Label();
            this.lblRArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRadio2 = new System.Windows.Forms.TextBox();
            this.lblcmR = new System.Windows.Forms.Label();
            this.lblcmP = new System.Windows.Forms.Label();
            this.lblcmA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtRadio
            // 
            this.txtRadio.AutoSize = true;
            this.txtRadio.Location = new System.Drawing.Point(53, 41);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(45, 16);
            this.txtRadio.TabIndex = 1;
            this.txtRadio.Text = "Radio";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(56, 114);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(75, 16);
            this.lblPerimetro.TabIndex = 3;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(59, 164);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Área:";
            this.lblArea.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblRPerimetro
            // 
            this.lblRPerimetro.AutoSize = true;
            this.lblRPerimetro.ForeColor = System.Drawing.Color.Red;
            this.lblRPerimetro.Location = new System.Drawing.Point(152, 114);
            this.lblRPerimetro.Name = "lblRPerimetro";
            this.lblRPerimetro.Size = new System.Drawing.Size(0, 16);
            this.lblRPerimetro.TabIndex = 5;
            // 
            // lblRArea
            // 
            this.lblRArea.AutoSize = true;
            this.lblRArea.ForeColor = System.Drawing.Color.Red;
            this.lblRArea.Location = new System.Drawing.Point(152, 164);
            this.lblRArea.Name = "lblRArea";
            this.lblRArea.Size = new System.Drawing.Size(0, 16);
            this.lblRArea.TabIndex = 6;
            this.lblRArea.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(123, 229);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(96, 28);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtRadio2
            // 
            this.txtRadio2.Location = new System.Drawing.Point(119, 38);
            this.txtRadio2.Name = "txtRadio2";
            this.txtRadio2.Size = new System.Drawing.Size(100, 22);
            this.txtRadio2.TabIndex = 8;
            // 
            // lblcmR
            // 
            this.lblcmR.AutoSize = true;
            this.lblcmR.Location = new System.Drawing.Point(227, 41);
            this.lblcmR.Name = "lblcmR";
            this.lblcmR.Size = new System.Drawing.Size(27, 16);
            this.lblcmR.TabIndex = 9;
            this.lblcmR.Text = "cm";
            // 
            // lblcmP
            // 
            this.lblcmP.AutoSize = true;
            this.lblcmP.Location = new System.Drawing.Point(247, 114);
            this.lblcmP.Name = "lblcmP";
            this.lblcmP.Size = new System.Drawing.Size(27, 16);
            this.lblcmP.TabIndex = 10;
            this.lblcmP.Text = "cm";
            // 
            // lblcmA
            // 
            this.lblcmA.AutoSize = true;
            this.lblcmA.Location = new System.Drawing.Point(247, 164);
            this.lblcmA.Name = "lblcmA";
            this.lblcmA.Size = new System.Drawing.Size(27, 16);
            this.lblcmA.TabIndex = 11;
            this.lblcmA.Text = "cm";
            // 
            // frmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 287);
            this.Controls.Add(this.lblcmA);
            this.Controls.Add(this.lblcmP);
            this.Controls.Add(this.lblcmR);
            this.Controls.Add(this.txtRadio2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRArea);
            this.Controls.Add(this.lblRPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCirculo";
            this.Text = "Circulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtRadio;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblRPerimetro;
        private System.Windows.Forms.Label lblRArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRadio2;
        private System.Windows.Forms.Label lblcmR;
        private System.Windows.Forms.Label lblcmP;
        private System.Windows.Forms.Label lblcmA;
    }
}