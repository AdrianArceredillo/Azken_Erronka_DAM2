namespace AzkenErronka_DAM2.Artistak
{
    partial class frmArtistaAukeratu
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
            this.dgArtistak = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBilatu_Artista = new System.Windows.Forms.TextBox();
            this.txtHasieraUrtea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotaIzena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeskribapena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazionalitateaIzena = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistak)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBilatu_Artista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 213);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgArtistak);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 141);
            this.panel2.TabIndex = 1;
            // 
            // dgArtistak
            // 
            this.dgArtistak.AllowUserToAddRows = false;
            this.dgArtistak.AllowUserToDeleteRows = false;
            this.dgArtistak.AllowUserToResizeColumns = false;
            this.dgArtistak.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgArtistak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtistak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgArtistak.Location = new System.Drawing.Point(0, 28);
            this.dgArtistak.Name = "dgArtistak";
            this.dgArtistak.ReadOnly = true;
            this.dgArtistak.ShowEditingIcon = false;
            this.dgArtistak.Size = new System.Drawing.Size(535, 113);
            this.dgArtistak.TabIndex = 1;
            this.dgArtistak.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgArtistaMota_CellContentDoubleClick);
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
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artista guztien zerrenda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilatu:";
            // 
            // txtBilatu_Artista
            // 
            this.txtBilatu_Artista.Location = new System.Drawing.Point(89, 32);
            this.txtBilatu_Artista.Name = "txtBilatu_Artista";
            this.txtBilatu_Artista.Size = new System.Drawing.Size(249, 20);
            this.txtBilatu_Artista.TabIndex = 14;
            // 
            // txtHasieraUrtea
            // 
            this.txtHasieraUrtea.Location = new System.Drawing.Point(50, 329);
            this.txtHasieraUrtea.Name = "txtHasieraUrtea";
            this.txtHasieraUrtea.Size = new System.Drawing.Size(94, 20);
            this.txtHasieraUrtea.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hasiera-urtea:";
            // 
            // txtMotaIzena
            // 
            this.txtMotaIzena.Location = new System.Drawing.Point(50, 251);
            this.txtMotaIzena.Name = "txtMotaIzena";
            this.txtMotaIzena.Size = new System.Drawing.Size(173, 20);
            this.txtMotaIzena.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mota:";
            // 
            // txtDeskribapena
            // 
            this.txtDeskribapena.AcceptsReturn = true;
            this.txtDeskribapena.BackColor = System.Drawing.SystemColors.Control;
            this.txtDeskribapena.Location = new System.Drawing.Point(50, 407);
            this.txtDeskribapena.Multiline = true;
            this.txtDeskribapena.Name = "txtDeskribapena";
            this.txtDeskribapena.ReadOnly = true;
            this.txtDeskribapena.Size = new System.Drawing.Size(347, 63);
            this.txtDeskribapena.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Deskribapena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nazionalitatea:";
            // 
            // txtNazionalitateaIzena
            // 
            this.txtNazionalitateaIzena.Location = new System.Drawing.Point(50, 290);
            this.txtNazionalitateaIzena.Name = "txtNazionalitateaIzena";
            this.txtNazionalitateaIzena.Size = new System.Drawing.Size(173, 20);
            this.txtNazionalitateaIzena.TabIndex = 20;
            // 
            // frmArtistaAukeratu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 503);
            this.Controls.Add(this.txtNazionalitateaIzena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHasieraUrtea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMotaIzena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDeskribapena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArtistaAukeratu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artisten Zerrenda";
            this.Load += new System.EventHandler(this.frmArtistaAukeratu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtistak)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgArtistak;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasieraUrtea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMotaIzena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBilatu_Artista;
        private System.Windows.Forms.TextBox txtDeskribapena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazionalitateaIzena;
    }
}