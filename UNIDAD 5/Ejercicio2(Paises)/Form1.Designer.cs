namespace Ejercicio2_Paises_
{
    partial class frmDatosPaises
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
            this.components = new System.ComponentModel.Container();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.grbDatosPais = new System.Windows.Forms.GroupBox();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.txtnumHabitantes = new System.Windows.Forms.TextBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColoresBandera = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblNumHabitantes = new System.Windows.Forms.Label();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grbDatosPais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCantidad
            // 
            this.nudCantidad.Enabled = false;
            this.nudCantidad.Location = new System.Drawing.Point(185, 19);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(37, 20);
            this.nudCantidad.TabIndex = 0;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(17, 21);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(149, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad de paises a registrar:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(21, 24);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(37, 13);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "País:";
            // 
            // grbDatosPais
            // 
            this.grbDatosPais.Controls.Add(this.txtColor3);
            this.grbDatosPais.Controls.Add(this.txtColor2);
            this.grbDatosPais.Controls.Add(this.txtColor1);
            this.grbDatosPais.Controls.Add(this.lblColor3);
            this.grbDatosPais.Controls.Add(this.lblColor2);
            this.grbDatosPais.Controls.Add(this.txtnumHabitantes);
            this.grbDatosPais.Controls.Add(this.cmbIdioma);
            this.grbDatosPais.Controls.Add(this.cmbPais);
            this.grbDatosPais.Controls.Add(this.lblColor1);
            this.grbDatosPais.Controls.Add(this.lblColoresBandera);
            this.grbDatosPais.Controls.Add(this.lblIdioma);
            this.grbDatosPais.Controls.Add(this.lblNumHabitantes);
            this.grbDatosPais.Controls.Add(this.lblPais);
            this.grbDatosPais.Location = new System.Drawing.Point(12, 84);
            this.grbDatosPais.Name = "grbDatosPais";
            this.grbDatosPais.Size = new System.Drawing.Size(251, 275);
            this.grbDatosPais.TabIndex = 3;
            this.grbDatosPais.TabStop = false;
            this.grbDatosPais.Text = "Datos País";
            this.grbDatosPais.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtColor3
            // 
            this.txtColor3.Location = new System.Drawing.Point(86, 242);
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(121, 20);
            this.txtColor3.TabIndex = 16;
            this.txtColor3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtColor2
            // 
            this.txtColor2.Location = new System.Drawing.Point(86, 211);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(121, 20);
            this.txtColor2.TabIndex = 15;
            // 
            // txtColor1
            // 
            this.txtColor1.Location = new System.Drawing.Point(86, 179);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(121, 20);
            this.txtColor1.TabIndex = 14;
            // 
            // lblColor3
            // 
            this.lblColor3.AutoSize = true;
            this.lblColor3.Location = new System.Drawing.Point(24, 249);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(43, 13);
            this.lblColor3.TabIndex = 13;
            this.lblColor3.Text = "Color 3:";
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Location = new System.Drawing.Point(24, 214);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(43, 13);
            this.lblColor2.TabIndex = 12;
            this.lblColor2.Text = "Color 2:";
            // 
            // txtnumHabitantes
            // 
            this.txtnumHabitantes.Location = new System.Drawing.Point(107, 61);
            this.txtnumHabitantes.Name = "txtnumHabitantes";
            this.txtnumHabitantes.Size = new System.Drawing.Size(100, 20);
            this.txtnumHabitantes.TabIndex = 11;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanés",
            "Alemán",
            "Amharico",
            "Arabe",
            "Armenio\t",
            "Bengali",
            "Bieloruso",
            "Birmanés",
            "Bulgaro\t",
            "Catalan",
            "Checo",
            "Chino",
            "Coreano",
            "Croata",
            "Danés",
            "Dari",
            "Dzongkha",
            "Escocés",
            "Eslovaco",
            "Esloveniano",
            "Español",
            "Esperanto",
            "Estoniano",
            "Faroese",
            "Farsi",
            "Finlandés",
            "Francés",
            "Gaelico",
            "Galese",
            "Gallego",
            "Griego",
            "Hebreo",
            "Hindi",
            "Holandés",
            "Hungaro",
            "Inglés",
            "Indonesio",
            "Inuktitut (Eskimo)",
            "Islandico",
            "Italiano",
            "Japonés",
            "Khmer",
            "Kurdo",
            "Lao",
            "Laponico",
            "Latviano",
            "Lituano",
            "Macedonio",
            "Malayés",
            "Maltés",
            "Nepali",
            "Noruego",
            "Pashto",
            "Polaco",
            "Portugués",
            "Rumano",
            "Ruso",
            "Serbio",
            "Somali",
            "Suahili",
            "Sueco",
            "Tagalog-Filipino",
            "Tajik",
            "Tamil",
            "Tailandés",
            "Tibetano",
            "Tigrinia",
            "Tonganés",
            "Turco",
            "Turkmenistano",
            "Ucraniano",
            "Urdu",
            "Uzbekistano",
            "Vasco",
            "Vietnamés"});
            this.cmbIdioma.Location = new System.Drawing.Point(86, 100);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 10;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania / Myanmar",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Ciudad del Vaticano",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea Ecuatorial",
            "Guinea",
            "Guinea-Bisáu",
            "Guyana",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán ",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macedonia del Norte",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda ",
            "Rumanía",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán del Sur",
            "Sudán",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.cmbPais.Location = new System.Drawing.Point(86, 21);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 9;
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Location = new System.Drawing.Point(24, 182);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(43, 13);
            this.lblColor1.TabIndex = 8;
            this.lblColor1.Text = "Color 1:";
            // 
            // lblColoresBandera
            // 
            this.lblColoresBandera.AutoSize = true;
            this.lblColoresBandera.Location = new System.Drawing.Point(24, 145);
            this.lblColoresBandera.Name = "lblColoresBandera";
            this.lblColoresBandera.Size = new System.Drawing.Size(150, 13);
            this.lblColoresBandera.TabIndex = 5;
            this.lblColoresBandera.Text = "Ingrese colores de la bandera:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(21, 103);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(48, 13);
            this.lblIdioma.TabIndex = 4;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblNumHabitantes
            // 
            this.lblNumHabitantes.AutoSize = true;
            this.lblNumHabitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHabitantes.Location = new System.Drawing.Point(21, 64);
            this.lblNumHabitantes.Name = "lblNumHabitantes";
            this.lblNumHabitantes.Size = new System.Drawing.Size(72, 13);
            this.lblNumHabitantes.TabIndex = 3;
            this.lblNumHabitantes.Text = "Habitantes:";
            // 
            // btnCantidad
            // 
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantidad.ForeColor = System.Drawing.Color.Teal;
            this.btnCantidad.Location = new System.Drawing.Point(171, 55);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(75, 23);
            this.btnCantidad.TabIndex = 4;
            this.btnCantidad.Text = "Registrar";
            this.btnCantidad.UseVisualStyleBackColor = true;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(171, 386);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.Location = new System.Drawing.Point(20, 386);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnImprimir.Location = new System.Drawing.Point(61, 439);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(148, 23);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir datos capturados";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDatosPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 477);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCantidad);
            this.Controls.Add(this.grbDatosPais);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmDatosPaises";
            this.Text = "Datos país";
            this.Load += new System.EventHandler(this.frmDatosPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grbDatosPais.ResumeLayout(false);
            this.grbDatosPais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.GroupBox grbDatosPais;
        private System.Windows.Forms.Label lblColoresBandera;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblNumHabitantes;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.Label lblColor3;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.TextBox txtnumHabitantes;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

