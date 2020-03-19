namespace Figura
{
    partial class frmFigura
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
            this.lblFigura = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.lblTipoTriangulo = new System.Windows.Forms.Label();
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.btnCalcularAreaPerimetro = new System.Windows.Forms.Button();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(38, 36);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(49, 16);
            this.lblFigura.TabIndex = 0;
            this.lblFigura.Text = "Figura";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(38, 96);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(0, 16);
            this.lblTriangulo.TabIndex = 1;
            // 
            // lblTipoTriangulo
            // 
            this.lblTipoTriangulo.AutoSize = true;
            this.lblTipoTriangulo.Location = new System.Drawing.Point(38, 96);
            this.lblTipoTriangulo.Name = "lblTipoTriangulo";
            this.lblTipoTriangulo.Size = new System.Drawing.Size(423, 16);
            this.lblTipoTriangulo.TabIndex = 2;
            this.lblTipoTriangulo.Text = "En caso de seleccionar Triangulo, seleccione el tipo de triangulo:";
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Location = new System.Drawing.Point(150, 32);
            this.cmbFigura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(159, 24);
            this.cmbFigura.TabIndex = 4;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // btnCalcularAreaPerimetro
            // 
            this.btnCalcularAreaPerimetro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularAreaPerimetro.Location = new System.Drawing.Point(222, 209);
            this.btnCalcularAreaPerimetro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcularAreaPerimetro.Name = "btnCalcularAreaPerimetro";
            this.btnCalcularAreaPerimetro.Size = new System.Drawing.Size(210, 28);
            this.btnCalcularAreaPerimetro.TabIndex = 6;
            this.btnCalcularAreaPerimetro.Text = "Calcular área y perimetro";
            this.btnCalcularAreaPerimetro.UseVisualStyleBackColor = true;
            this.btnCalcularAreaPerimetro.Click += new System.EventHandler(this.btnCalcularAreaPerimetro_Click);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Location = new System.Drawing.Point(150, 139);
            this.cmbTriangulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(159, 24);
            this.cmbTriangulo.TabIndex = 7;
            // 
            // frmFigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 253);
            this.Controls.Add(this.cmbTriangulo);
            this.Controls.Add(this.btnCalcularAreaPerimetro);
            this.Controls.Add(this.cmbFigura);
            this.Controls.Add(this.lblTipoTriangulo);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.lblFigura);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFigura";
            this.Text = "Área y perimetro de una figura";
            this.Load += new System.EventHandler(this.frmFigura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Label lblTipoTriangulo;
        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Button btnCalcularAreaPerimetro;
        private System.Windows.Forms.ComboBox cmbTriangulo;
    }
}

