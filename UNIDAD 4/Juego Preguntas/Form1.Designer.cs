namespace Juego_Preguntas
{
    partial class frmInicio
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
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.pcb4 = new System.Windows.Forms.PictureBox();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcb6 = new System.Windows.Forms.PictureBox();
            this.pcb5 = new System.Windows.Forms.PictureBox();
            this.pcb3 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblInstrucciones.Location = new System.Drawing.Point(5, 9);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(504, 80);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Juego de Preguntas\r\n\r\n¡Pon a prueba tus conocimento en diversas áreas con este Ju" +
    "ego de Preguntas!\r\nLee cuidadosamente las preguntas y selecciona la respuesta.\r\n" +
    "";
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.ForeColor = System.Drawing.Color.Purple;
            this.btnJugar.Location = new System.Drawing.Point(225, 291);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 32);
            this.btnJugar.TabIndex = 7;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pcb4
            // 
            this.pcb4.BackgroundImage = global::Juego_Preguntas.Properties.Resources.Matemáticas;
            this.pcb4.Location = new System.Drawing.Point(117, 203);
            this.pcb4.Name = "pcb4";
            this.pcb4.Size = new System.Drawing.Size(50, 50);
            this.pcb4.TabIndex = 6;
            this.pcb4.TabStop = false;
            // 
            // pcb1
            // 
            this.pcb1.BackgroundImage = global::Juego_Preguntas.Properties.Resources.Programación;
            this.pcb1.Location = new System.Drawing.Point(117, 123);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(50, 50);
            this.pcb1.TabIndex = 5;
            this.pcb1.TabStop = false;
            // 
            // pcb6
            // 
            this.pcb6.BackgroundImage = global::Juego_Preguntas.Properties.Resources.Historia;
            this.pcb6.Location = new System.Drawing.Point(364, 203);
            this.pcb6.Name = "pcb6";
            this.pcb6.Size = new System.Drawing.Size(50, 50);
            this.pcb6.TabIndex = 4;
            this.pcb6.TabStop = false;
            // 
            // pcb5
            // 
            this.pcb5.BackgroundImage = global::Juego_Preguntas.Properties.Resources.Cine;
            this.pcb5.Location = new System.Drawing.Point(238, 203);
            this.pcb5.Name = "pcb5";
            this.pcb5.Size = new System.Drawing.Size(50, 50);
            this.pcb5.TabIndex = 3;
            this.pcb5.TabStop = false;
            // 
            // pcb3
            // 
            this.pcb3.BackgroundImage = global::Juego_Preguntas.Properties.Resources.Cultura;
            this.pcb3.Location = new System.Drawing.Point(364, 123);
            this.pcb3.Name = "pcb3";
            this.pcb3.Size = new System.Drawing.Size(50, 50);
            this.pcb3.TabIndex = 2;
            this.pcb3.TabStop = false;
            // 
            // pcb2
            // 
            this.pcb2.BackgroundImage = global::Juego_Preguntas.Properties.Resources.Ciencia;
            this.pcb2.Location = new System.Drawing.Point(238, 123);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(50, 50);
            this.pcb2.TabIndex = 1;
            this.pcb2.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(521, 361);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pcb4);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.pcb6);
            this.Controls.Add(this.pcb5);
            this.Controls.Add(this.pcb3);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.lblInstrucciones);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInicio";
            this.Text = "Instrucciones";
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.PictureBox pcb3;
        private System.Windows.Forms.PictureBox pcb5;
        private System.Windows.Forms.PictureBox pcb6;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.PictureBox pcb4;
        private System.Windows.Forms.Button btnJugar;
    }
}

