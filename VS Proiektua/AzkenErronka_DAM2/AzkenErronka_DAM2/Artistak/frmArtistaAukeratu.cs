using AzkenErronka_DAM2.Klaseak;
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

namespace AzkenErronka_DAM2.Artistak
{
    public partial class frmArtistaAukeratu : Form
    {

        #region "DECLARACIONES"
        SqlConnection con;
        Artista clsArtista = new Artista();

        public Int32 aukeraturiko_artista_kodea = 0;
        public String aukeraturiko_artista_izena = "";

        frmArtistak owner_form = null;
        #endregion

        public frmArtistaAukeratu()
        {
            InitializeComponent();
            this.owner_form = owner_form;
        }

        private void frmArtistaAukeratu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
            con.Open();

            String parametro = " and KodArtista != -1 ";
            SqlDataReader reader = clsArtista.getArtistak_grid_artistak(con, parametro);

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgArtistak.DataSource = dt;

            //datagridview-aren zutabeak eta itxura aldatu
            datagridView_estiloa_aldatu();

            DataGridViewRow initial_row = dgArtistak.Rows[1];
            dgArtistak.Refresh();
        }



        private void datagridView_estiloa_aldatu()
        {
            //KodArtista
            this.dgArtistak.Columns["KodArtista"].Visible = true;
            this.dgArtistak.Columns["KodArtista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistak.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistak.Columns[0].HeaderText = "Koadea";
            this.dgArtistak.Columns[0].Width = 100;

            //IzenaArtista
            this.dgArtistak.Columns["IzenaArtista"].Visible = true;
            this.dgArtistak.Columns["IzenaArtista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistak.Columns[1].HeaderText = "Izena";
            this.dgArtistak.Columns[1].Width = 300;

            //Deskribapena
            this.dgArtistak.Columns["Deskribapena"].Visible = false;
            this.dgArtistak.Columns["Deskribapena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[2].HeaderText = "Deskribapena";
            this.dgArtistak.Columns[2].HeaderText = "";
            this.dgArtistak.Columns[2].Width = 0;

            //IdNazioa
            this.dgArtistak.Columns["IdNazioa"].Visible = false;
            this.dgArtistak.Columns["IdNazioa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[3].HeaderText = "IdNazioa";
            this.dgArtistak.Columns[3].HeaderText = "";
            this.dgArtistak.Columns[3].Width = 0;

            //Mota
            this.dgArtistak.Columns["Mota"].Visible = false;
            this.dgArtistak.Columns["Mota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[4].HeaderText = "Mota";
            this.dgArtistak.Columns[4].HeaderText = "";
            this.dgArtistak.Columns[4].Width = 0;

            //KideKopurua
            this.dgArtistak.Columns["KideKopurua"].Visible = false;
            this.dgArtistak.Columns["KideKopurua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[5].HeaderText = "Kide-Kopurua";
            this.dgArtistak.Columns[5].HeaderText = "";
            this.dgArtistak.Columns[5].Width = 0;

            //FundazioUrtea
            this.dgArtistak.Columns["FundazioUrtea"].Visible = false;
            this.dgArtistak.Columns["FundazioUrtea"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[6].HeaderText = "Urtea";
            this.dgArtistak.Columns[6].HeaderText = "";
            this.dgArtistak.Columns[6].Width = 0;

            //EgoeraDeskribapena
            this.dgArtistak.Columns["EgoeraDeskribapena"].Visible = false;
            this.dgArtistak.Columns["EgoeraDeskribapena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[7].HeaderText = "Egoera";
            this.dgArtistak.Columns[7].HeaderText = "";
            this.dgArtistak.Columns[7].Width = 0;

            //KodArtistaMota
            this.dgArtistak.Columns["KodArtistaMota"].Visible = false;
            this.dgArtistak.Columns["KodArtistaMota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[8].HeaderText = "KodArtistaMota";
            this.dgArtistak.Columns[8].HeaderText = "";
            this.dgArtistak.Columns[8].Width = 0;

            //NazioaIzena
            this.dgArtistak.Columns["NazioaIzena"].Visible = false;
            this.dgArtistak.Columns["NazioaIzena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistak.Columns[9].HeaderText = "Nazioa Izena";
            this.dgArtistak.Columns[9].HeaderText = "";
            this.dgArtistak.Columns[9].Width = 0;
        }

        private void dgArtistaMota_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgArtistak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgArtistak.Rows[index].Selected = true;
            this.dgArtistak.CurrentCell = this.dgArtistak.Rows[index].Cells[1];


            cargar_artista();

            //dgvName.Rows(yourRowIndex).Cells(yourColumnIndex).Value
        }

        private void cargar_artista()
        {
            if (this.dgArtistak.Rows.Count != 0)
            {
                //txtMotaIzena
                this.txtMotaIzena.Text = this.dgArtistak.Rows[this.dgArtistak.CurrentRow.Index].Cells["Mota"].Value.ToString();
                this.txtNazionalitateaIzena.Text = this.dgArtistak.Rows[this.dgArtistak.CurrentRow.Index].Cells["NazioaIzena"].Value.ToString();
                this.txtHasieraUrtea.Text = this.dgArtistak.Rows[this.dgArtistak.CurrentRow.Index].Cells["FundazioUrtea"].Value.ToString();

                this.txtDeskribapena.Text = this.dgArtistak.Rows[this.dgArtistak.CurrentRow.Index].Cells["Deskribapena"].Value.ToString();
            }
        }

        private void dgArtistak_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgArtistak.CurrentRow.Index;
            DataGridViewRow selectedRow = dgArtistak.Rows[index];

            string artista_izena_str = Convert.ToString(selectedRow.Cells["IzenaArtista"].Value);
            string artista_kod_str = Convert.ToString(selectedRow.Cells["KodArtista"].Value);
            int kod_artista = Int32.Parse(artista_kod_str);

            aukeraturiko_artista_kodea = kod_artista;
            aukeraturiko_artista_izena = artista_izena_str;

            this.Close();
        }
    }
}
