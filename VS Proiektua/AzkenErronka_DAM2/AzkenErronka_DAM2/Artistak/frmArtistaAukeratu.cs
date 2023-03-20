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
            //KodMota
            this.dgArtistak.Columns["KodArtista"].Visible = true;
            this.dgArtistak.Columns["KodArtista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistak.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistak.Columns[0].HeaderText = "Kodea";
            this.dgArtistak.Columns[0].Width = 100;

            //MotaIzena
            this.dgArtistak.Columns["IzenaArtista"].Visible = true;
            this.dgArtistak.Columns["IzenaArtista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistak.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistak.Columns[1].HeaderText = "Izena";
            this.dgArtistak.Columns[1].Width = 375;

        }

        private void dgArtistaMota_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
