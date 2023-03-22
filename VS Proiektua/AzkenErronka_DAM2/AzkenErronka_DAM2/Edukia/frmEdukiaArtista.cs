using AzkenErronka_DAM2.Abestiak;
using AzkenErronka_DAM2.Artistak;
using AzkenErronka_DAM2.ArtistaMotak;
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
        public clsAbestia clsAbestia = new clsAbestia();

        DataSet dsAlbumak = new DataSet();
        DataSet dsAbestiak = new DataSet();
        DataSet dsAbestiak_Encontradas = new DataSet();
        DataTable dtAlbumak = new DataTable();
        DataTable dtAbestiak = new DataTable();

        public int kodAlb, artistaren_kodea, abestiKopurua, urtea;
        String albumaIzena, artistaren_izena;


        //pasar a frmAbestiaDatuak
        public static int kod_abestia, kod_artista, kod_albuma;
        public static string abestia_izena, abesti_mota;
        public static string zeregina;
        #endregion


        public frmEdukiaArtista()
        {
            InitializeComponent();
        }

        private void frmEdukiaArtista_Load(object sender, EventArgs e)
        {
            artistaren_kodea = frmArtistak.kod_art;
            artistaren_izena = frmArtistak.ize_art;

            artistaren_info_laburra_kargatu();
            llenarDataGrid_albumak();
        }



        public void llenarDataGrid_albumak()
        {
            String parametro = " kodAlb <> -1 and ArtistaKodea = " + Int32.Parse(this.txtEdukia_ArtistaKodea.Text.ToString());

            dsAlbumak = clsAlbuma.getAlbumak(parametro);
            dgAlbumes.DataSource = dsAlbumak.Tables["Albumakk"];

            estilo_datagridview();
        }

        public void llenarDataGrid_abestiak(String parametro)
        {
            //dsAbestiak = clsAbestia.getAbestiak(parametro);
            dsAbestiak = clsAbestia.getAbestiak_Concretas(parametro);
            //dsAbestiak = clsAbestia.getAbestiak_luzea(" and " + parametro);
            dgAbestiak.DataSource = dsAbestiak.Tables["Abestiakk"];

            //contar resultados encontrados
            //this.lblSeleccionadosAbestiak.Text = dsAbestiak.Tables["Abestiakk"].Rows.Count.ToString();



            //dsAbestiak_Encontradas = clsAbestia.getAbestiKopurua_filtratuta(" where KodAbestia <> -1 and " + parametro);

            //if (dsAbestiak_Encontradas.Tables["Abestiak_Filtratuta"].Rows.Count > 0)
            //{
            //    dgAbestiak_Aurkituta.DataSource = dsAbestiak_Encontradas.Tables["Abestiak_Filtratuta"];
            //    this.lblSeleccionadosAbestiak.Text = this.dgAbestiak_Aurkituta.Rows[0].Cells["Kopurua"].Value.ToString();
            //}
            //else
            //{
            //    this.lblSeleccionadosAbestiak.Text = "0";
            //}




            estilo_datagridview_abestiak();
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

        private void estilo_datagridview_abestiak()
        {
            //KodAbestia
            this.dgAbestiak.Columns["KodAbestia"].Visible = true;
            this.dgAbestiak.Columns["KodAbestia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAbestiak.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAbestiak.Columns[0].HeaderText = "Kodea";
            this.dgAbestiak.Columns[0].Width = 50;

            //AbestiaIzena
            this.dgAbestiak.Columns["AbestiaIzena"].Visible = true;
            this.dgAbestiak.Columns["AbestiaIzena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgAbestiak.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAbestiak.Columns[1].HeaderText = "Izena";
            this.dgAbestiak.Columns[1].Width = 250;

            //Artista
            this.dgAbestiak.Columns["Artista"].Visible = true;
            this.dgAbestiak.Columns["Artista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgAbestiak.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAbestiak.Columns[2].HeaderText = "Egilea";
            this.dgAbestiak.Columns[2].Width = 200;

            //Albuma
            this.dgAbestiak.Columns["Albuma"].Visible = true;
            this.dgAbestiak.Columns["Albuma"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgAbestiak.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAbestiak.Columns[3].HeaderText = "Albuma";
            this.dgAbestiak.Columns[3].Width = 150;

            //Albuma
            this.dgAbestiak.Columns["Mota"].Visible = true;
            this.dgAbestiak.Columns["Mota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAbestiak.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgAbestiak.Columns[4].HeaderText = "Mota";
            this.dgAbestiak.Columns[4].Width = 50;



            //this.dgAlbumes.Columns["KodAbestia"].DisplayIndex = 0;
            //this.dgAlbumes.Columns["AbestiaIzena"].DisplayIndex = 1;
            //this.dgAlbumes.Columns["Artista"].DisplayIndex = 2;
            //this.dgAlbumes.Columns["Albuma"].DisplayIndex = 3;
            //this.dgAlbumes.Columns["Mota"].DisplayIndex = 4;
        }


        private void artistaren_info_laburra_kargatu()
        {
            this.txtEdukia_ArtistaKodea.Text = artistaren_kodea.ToString();
            this.txtEdukia_ArtistaIzena.Text = artistaren_izena;
        }


        private void seleccionados_albumes()
        {
            int hautaturikoak = 0;

            for (int i = 0; i < this.dgAlbumes.Rows.Count; i++)
            {
                if (this.dgAlbumes.Rows[i].Selected == true)
                {
                    hautaturikoak = hautaturikoak + 1;
                }
            }

            llenarDataGrid_abestiak(filtro_albumes_seleccionados());
            this.lblSeleccionadosAlbumak.Text = hautaturikoak.ToString();
            this.lblSeleccionadosAbestiak.Text = dsAbestiak.Tables["Abestiakk"].Rows.Count.ToString();
        }


        private String filtro_albumes_seleccionados()
        {
            int hautaturikoak = 0;
            String parametro = "";

            for (int i = 0; i < this.dgAlbumes.Rows.Count; i++)
            {
                if (this.dgAlbumes.Rows[i].Selected == true)
                {
                    if (hautaturikoak == 0)
                    {
                        hautaturikoak = hautaturikoak + 1;
                        parametro = parametro + " where Abestiak.AlbumaKodea = " + Int32.Parse(this.dgAlbumes.Rows[i].Cells["KodAlb"].Value.ToString());
                    }
                    else
                    {
                        hautaturikoak = hautaturikoak + 1;
                        parametro = parametro + " or Abestiak.AlbumaKodea = " + Int32.Parse(this.dgAlbumes.Rows[i].Cells["KodAlb"].Value.ToString());
                    }
                }
            }

            if (parametro == "")
            {
                parametro = parametro + " where Abestiak.Egileakodea = " + Int32.Parse(this.txtEdukia_ArtistaKodea.Text.ToString());

            }
            else
            {
                parametro = parametro + " and Abestiak.Egileakodea = " + Int32.Parse(this.dgAlbumes.Rows[0].Cells["ArtistaKodea"].Value.ToString());
            }



            //this.lblSeleccionadosAlbumak.Text = hautaturikoak.ToString();
            return parametro;
        }



        #region "GERTAERAK"
        private void rdb_Albumak_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb_alb = sender as RadioButton;
            if (rb_alb != null)
            {
                if (rb_alb.Checked)
                {
                    //MessageBox.Show("Albumak ikusi! ", "Eduki-mota");
                    albumak_filtro_egoera_aldatu(true);
                    llenarDataGrid_albumak();
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
                    //MessageBox.Show("Abestiak ikusi! ", "Eduki-mota");
                    albumak_filtro_egoera_aldatu(false);
                    llenarDataGrid_abestiak(" where Abestiak.EgileaKodea = " + Int32.Parse(this.txtEdukia_ArtistaKodea.Text.ToString()));
                    //dsAbestiak = clsAbestia.getAbestiak_Concretas(parametro);


                    if (dsAbestiak.Tables["Abestiakk"].Rows.Count > 0)
                    {
                        this.dgAbestiak.Rows[0].Selected = true;
                        this.dgAbestiak.CurrentCell = this.dgAbestiak.Rows[0].Cells["KodAbestia"];
                        this.lblAbestiakGuztira.Text = dsAbestiak.Tables["Abestiakk"].Rows.Count.ToString();
                    }
                    else
                    {
                        this.lblAbestiakGuztira.Text = "0";
                    }

                }
            }
        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctEdukia_Artista_Click(object sender, EventArgs e)
        {
            this.rdb_Albumak.Checked = true;

            frmArtistaAukeratu _frmArtistaAukeratu = new frmArtistaAukeratu();
            _frmArtistaAukeratu.ShowDialog();

            if (_frmArtistaAukeratu.aukeraturiko_artista_kodea != null)
            {
                this.txtEdukia_ArtistaKodea.Text = _frmArtistaAukeratu.aukeraturiko_artista_kodea.ToString();
                this.txtEdukia_ArtistaIzena.Text = _frmArtistaAukeratu.aukeraturiko_artista_izena.ToString();
            }
        }

        private void txtEdukia_ArtistaKodea_TextChanged(object sender, EventArgs e)
        {
            llenarDataGrid_albumak();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            //refrescar grid de canciones
        }

        private void dgAbestiak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgAbestiak.Rows[index].Selected = true;
            this.dgAbestiak.CurrentCell = this.dgAbestiak.Rows[index].Cells[1];
        }

        private void btn_AbestiBerria_Click(object sender, EventArgs e)
        {
            //abrir ventana (frmAbestiaDatuak) para añadir nueva canción
        }

        private void btn_AbestiaEditatu_Click(object sender, EventArgs e)
        {
            //abrir ventana (frmAbestiaDatuak) para editar canción
            zeregina = "editatu";

            int contador = 0;

            if (dsAbestiak.Tables[0].Rows.Count >= 1)
            {
                for (int i = 0; i < this.dgAbestiak.Rows.Count; i++)
                {
                    if (this.dgAbestiak.Rows[i].Selected == true)
                    {
                        contador = contador + 1;
                    }
                }
            }

            kod_abestia = Int32.Parse(this.dgAbestiak.CurrentRow.Cells["KodAbestia"].Value.ToString());

            frmAbestiaDatuak _frnAbestiaDatuak = new frmAbestiaDatuak();
            _frnAbestiaDatuak.ShowDialog();

        }

        private void btnAbestiaEzabatu_Click(object sender, EventArgs e)
        {
            //eliminar la canción seleccinada
        }

        private void btnGuztiakAukeratu_Click(object sender, EventArgs e)
        {
            if (dsAlbumak.Tables[0].Rows.Count >= 1)
            {
                for (int i = 0; i < this.dgAlbumes.Rows.Count; i++)
                {
                    this.dgAlbumes.Rows[i].Selected = true;
                }

                seleccionados_albumes();
            }
        }

        private void btnDesautatuDenak_Click(object sender, EventArgs e)
        {
            if (dsAlbumak.Tables[0].Rows.Count >= 1)
            {
                for (int i = 0; i < this.dgAlbumes.Rows.Count; i++)
                {
                    this.dgAlbumes.Rows[i].Selected = false;
                }

                llenarDataGrid_abestiak(" where KodAbestia = -1");
                this.lblSeleccionadosAlbumak.Text = "0";
                this.lblSeleccionadosAbestiak.Text = "0";

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


            seleccionados_albumes();
        }

        #endregion




        #region "ELEMENTUEN PROPIETATEAK"
        private void albumak_filtro_egoera_aldatu(bool est)
        {
            //this.panel_album_zerrenda.Enabled = est;
            this.dgAlbumes.Enabled = est;
            this.tlsAlbumak.Enabled = est;
        }

        #endregion



    }
}
