namespace AzkenErronka_DAM2.Artistak
{
    partial class frmArtistak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtistak));
            this.label1 = new System.Windows.Forms.Label();
            this.panel0_SALIR = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAtzera = new System.Windows.Forms.ToolStripButton();
            this.p1_Filtros = new System.Windows.Forms.Panel();
            this.gbEgoera = new System.Windows.Forms.GroupBox();
            this.rdbGuztiak = new System.Windows.Forms.RadioButton();
            this.rdbErretiratuta = new System.Windows.Forms.RadioButton();
            this.rdbEzezaguna = new System.Windows.Forms.RadioButton();
            this.rdbJardunean = new System.Windows.Forms.RadioButton();
            this.cbHasieraUrtea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazionalitateKodea = new System.Windows.Forms.TextBox();
            this.pctNazionalitatea = new System.Windows.Forms.PictureBox();
            this.txtNazionalitateIzena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numKideKopurua = new System.Windows.Forms.NumericUpDown();
            this.txtArtistaMotaKodea = new System.Windows.Forms.TextBox();
            this.pctArtistaMota = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtistaDeskribapena = new System.Windows.Forms.TextBox();
            this.txtArtistaMotaIzena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArtistaIzena = new System.Windows.Forms.TextBox();
            this.txtArtistaKodea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_SUPERIOR = new System.Windows.Forms.Panel();
            this.panel_Izquierdo = new System.Windows.Forms.Panel();
            this.dgArtistas = new System.Windows.Forms.DataGridView();
            this.panel_GENERAL = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Inferior = new System.Windows.Forms.Panel();
            this.txtKideKopurua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAlbumKopurua = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAbestiKopurua = new System.Windows.Forms.Label();
            this.panel0_SALIR.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.p1_Filtros.SuspendLayout();
            this.gbEgoera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNazionalitatea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKideKopurua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArtistaMota)).BeginInit();
            this.panel_SUPERIOR.SuspendLayout();
            this.panel_Izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistas)).BeginInit();
            this.panel_GENERAL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Inferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARTISTAK Microsoft Sans Serif; 8,25pt";
            // 
            // panel0_SALIR
            // 
            this.panel0_SALIR.Controls.Add(this.toolStrip1);
            this.panel0_SALIR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel0_SALIR.Location = new System.Drawing.Point(0, 0);
            this.panel0_SALIR.Name = "panel0_SALIR";
            this.panel0_SALIR.Size = new System.Drawing.Size(1294, 25);
            this.panel0_SALIR.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtzera});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1294, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAtzera
            // 
            this.btnAtzera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtzera.Image = ((System.Drawing.Image)(resources.GetObject("btnAtzera.Image")));
            this.btnAtzera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtzera.Name = "btnAtzera";
            this.btnAtzera.Size = new System.Drawing.Size(23, 22);
            this.btnAtzera.Text = "Atzera";
            this.btnAtzera.Click += new System.EventHandler(this.btnAtzera_Click);
            // 
            // p1_Filtros
            // 
            this.p1_Filtros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1_Filtros.Controls.Add(this.gbEgoera);
            this.p1_Filtros.Controls.Add(this.cbHasieraUrtea);
            this.p1_Filtros.Controls.Add(this.label8);
            this.p1_Filtros.Controls.Add(this.txtNazionalitateKodea);
            this.p1_Filtros.Controls.Add(this.pctNazionalitatea);
            this.p1_Filtros.Controls.Add(this.txtNazionalitateIzena);
            this.p1_Filtros.Controls.Add(this.label7);
            this.p1_Filtros.Controls.Add(this.numKideKopurua);
            this.p1_Filtros.Controls.Add(this.txtArtistaMotaKodea);
            this.p1_Filtros.Controls.Add(this.pctArtistaMota);
            this.p1_Filtros.Controls.Add(this.btnLimpiar);
            this.p1_Filtros.Controls.Add(this.btnAceptar);
            this.p1_Filtros.Controls.Add(this.label6);
            this.p1_Filtros.Controls.Add(this.txtArtistaDeskribapena);
            this.p1_Filtros.Controls.Add(this.txtArtistaMotaIzena);
            this.p1_Filtros.Controls.Add(this.label5);
            this.p1_Filtros.Controls.Add(this.txtArtistaIzena);
            this.p1_Filtros.Controls.Add(this.txtArtistaKodea);
            this.p1_Filtros.Controls.Add(this.label4);
            this.p1_Filtros.Controls.Add(this.label3);
            this.p1_Filtros.Controls.Add(this.label2);
            this.p1_Filtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1_Filtros.Location = new System.Drawing.Point(0, 25);
            this.p1_Filtros.Name = "p1_Filtros";
            this.p1_Filtros.Size = new System.Drawing.Size(1294, 155);
            this.p1_Filtros.TabIndex = 1;
            // 
            // gbEgoera
            // 
            this.gbEgoera.Controls.Add(this.rdbGuztiak);
            this.gbEgoera.Controls.Add(this.rdbErretiratuta);
            this.gbEgoera.Controls.Add(this.rdbEzezaguna);
            this.gbEgoera.Controls.Add(this.rdbJardunean);
            this.gbEgoera.Location = new System.Drawing.Point(899, 18);
            this.gbEgoera.Name = "gbEgoera";
            this.gbEgoera.Size = new System.Drawing.Size(349, 43);
            this.gbEgoera.TabIndex = 23;
            this.gbEgoera.TabStop = false;
            this.gbEgoera.Text = "Egoera:";
            // 
            // rdbGuztiak
            // 
            this.rdbGuztiak.AutoSize = true;
            this.rdbGuztiak.Location = new System.Drawing.Point(253, 19);
            this.rdbGuztiak.Name = "rdbGuztiak";
            this.rdbGuztiak.Size = new System.Drawing.Size(85, 17);
            this.rdbGuztiak.TabIndex = 2;
            this.rdbGuztiak.Text = "Guztiak ikusi";
            this.rdbGuztiak.UseVisualStyleBackColor = true;
            // 
            // rdbErretiratuta
            // 
            this.rdbErretiratuta.AutoSize = true;
            this.rdbErretiratuta.Location = new System.Drawing.Point(171, 19);
            this.rdbErretiratuta.Name = "rdbErretiratuta";
            this.rdbErretiratuta.Size = new System.Drawing.Size(76, 17);
            this.rdbErretiratuta.TabIndex = 1;
            this.rdbErretiratuta.TabStop = true;
            this.rdbErretiratuta.Text = "Erretiratuta";
            this.rdbErretiratuta.UseVisualStyleBackColor = true;
            // 
            // rdbEzezaguna
            // 
            this.rdbEzezaguna.AutoSize = true;
            this.rdbEzezaguna.Location = new System.Drawing.Point(87, 19);
            this.rdbEzezaguna.Name = "rdbEzezaguna";
            this.rdbEzezaguna.Size = new System.Drawing.Size(78, 17);
            this.rdbEzezaguna.TabIndex = 3;
            this.rdbEzezaguna.TabStop = true;
            this.rdbEzezaguna.Text = "Ezezaguna";
            this.rdbEzezaguna.UseVisualStyleBackColor = true;
            // 
            // rdbJardunean
            // 
            this.rdbJardunean.AutoSize = true;
            this.rdbJardunean.Checked = true;
            this.rdbJardunean.Location = new System.Drawing.Point(6, 19);
            this.rdbJardunean.Name = "rdbJardunean";
            this.rdbJardunean.Size = new System.Drawing.Size(75, 17);
            this.rdbJardunean.TabIndex = 0;
            this.rdbJardunean.TabStop = true;
            this.rdbJardunean.Text = "Jardunean";
            this.rdbJardunean.UseVisualStyleBackColor = true;
            // 
            // cbHasieraUrtea
            // 
            this.cbHasieraUrtea.DisplayMember = "s";
            this.cbHasieraUrtea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHasieraUrtea.FormattingEnabled = true;
            this.cbHasieraUrtea.Items.AddRange(new object[] {
            "",
            "Zehaztu gabe",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbHasieraUrtea.Location = new System.Drawing.Point(535, 40);
            this.cbHasieraUrtea.MaxDropDownItems = 5;
            this.cbHasieraUrtea.Name = "cbHasieraUrtea";
            this.cbHasieraUrtea.Size = new System.Drawing.Size(98, 21);
            this.cbHasieraUrtea.TabIndex = 22;
            this.cbHasieraUrtea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHasieraUrtea_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Hasiera";
            // 
            // txtNazionalitateKodea
            // 
            this.txtNazionalitateKodea.Enabled = false;
            this.txtNazionalitateKodea.Location = new System.Drawing.Point(535, 18);
            this.txtNazionalitateKodea.Name = "txtNazionalitateKodea";
            this.txtNazionalitateKodea.Size = new System.Drawing.Size(47, 20);
            this.txtNazionalitateKodea.TabIndex = 20;
            // 
            // pctNazionalitatea
            // 
            this.pctNazionalitatea.BackColor = System.Drawing.Color.Black;
            this.pctNazionalitatea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctNazionalitatea.BackgroundImage")));
            this.pctNazionalitatea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctNazionalitatea.Location = new System.Drawing.Point(823, 18);
            this.pctNazionalitatea.Name = "pctNazionalitatea";
            this.pctNazionalitatea.Size = new System.Drawing.Size(20, 20);
            this.pctNazionalitatea.TabIndex = 19;
            this.pctNazionalitatea.TabStop = false;
            this.pctNazionalitatea.Click += new System.EventHandler(this.pctNazionalitatea_Click);
            // 
            // txtNazionalitateIzena
            // 
            this.txtNazionalitateIzena.Enabled = false;
            this.txtNazionalitateIzena.Location = new System.Drawing.Point(588, 18);
            this.txtNazionalitateIzena.Name = "txtNazionalitateIzena";
            this.txtNazionalitateIzena.Size = new System.Drawing.Size(225, 20);
            this.txtNazionalitateIzena.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nazionalitatea:";
            // 
            // numKideKopurua
            // 
            this.numKideKopurua.Location = new System.Drawing.Point(782, 41);
            this.numKideKopurua.Name = "numKideKopurua";
            this.numKideKopurua.Size = new System.Drawing.Size(61, 20);
            this.numKideKopurua.TabIndex = 16;
            this.numKideKopurua.Tag = "";
            this.numKideKopurua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArtistaMotaKodea
            // 
            this.txtArtistaMotaKodea.Enabled = false;
            this.txtArtistaMotaKodea.Location = new System.Drawing.Point(222, 18);
            this.txtArtistaMotaKodea.Name = "txtArtistaMotaKodea";
            this.txtArtistaMotaKodea.Size = new System.Drawing.Size(47, 20);
            this.txtArtistaMotaKodea.TabIndex = 12;
            // 
            // pctArtistaMota
            // 
            this.pctArtistaMota.BackColor = System.Drawing.Color.Black;
            this.pctArtistaMota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctArtistaMota.BackgroundImage")));
            this.pctArtistaMota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctArtistaMota.Location = new System.Drawing.Point(381, 18);
            this.pctArtistaMota.Name = "pctArtistaMota";
            this.pctArtistaMota.Size = new System.Drawing.Size(20, 20);
            this.pctArtistaMota.TabIndex = 11;
            this.pctArtistaMota.TabStop = false;
            this.pctArtistaMota.Click += new System.EventHandler(this.pctArtistaMota_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(611, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(520, 111);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kide kopurua:";
            // 
            // txtArtistaDeskribapena
            // 
            this.txtArtistaDeskribapena.Location = new System.Drawing.Point(31, 83);
            this.txtArtistaDeskribapena.Multiline = true;
            this.txtArtistaDeskribapena.Name = "txtArtistaDeskribapena";
            this.txtArtistaDeskribapena.Size = new System.Drawing.Size(344, 51);
            this.txtArtistaDeskribapena.TabIndex = 7;
            // 
            // txtArtistaMotaIzena
            // 
            this.txtArtistaMotaIzena.Enabled = false;
            this.txtArtistaMotaIzena.Location = new System.Drawing.Point(275, 18);
            this.txtArtistaMotaIzena.Name = "txtArtistaMotaIzena";
            this.txtArtistaMotaIzena.Size = new System.Drawing.Size(100, 20);
            this.txtArtistaMotaIzena.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Izena:";
            // 
            // txtArtistaIzena
            // 
            this.txtArtistaIzena.Location = new System.Drawing.Point(118, 40);
            this.txtArtistaIzena.Name = "txtArtistaIzena";
            this.txtArtistaIzena.Size = new System.Drawing.Size(257, 20);
            this.txtArtistaIzena.TabIndex = 4;
            // 
            // txtArtistaKodea
            // 
            this.txtArtistaKodea.Enabled = false;
            this.txtArtistaKodea.Location = new System.Drawing.Point(118, 18);
            this.txtArtistaKodea.Name = "txtArtistaKodea";
            this.txtArtistaKodea.Size = new System.Drawing.Size(47, 20);
            this.txtArtistaKodea.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Deskribapena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artista kodea:";
            // 
            // panel_SUPERIOR
            // 
            this.panel_SUPERIOR.Controls.Add(this.p1_Filtros);
            this.panel_SUPERIOR.Controls.Add(this.panel0_SALIR);
            this.panel_SUPERIOR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SUPERIOR.Location = new System.Drawing.Point(0, 0);
            this.panel_SUPERIOR.Name = "panel_SUPERIOR";
            this.panel_SUPERIOR.Size = new System.Drawing.Size(1294, 180);
            this.panel_SUPERIOR.TabIndex = 1;
            // 
            // panel_Izquierdo
            // 
            this.panel_Izquierdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Izquierdo.Controls.Add(this.dgArtistas);
            this.panel_Izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Izquierdo.Location = new System.Drawing.Point(0, 0);
            this.panel_Izquierdo.Name = "panel_Izquierdo";
            this.panel_Izquierdo.Size = new System.Drawing.Size(847, 332);
            this.panel_Izquierdo.TabIndex = 1;
            // 
            // dgArtistas
            // 
            this.dgArtistas.AllowUserToAddRows = false;
            this.dgArtistas.AllowUserToDeleteRows = false;
            this.dgArtistas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtistas.Location = new System.Drawing.Point(0, 0);
            this.dgArtistas.MultiSelect = false;
            this.dgArtistas.Name = "dgArtistas";
            this.dgArtistas.ReadOnly = true;
            this.dgArtistas.Size = new System.Drawing.Size(843, 328);
            this.dgArtistas.TabIndex = 0;
            this.dgArtistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArtistas_CellClick);
            // 
            // panel_GENERAL
            // 
            this.panel_GENERAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_GENERAL.Controls.Add(this.panel1);
            this.panel_GENERAL.Controls.Add(this.panel_Izquierdo);
            this.panel_GENERAL.Controls.Add(this.panel_Inferior);
            this.panel_GENERAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_GENERAL.Location = new System.Drawing.Point(0, 180);
            this.panel_GENERAL.Name = "panel_GENERAL";
            this.panel_GENERAL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_GENERAL.Size = new System.Drawing.Size(1294, 426);
            this.panel_GENERAL.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblAbestiKopurua);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblAlbumKopurua);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(847, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 332);
            this.panel1.TabIndex = 2;
            // 
            // panel_Inferior
            // 
            this.panel_Inferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Inferior.Controls.Add(this.label1);
            this.panel_Inferior.Controls.Add(this.txtKideKopurua);
            this.panel_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Inferior.Location = new System.Drawing.Point(0, 332);
            this.panel_Inferior.MaximumSize = new System.Drawing.Size(1294, 94);
            this.panel_Inferior.MinimumSize = new System.Drawing.Size(1294, 94);
            this.panel_Inferior.Name = "panel_Inferior";
            this.panel_Inferior.Size = new System.Drawing.Size(1294, 94);
            this.panel_Inferior.TabIndex = 0;
            // 
            // txtKideKopurua
            // 
            this.txtKideKopurua.Location = new System.Drawing.Point(702, 61);
            this.txtKideKopurua.Name = "txtKideKopurua";
            this.txtKideKopurua.Size = new System.Drawing.Size(75, 20);
            this.txtKideKopurua.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Artistaren albumak:";
            // 
            // lblAlbumKopurua
            // 
            this.lblAlbumKopurua.AutoSize = true;
            this.lblAlbumKopurua.Location = new System.Drawing.Point(190, 22);
            this.lblAlbumKopurua.Name = "lblAlbumKopurua";
            this.lblAlbumKopurua.Size = new System.Drawing.Size(43, 13);
            this.lblAlbumKopurua.TabIndex = 1;
            this.lblAlbumKopurua.Text = "alb Kop";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Artista honen abestiak:";
            // 
            // lblAbestiKopurua
            // 
            this.lblAbestiKopurua.AutoSize = true;
            this.lblAbestiKopurua.Location = new System.Drawing.Point(190, 51);
            this.lblAbestiKopurua.Name = "lblAbestiKopurua";
            this.lblAbestiKopurua.Size = new System.Drawing.Size(47, 13);
            this.lblAbestiKopurua.TabIndex = 3;
            this.lblAbestiKopurua.Text = "abe Kop";
            // 
            // frmArtistak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1294, 606);
            this.Controls.Add(this.panel_GENERAL);
            this.Controls.Add(this.panel_SUPERIOR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArtistak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artistak - Musika Bilduma";
            this.Load += new System.EventHandler(this.frmArtistak_Load);
            this.panel0_SALIR.ResumeLayout(false);
            this.panel0_SALIR.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.p1_Filtros.ResumeLayout(false);
            this.p1_Filtros.PerformLayout();
            this.gbEgoera.ResumeLayout(false);
            this.gbEgoera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNazionalitatea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKideKopurua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArtistaMota)).EndInit();
            this.panel_SUPERIOR.ResumeLayout(false);
            this.panel_Izquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistas)).EndInit();
            this.panel_GENERAL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Inferior.ResumeLayout(false);
            this.panel_Inferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel0_SALIR;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAtzera;
        private System.Windows.Forms.Panel p1_Filtros;
        private System.Windows.Forms.TextBox txtArtistaDeskribapena;
        private System.Windows.Forms.TextBox txtArtistaMotaIzena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArtistaIzena;
        private System.Windows.Forms.TextBox txtArtistaKodea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_SUPERIOR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Izquierdo;
        private System.Windows.Forms.Panel panel_GENERAL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Inferior;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgArtistas;
        private System.Windows.Forms.PictureBox pctArtistaMota;
        private System.Windows.Forms.TextBox txtArtistaMotaKodea;
        private System.Windows.Forms.TextBox txtKideKopurua;
        private System.Windows.Forms.NumericUpDown numKideKopurua;
        private System.Windows.Forms.TextBox txtNazionalitateIzena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pctNazionalitatea;
        private System.Windows.Forms.TextBox txtNazionalitateKodea;
        private System.Windows.Forms.ComboBox cbHasieraUrtea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbEgoera;
        private System.Windows.Forms.RadioButton rdbGuztiak;
        private System.Windows.Forms.RadioButton rdbErretiratuta;
        private System.Windows.Forms.RadioButton rdbJardunean;
        private System.Windows.Forms.RadioButton rdbEzezaguna;
        private System.Windows.Forms.Label lblAbestiKopurua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAlbumKopurua;
        private System.Windows.Forms.Label label9;
    }
}