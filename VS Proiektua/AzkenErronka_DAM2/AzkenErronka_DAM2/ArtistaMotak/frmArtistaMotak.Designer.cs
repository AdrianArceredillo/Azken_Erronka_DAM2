namespace AzkenErronka_DAM2.ArtistaMotak
{
    partial class frmArtistaMotak
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgArtistaMota = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeskribapena = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInformazioGehiago = new System.Windows.Forms.Label();
            this.txtDeskribapena = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistaMota)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 232);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgArtistaMota);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 184);
            this.panel2.TabIndex = 1;
            // 
            // dgArtistaMota
            // 
            this.dgArtistaMota.AllowUserToAddRows = false;
            this.dgArtistaMota.AllowUserToDeleteRows = false;
            this.dgArtistaMota.AllowUserToResizeColumns = false;
            this.dgArtistaMota.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgArtistaMota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtistaMota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtistaMota.Location = new System.Drawing.Point(0, 28);
            this.dgArtistaMota.Name = "dgArtistaMota";
            this.dgArtistaMota.ReadOnly = true;
            this.dgArtistaMota.ShowEditingIcon = false;
            this.dgArtistaMota.Size = new System.Drawing.Size(535, 156);
            this.dgArtistaMota.TabIndex = 1;
            this.dgArtistaMota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArtistaMota_CellClick);
            this.dgArtistaMota.DoubleClick += new System.EventHandler(this.dgArtistaMota_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 28);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artista-mota guztien zerrenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aukeratu artista mota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Deskribapena:";
            // 
            // lblDeskribapena
            // 
            this.lblDeskribapena.AutoSize = true;
            this.lblDeskribapena.Location = new System.Drawing.Point(96, 451);
            this.lblDeskribapena.Name = "lblDeskribapena";
            this.lblDeskribapena.Size = new System.Drawing.Size(13, 13);
            this.lblDeskribapena.TabIndex = 2;
            this.lblDeskribapena.Text = "d";
            this.lblDeskribapena.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informazio gehiago:";
            // 
            // lblInformazioGehiago
            // 
            this.lblInformazioGehiago.AutoSize = true;
            this.lblInformazioGehiago.Location = new System.Drawing.Point(96, 398);
            this.lblInformazioGehiago.Name = "lblInformazioGehiago";
            this.lblInformazioGehiago.Size = new System.Drawing.Size(9, 13);
            this.lblInformazioGehiago.TabIndex = 4;
            this.lblInformazioGehiago.Text = "i";
            // 
            // txtDeskribapena
            // 
            this.txtDeskribapena.AcceptsReturn = true;
            this.txtDeskribapena.BackColor = System.Drawing.SystemColors.Control;
            this.txtDeskribapena.Location = new System.Drawing.Point(99, 291);
            this.txtDeskribapena.Multiline = true;
            this.txtDeskribapena.Name = "txtDeskribapena";
            this.txtDeskribapena.ReadOnly = true;
            this.txtDeskribapena.Size = new System.Drawing.Size(347, 63);
            this.txtDeskribapena.TabIndex = 5;
            // 
            // frmArtistaMotak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 503);
            this.Controls.Add(this.txtDeskribapena);
            this.Controls.Add(this.lblInformazioGehiago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDeskribapena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArtistaMotak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artista Motak";
            this.Load += new System.EventHandler(this.frmArtistaMotak_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistaMota)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgArtistaMota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeskribapena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInformazioGehiago;
        private System.Windows.Forms.TextBox txtDeskribapena;
        public System.Windows.Forms.Panel panel2;
    }
}