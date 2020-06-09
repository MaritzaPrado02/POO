namespace Ejercicio1_Pais_
{
    partial class frmRegistrarPais
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
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtColor3 = new System.Windows.Forms.TextBox();
            this.txtColor2 = new System.Windows.Forms.TextBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbNombrePais = new System.Windows.Forms.ComboBox();
            this.lblColor3 = new System.Windows.Forms.Label();
            this.txtNumHabitantes = new System.Windows.Forms.TextBox();
            this.txtColor1 = new System.Windows.Forms.TextBox();
            this.lblColor2 = new System.Windows.Forms.Label();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColoresBandera = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.Location = new System.Drawing.Point(25, 29);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(32, 13);
            this.lblNombrePais.TabIndex = 0;
            this.lblNombrePais.Text = "País:";
            this.lblNombrePais.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de habitantes:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(25, 101);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(41, 13);
            this.lblIdioma.TabIndex = 2;
            this.lblIdioma.Text = "Idioma:";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtColor3);
            this.grbDatos.Controls.Add(this.txtColor2);
            this.grbDatos.Controls.Add(this.cmbIdioma);
            this.grbDatos.Controls.Add(this.cmbNombrePais);
            this.grbDatos.Controls.Add(this.lblColor3);
            this.grbDatos.Controls.Add(this.txtNumHabitantes);
            this.grbDatos.Controls.Add(this.txtColor1);
            this.grbDatos.Controls.Add(this.lblColor2);
            this.grbDatos.Controls.Add(this.lblColor1);
            this.grbDatos.Controls.Add(this.lblColoresBandera);
            this.grbDatos.Controls.Add(this.lblIdioma);
            this.grbDatos.Controls.Add(this.lblNombrePais);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(304, 284);
            this.grbDatos.TabIndex = 3;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Ingrese datos del país";
            // 
            // txtColor3
            // 
            this.txtColor3.Location = new System.Drawing.Point(158, 242);
            this.txtColor3.Name = "txtColor3";
            this.txtColor3.Size = new System.Drawing.Size(117, 20);
            this.txtColor3.TabIndex = 12;
            // 
            // txtColor2
            // 
            this.txtColor2.Location = new System.Drawing.Point(158, 215);
            this.txtColor2.Name = "txtColor2";
            this.txtColor2.Size = new System.Drawing.Size(117, 20);
            this.txtColor2.TabIndex = 11;
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
            this.cmbIdioma.Location = new System.Drawing.Point(126, 98);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(149, 21);
            this.cmbIdioma.TabIndex = 10;
            // 
            // cmbNombrePais
            // 
            this.cmbNombrePais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombrePais.FormattingEnabled = true;
            this.cmbNombrePais.Items.AddRange(new object[] {
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
            this.cmbNombrePais.Location = new System.Drawing.Point(126, 26);
            this.cmbNombrePais.Name = "cmbNombrePais";
            this.cmbNombrePais.Size = new System.Drawing.Size(149, 21);
            this.cmbNombrePais.TabIndex = 9;
            // 
            // lblColor3
            // 
            this.lblColor3.AutoSize = true;
            this.lblColor3.Location = new System.Drawing.Point(25, 245);
            this.lblColor3.Name = "lblColor3";
            this.lblColor3.Size = new System.Drawing.Size(43, 13);
            this.lblColor3.TabIndex = 8;
            this.lblColor3.Text = "Color 3:";
            // 
            // txtNumHabitantes
            // 
            this.txtNumHabitantes.Location = new System.Drawing.Point(160, 62);
            this.txtNumHabitantes.Name = "txtNumHabitantes";
            this.txtNumHabitantes.Size = new System.Drawing.Size(115, 20);
            this.txtNumHabitantes.TabIndex = 7;
            // 
            // txtColor1
            // 
            this.txtColor1.Location = new System.Drawing.Point(158, 187);
            this.txtColor1.Name = "txtColor1";
            this.txtColor1.Size = new System.Drawing.Size(117, 20);
            this.txtColor1.TabIndex = 6;
            // 
            // lblColor2
            // 
            this.lblColor2.AutoSize = true;
            this.lblColor2.Location = new System.Drawing.Point(25, 218);
            this.lblColor2.Name = "lblColor2";
            this.lblColor2.Size = new System.Drawing.Size(43, 13);
            this.lblColor2.TabIndex = 5;
            this.lblColor2.Text = "Color 2:";
            // 
            // lblColor1
            // 
            this.lblColor1.AutoSize = true;
            this.lblColor1.Location = new System.Drawing.Point(25, 187);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(43, 13);
            this.lblColor1.TabIndex = 4;
            this.lblColor1.Text = "Color 1:";
            // 
            // lblColoresBandera
            // 
            this.lblColoresBandera.AutoSize = true;
            this.lblColoresBandera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColoresBandera.Location = new System.Drawing.Point(6, 144);
            this.lblColoresBandera.Name = "lblColoresBandera";
            this.lblColoresBandera.Size = new System.Drawing.Size(258, 13);
            this.lblColoresBandera.TabIndex = 3;
            this.lblColoresBandera.Text = "Ingrese los colores pricipales de la bandera:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Teal;
            this.btnGuardar.Location = new System.Drawing.Point(102, 315);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar e Imprimir";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(241, 348);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(241, 377);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmRegistrarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 407);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbDatos);
            this.Name = "frmRegistrarPais";
            this.Text = "Datos país";
            this.Load += new System.EventHandler(this.frmRegistrarPais_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblColor2;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.Label lblColoresBandera;
        private System.Windows.Forms.Label lblColor3;
        private System.Windows.Forms.TextBox txtNumHabitantes;
        private System.Windows.Forms.TextBox txtColor1;
        private System.Windows.Forms.ComboBox cmbNombrePais;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.TextBox txtColor3;
        private System.Windows.Forms.TextBox txtColor2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnLeer;
    }
}

