namespace Captura_de_datos
{
    partial class VentanaDeInforme
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
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblInforme = new System.Windows.Forms.Label();
            this.lblCantidadEvaluados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSalir.Location = new System.Drawing.Point(144, 454);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(38, 16);
            this.lblSalir.TabIndex = 0;
            this.lblSalir.Text = "Salir ";
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(50, 39);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(98, 28);
            this.lblInforme.TabIndex = 1;
            this.lblInforme.Text = "Informe";
            this.lblInforme.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantidadEvaluados
            // 
            this.lblCantidadEvaluados.AutoSize = true;
            this.lblCantidadEvaluados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEvaluados.Location = new System.Drawing.Point(52, 109);
            this.lblCantidadEvaluados.Name = "lblCantidadEvaluados";
            this.lblCantidadEvaluados.Size = new System.Drawing.Size(90, 13);
            this.lblCantidadEvaluados.TabIndex = 2;
            this.lblCantidadEvaluados.Text = "Se evaluaron: ";
            // 
            // VentanaDeInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(332, 495);
            this.Controls.Add(this.lblCantidadEvaluados);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lblSalir);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaDeInforme";
            this.Text = "Informe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.Label lblCantidadEvaluados;
    }
}