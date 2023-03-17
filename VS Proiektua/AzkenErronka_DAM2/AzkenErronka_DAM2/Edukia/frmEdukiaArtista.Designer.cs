namespace AzkenErronka_DAM2.Edukia
{
    partial class frmEdukiaArtista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdukia_ArtistaKodea = new System.Windows.Forms.TextBox();
            this.txtEdukia_ArtistaIzena = new System.Windows.Forms.TextBox();
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artistaren izena:";
            // 
            // txtEdukia_ArtistaKodea
            // 
            this.txtEdukia_ArtistaKodea.Location = new System.Drawing.Point(49, 46);
            this.txtEdukia_ArtistaKodea.Name = "txtEdukia_ArtistaKodea";
            this.txtEdukia_ArtistaKodea.Size = new System.Drawing.Size(62, 20);
            this.txtEdukia_ArtistaKodea.TabIndex = 2;
            // 
            // txtEdukia_ArtistaIzena
            // 
            this.txtEdukia_ArtistaIzena.Location = new System.Drawing.Point(135, 46);
            this.txtEdukia_ArtistaIzena.Name = "txtEdukia_ArtistaIzena";
            this.txtEdukia_ArtistaIzena.Size = new System.Drawing.Size(215, 20);
            this.txtEdukia_ArtistaIzena.TabIndex = 3;
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(49, 103);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.Size = new System.Drawing.Size(573, 130);
            this.dgAlbumes.TabIndex = 4;
            // 
            // frmEdukiaArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgAlbumes);
            this.Controls.Add(this.txtEdukia_ArtistaIzena);
            this.Controls.Add(this.txtEdukia_ArtistaKodea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEdukiaArtista";
            this.Text = "Artistaren Edukia";
            this.Load += new System.EventHandler(this.frmEdukiaArtista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdukia_ArtistaKodea;
        private System.Windows.Forms.TextBox txtEdukia_ArtistaIzena;
        private System.Windows.Forms.DataGridView dgAlbumes;
    }
}