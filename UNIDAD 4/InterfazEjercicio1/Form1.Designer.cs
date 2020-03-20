namespace InterfazEjercicio1
{
    partial class frmExamen
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
            this.lblAciertos = new System.Windows.Forms.Label();
            this.lblTotalRespuestas = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.txtTotalRespuestas = new System.Windows.Forms.TextBox();
            this.txtAciertos = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAciertos
            // 
            this.lblAciertos.AutoSize = true;
            this.lblAciertos.Location = new System.Drawing.Point(54, 98);
            this.lblAciertos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAciertos.Name = "lblAciertos";
            this.lblAciertos.Size = new System.Drawing.Size(78, 19);
            this.lblAciertos.TabIndex = 0;
            this.lblAciertos.Text = "Aciertos:";
            // 
            // lblTotalRespuestas
            // 
            this.lblTotalRespuestas.AutoSize = true;
            this.lblTotalRespuestas.Location = new System.Drawing.Point(54, 37);
            this.lblTotalRespuestas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalRespuestas.Name = "lblTotalRespuestas";
            this.lblTotalRespuestas.Size = new System.Drawing.Size(141, 19);
            this.lblTotalRespuestas.TabIndex = 1;
            this.lblTotalRespuestas.Text = "Total respuestas:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(65, 190);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(83, 19);
            this.lblPromedio.TabIndex = 2;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.ForeColor = System.Drawing.Color.Red;
            this.lblNivel.Location = new System.Drawing.Point(414, 187);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(0, 19);
            this.lblNivel.TabIndex = 3;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEvaluar.Location = new System.Drawing.Point(435, 62);
            this.btnEvaluar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(125, 34);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // txtTotalRespuestas
            // 
            this.txtTotalRespuestas.Location = new System.Drawing.Point(225, 37);
            this.txtTotalRespuestas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotalRespuestas.Name = "txtTotalRespuestas";
            this.txtTotalRespuestas.Size = new System.Drawing.Size(164, 26);
            this.txtTotalRespuestas.TabIndex = 5;
            // 
            // txtAciertos
            // 
            this.txtAciertos.Location = new System.Drawing.Point(225, 95);
            this.txtAciertos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAciertos.Name = "txtAciertos";
            this.txtAciertos.Size = new System.Drawing.Size(164, 26);
            this.txtAciertos.TabIndex = 6;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(183, 187);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(94, 26);
            this.txtPromedio.TabIndex = 7;
            // 
            // frmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 250);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtAciertos);
            this.Controls.Add(this.txtTotalRespuestas);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotalRespuestas);
            this.Controls.Add(this.lblAciertos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmExamen";
            this.Text = "Evaluar exámen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAciertos;
        private System.Windows.Forms.Label lblTotalRespuestas;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txtTotalRespuestas;
        private System.Windows.Forms.TextBox txtAciertos;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}

