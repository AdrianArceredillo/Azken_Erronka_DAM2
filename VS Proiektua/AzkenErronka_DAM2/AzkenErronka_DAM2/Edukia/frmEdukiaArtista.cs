using AzkenErronka_DAM2.Artistak;
using clsKlasea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AzkenErronka_DAM2.Edukia
{
    public partial class frmEdukiaArtista : Form
    {

        #region "DECLARACIONES"
        public clsAlbuma clsAlbuma = new clsAlbuma();
        DataSet dsAlbumak = new DataSet();
        DataTable dtAlbumak = new DataTable();

        public int kodAlb, artistaren_kodea, abestiKopurua, urtea;
        String albumaIzena, artistaren_izena;
        #endregion


        public frmEdukiaArtista()
        {   
            InitializeComponent();
        }

        private void frmEdukiaArtista_Load(object sender, EventArgs e)
        {
            //artistaKodea = clsAlbuma.artistaKodea;
            artistaren_kodea = frmArtistak.kod_art;
            artistaren_izena = frmArtistak.ize_art;

            artistaren_info_laburra_kargatu();
            llenarDataGrid();
        }



        public void llenarDataGrid()
        {
            String parametro = " kodAlb <> -1 and ArtistaKodea = " + artistaren_kodea;

            dsAlbumak = clsAlbuma.getAlbumak(parametro);
            //dsAlbumak = clsAlbuma.getAlbumak_test("0");

            dgAlbumes.DataSource = dsAlbumak.Tables["Albumakk"];
            estilo_datagridview();
        }

        private void estilo_datagridview()
        {
            //KodAlb
            this.dgAlbumes.Columns["KodAlb"].Visible = false;
            this.dgAlbumes.Columns["KodAlb"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[0].HeaderText = "Kodea";
            this.dgAlbumes.Columns[0].Width = 0;

            //AlbumaIzena
            this.dgAlbumes.Columns["AlbumaIzena"].Visible = true;
            this.dgAlbumes.Columns["AlbumaIzena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgAlbumes.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[1].HeaderText = "Izena";
            this.dgAlbumes.Columns[1].Width = 200;

            //ArtistaKodea
            this.dgAlbumes.Columns["ArtistaKodea"].Visible = false;
            this.dgAlbumes.Columns["ArtistaKodea"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgAlbumes.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[2].HeaderText = "ArtistaKodea";
            this.dgAlbumes.Columns[2].Width = 50;

            //AbestiKopurua
            this.dgAlbumes.Columns["AbestiKopurua"].Visible = true;
            this.dgAlbumes.Columns["AbestiKopurua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[3].HeaderText = "Abestiak";
            this.dgAlbumes.Columns[3].Width = 80;

            //Urtea
            this.dgAlbumes.Columns["Urtea"].Visible = true;
            this.dgAlbumes.Columns["Urtea"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAlbumes.Columns[4].HeaderText = "Urtea";
            this.dgAlbumes.Columns[4].Width = 50;

            
            //orden visible de las columnas
            this.dgAlbumes.Columns["KodAlb"].Visible = false;
            this.dgAlbumes.Columns["ArtistaKodea"].Visible = false;
            this.dgAlbumes.Columns["AlbumaIzena"].DisplayIndex = 0;
            this.dgAlbumes.Columns["AbestiKopurua"].DisplayIndex = 1;
            this.dgAlbumes.Columns["Urtea"].DisplayIndex = 2;
        }

        private void artistaren_info_laburra_kargatu()
        {
            this.txtEdukia_ArtistaKodea.Text = artistaren_kodea.ToString();
            this.txtEdukia_ArtistaIzena.Text = artistaren_izena;
        }



        #region "GERTAERAK"
        private void rdb_Albumak_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb_alb = sender as RadioButton;
            if (rb_alb != null)
            {
                if (rb_alb.Checked)
                {
                    MessageBox.Show("Albumak ikusi! ", "Eduki-mota");
                    albumak_filtro_egoera_aldatu(true);
                }
            }
        }

        private void rdb_AbestiGuztiak_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb_abe = sender as RadioButton;
            if (rb_abe != null)
            {
                if (rb_abe.Checked)
                {
                    MessageBox.Show("Abestiak ikusi! ", "Eduki-mota");
                    albumak_filtro_egoera_aldatu(false);
                }
            }
        }
                
        private void btnAtzera_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuztiakAukeratu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgAlbumes.Rows.Count; i++)
            {
                this.dgAlbumes.Rows[i].Selected = true;
            }
        }

        private void btnDesautatuDenak_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgAlbumes.Rows.Count; i++)
            {
                this.dgAlbumes.Rows[i].Selected = false;
            }
        }

        private void dgAlbumes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            this.dgAlbumes.Rows[index].Selected = true;
            this.dgAlbumes.CurrentCell = this.dgAlbumes.Rows[index].Cells[1];
        }


        #endregion



        #region "ELEMENTUEN PROPIETATEAK"
        private void albumak_filtro_egoera_aldatu(bool est)
        {
            this.panel_album_zerrenda.Enabled = est;
            this.dgAlbumes.Enabled = est;
            this.tlsAlbumak.Enabled = est;
        }

        #endregion



    }
}
