
namespace CRUDWinFormsMVP.Views
{
    partial class ClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.lblClientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClientList = new System.Windows.Forms.TabPage();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPageClientDetail = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCommune = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.tabPageClientDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(53, 17);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(105, 29);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1113, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageClientList);
            this.tabControl1.Controls.Add(this.tabPageClientDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 629);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageClientList
            // 
            this.tabPageClientList.BackColor = System.Drawing.Color.Beige;
            this.tabPageClientList.Controls.Add(this.dgvClient);
            this.tabPageClientList.Controls.Add(this.label2);
            this.tabPageClientList.Controls.Add(this.btnDelete);
            this.tabPageClientList.Controls.Add(this.btnEdit);
            this.tabPageClientList.Controls.Add(this.btnAddClient);
            this.tabPageClientList.Controls.Add(this.btnSearch);
            this.tabPageClientList.Controls.Add(this.txtSearch);
            this.tabPageClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageClientList.Location = new System.Drawing.Point(4, 34);
            this.tabPageClientList.Name = "tabPageClientList";
            this.tabPageClientList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientList.Size = new System.Drawing.Size(1148, 591);
            this.tabPageClientList.TabIndex = 0;
            this.tabPageClientList.Text = "Lista Cliente";
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClient.ColumnHeadersHeight = 29;
            this.dgvClient.Location = new System.Drawing.Point(24, 77);
            this.dgvClient.MultiSelect = false;
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(898, 468);
            this.dgvClient.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar cliente:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(928, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Habilitar/Deshabilitar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(928, 119);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(202, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar cliente";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.Location = new System.Drawing.Point(928, 77);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(202, 36);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Agregar cliente";
            this.btnAddClient.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(829, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(24, 31);
            this.txtSearch.MaxLength = 80;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(799, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPageClientDetail
            // 
            this.tabPageClientDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageClientDetail.Controls.Add(this.label17);
            this.tabPageClientDetail.Controls.Add(this.txtCommune);
            this.tabPageClientDetail.Controls.Add(this.label15);
            this.tabPageClientDetail.Controls.Add(this.txtURL);
            this.tabPageClientDetail.Controls.Add(this.txtObservations);
            this.tabPageClientDetail.Controls.Add(this.label9);
            this.tabPageClientDetail.Controls.Add(this.label12);
            this.tabPageClientDetail.Controls.Add(this.txtPhone);
            this.tabPageClientDetail.Controls.Add(this.label13);
            this.tabPageClientDetail.Controls.Add(this.txtStreet);
            this.tabPageClientDetail.Controls.Add(this.label14);
            this.tabPageClientDetail.Controls.Add(this.txtRegion);
            this.tabPageClientDetail.Controls.Add(this.label8);
            this.tabPageClientDetail.Controls.Add(this.txtCountry);
            this.tabPageClientDetail.Controls.Add(this.label7);
            this.tabPageClientDetail.Controls.Add(this.txtBusinessName);
            this.tabPageClientDetail.Controls.Add(this.label1);
            this.tabPageClientDetail.Controls.Add(this.txtEmail);
            this.tabPageClientDetail.Controls.Add(this.btnCancel);
            this.tabPageClientDetail.Controls.Add(this.btnSave);
            this.tabPageClientDetail.Controls.Add(this.label6);
            this.tabPageClientDetail.Controls.Add(this.txtRut);
            this.tabPageClientDetail.Controls.Add(this.label5);
            this.tabPageClientDetail.Controls.Add(this.txtClientType);
            this.tabPageClientDetail.Controls.Add(this.label4);
            this.tabPageClientDetail.Controls.Add(this.txtClientName);
            this.tabPageClientDetail.Controls.Add(this.label3);
            this.tabPageClientDetail.Controls.Add(this.txtUserID);
            this.tabPageClientDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageClientDetail.Location = new System.Drawing.Point(4, 34);
            this.tabPageClientDetail.Name = "tabPageClientDetail";
            this.tabPageClientDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientDetail.Size = new System.Drawing.Size(1148, 591);
            this.tabPageClientDetail.TabIndex = 1;
            this.tabPageClientDetail.Text = "Cliente Detalles";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(416, 268);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(114, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "Comuna (*)";
            // 
            // txtCommune
            // 
            this.txtCommune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommune.Location = new System.Drawing.Point(420, 291);
            this.txtCommune.MaxLength = 50;
            this.txtCommune.Name = "txtCommune";
            this.txtCommune.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCommune.Size = new System.Drawing.Size(245, 34);
            this.txtCommune.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(696, 149);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(296, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "URL dirección (Google Maps) (*)";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(700, 172);
            this.txtURL.MaxLength = 255;
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtURL.Size = new System.Drawing.Size(292, 114);
            this.txtURL.TabIndex = 11;
            // 
            // txtObservations
            // 
            this.txtObservations.AccessibleName = "";
            this.txtObservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservations.Location = new System.Drawing.Point(700, 335);
            this.txtObservations.MaxLength = 255;
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtObservations.Size = new System.Drawing.Size(292, 104);
            this.txtObservations.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(695, 309);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Observaciones";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(126, 414);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Telefono (*)";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(130, 437);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhone.Size = new System.Drawing.Size(245, 34);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Tag = "";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(417, 341);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(84, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Calle (*)";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreet.Location = new System.Drawing.Point(421, 364);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStreet.Size = new System.Drawing.Size(245, 34);
            this.txtStreet.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(415, 188);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 23;
            this.label14.Text = "Región (*)";
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegion.Location = new System.Drawing.Point(419, 211);
            this.txtRegion.MaxLength = 50;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRegion.Size = new System.Drawing.Size(245, 34);
            this.txtRegion.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 108);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "País (*)";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Angola",
            "Argelia",
            "Benin",
            "Botsuana",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Camerún",
            "Chad",
            "Comoras",
            "Costa De Marfil",
            "Egipto",
            "Eritrea",
            "Etiopía",
            "Gabón",
            "Gambia",
            "Ghana",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bissau",
            "Kenia",
            "Lesoto",
            "Liberia",
            "Libia",
            "Madagascar",
            "Malaui",
            "Mali",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "Mozambique",
            "Namibia",
            "Níger",
            "Nigeria",
            "República Centroafricana",
            "República Del Congo",
            "República Democrática Del Congo",
            "Ruanda",
            "Santo Tomé Y Príncipe",
            "Senegal",
            "Seychelles",
            "Sierra Leona",
            "Somalia",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán Del Sur",
            "Tanzania",
            "Togo",
            "Túnez",
            "Uganda",
            "Yibuti",
            "Zambia",
            "Zimbabue",
            "Antigua Y Barbuda",
            "Argentina",
            "Bahamas",
            "Barbados",
            "Belice",
            "Bolivia",
            "Brasil",
            "Canadá",
            "Chile",
            "Colombia",
            "Costa Rica",
            "Cuba",
            "Dominica",
            "Ecuador",
            "El Salvador",
            "Estados Unidos",
            "Granada",
            "Guatemala",
            "Guyana",
            "Haití",
            "Honduras",
            "Jamaica",
            "México",
            "Nicaragua",
            "Panamá",
            "Paraguay",
            "Perú",
            "Puerto Rico",
            "República Dominicana",
            "San Cristóbal Y Nieves",
            "San Vicente Y Las Granadinas",
            "Santa Lucía",
            "Surinam",
            "Trinidad Y Tobago",
            "Uruguay",
            "Venezuela",
            "Afganistán",
            "Arabia Saudita",
            "Bangladés",
            "Baréin",
            "Brunei",
            "Bután",
            "Camboya",
            "Catar",
            "China",
            "Chipre",
            "Corea Del Norte",
            "Corea Del Sur",
            "Emiratos Arabes Unidos",
            "Filipinas",
            "India",
            "Indonesia",
            "Irán",
            "Iraq",
            "Israel",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kirguistán",
            "Kuwait",
            "Laos",
            "Líbano",
            "Malasia",
            "Maldivas",
            "Mongolia",
            "Myanmar (Birmania)",
            "Nepal",
            "Omán",
            "Pakistán",
            "Palestina",
            "Siria",
            "Sri Lanka",
            "Tailandia",
            "Tayikistán",
            "Timor Oriental",
            "Turkmenistán",
            "Turquía",
            "Uzbekistán",
            "Vietnam",
            "Yemen",
            "Albania",
            "Alemania",
            "Andorra",
            "Armenia",
            "Austria",
            "Azerbaiyán",
            "Bélgica",
            "Bielorrusia",
            "Bosnia Y Herzegovina",
            "Bulgaria",
            "Croacia",
            "Dinamarca",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estonia",
            "Finlandia",
            "Francia",
            "Georgia",
            "Grecia",
            "Hungría",
            "Irlanda",
            "Islandia",
            "Italia",
            "Letonia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Malta",
            "Moldavia",
            "Mónaco",
            "Montenegro",
            "Noruega",
            "Países Bajos",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Checa",
            "República De Macedonia",
            "Rumania",
            "Rusia",
            "San Marino",
            "Serbia",
            "Suecia",
            "Suiza",
            "Ucrania",
            "Australia",
            "Fiyi",
            "Islas Marshall",
            "Islas Salomón",
            "Kiribati",
            "Micronesia",
            "Nauru",
            "Nueva Zelanda",
            "Palaos",
            "Papúa Nueva Guinea",
            "Samoa",
            "Tonga",
            "Tuvalu",
            "Vanuatu"});
            this.txtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCountry.Location = new System.Drawing.Point(419, 131);
            this.txtCountry.MaxLength = 50;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountry.Size = new System.Drawing.Size(245, 34);
            this.txtCountry.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 414);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Razón social (*)";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusinessName.Location = new System.Drawing.Point(419, 437);
            this.txtBusinessName.MaxLength = 50;
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBusinessName.Size = new System.Drawing.Size(245, 34);
            this.txtBusinessName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 261);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email (*)";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(131, 284);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(238, 34);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(581, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(353, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(193, 44);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Guardar cliente";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 181);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rut (*)";
            // 
            // txtRut
            // 
            this.txtRut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRut.Location = new System.Drawing.Point(131, 204);
            this.txtRut.MaxLength = 10;
            this.txtRut.Name = "txtRut";
            this.txtRut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRut.Size = new System.Drawing.Size(238, 34);
            this.txtRut.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 341);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo cliente (*)";
            // 
            // txtClientType
            // 
            this.txtClientType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientType.AutoCompleteCustomSource.AddRange(new string[] {
            "Nacional",
            "Internacional"});
            this.txtClientType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtClientType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtClientType.Location = new System.Drawing.Point(131, 364);
            this.txtClientType.MaxLength = 13;
            this.txtClientType.Name = "txtClientType";
            this.txtClientType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientType.Size = new System.Drawing.Size(238, 34);
            this.txtClientType.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 108);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre cliente (*)";
            // 
            // txtClientName
            // 
            this.txtClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientName.Location = new System.Drawing.Point(131, 131);
            this.txtClientName.MaxLength = 50;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientName.Size = new System.Drawing.Size(238, 34);
            this.txtClientName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserID.Location = new System.Drawing.Point(131, 60);
            this.txtUserID.MaxLength = 10;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserID.Size = new System.Drawing.Size(154, 34);
            this.txtUserID.TabIndex = 14;
            this.txtUserID.Text = "0";
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1156, 685);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientView";
            this.Text = "Feria virtual - Cliente ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageClientList.ResumeLayout(false);
            this.tabPageClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.tabPageClientDetail.ResumeLayout(false);
            this.tabPageClientDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClientList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPageClientDetail;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCommune;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.PictureBox btnClose;
    }
}