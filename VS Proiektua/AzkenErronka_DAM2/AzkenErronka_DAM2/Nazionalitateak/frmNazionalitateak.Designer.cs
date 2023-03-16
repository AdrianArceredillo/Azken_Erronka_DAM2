namespace AzkenErronka_DAM2.Nazionalitateak
{
    partial class frmNazionalitateak
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
            this.txtBilatu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgNazionalitateak = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNazionalitateak)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBilatu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 262);
            this.panel1.TabIndex = 1;
            // 
            // txtBilatu
            // 
            this.txtBilatu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBilatu.Location = new System.Drawing.Point(91, 48);
            this.txtBilatu.Name = "txtBilatu";
            this.txtBilatu.Size = new System.Drawing.Size(157, 20);
            this.txtBilatu.TabIndex = 3;
            this.txtBilatu.TextChanged += new System.EventHandler(this.txtBilatu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Izena:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgNazionalitateak);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 160);
            this.panel2.TabIndex = 1;
            // 
            // dgNazionalitateak
            // 
            this.dgNazionalitateak.AllowUserToAddRows = false;
            this.dgNazionalitateak.AllowUserToDeleteRows = false;
            this.dgNazionalitateak.AllowUserToResizeColumns = false;
            this.dgNazionalitateak.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgNazionalitateak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNazionalitateak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNazionalitateak.Location = new System.Drawing.Point(0, 28);
            this.dgNazionalitateak.Name = "dgNazionalitateak";
            this.dgNazionalitateak.ReadOnly = true;
            this.dgNazionalitateak.ShowEditingIcon = false;
            this.dgNazionalitateak.Size = new System.Drawing.Size(520, 132);
            this.dgNazionalitateak.TabIndex = 1;
            this.dgNazionalitateak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNazionalitateak_CellClick);
            this.dgNazionalitateak.DoubleClick += new System.EventHandler(this.dgNazionalitateak_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 28);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazionalitate-zerrenda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilatu nazionalitate bat:";
            // 
            // frmNazionalitateak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 503);
            this.Controls.Add(this.panel1);
            this.Name = "frmNazionalitateak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nazionalitateak";
            this.Load += new System.EventHandler(this.frmNazionalitateak_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNazionalitateak)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgNazionalitateak;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBilatu;
    }
}