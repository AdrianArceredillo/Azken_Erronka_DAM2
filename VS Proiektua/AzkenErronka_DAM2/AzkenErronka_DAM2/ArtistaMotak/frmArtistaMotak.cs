using AzkenErronka_DAM2.Artistak;
using AzkenErronka_DAM2.Klaseak;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzkenErronka_DAM2.ArtistaMotak
{
    public partial class frmArtistaMotak : Form
    {

        #region "DECLARACIONES"
        SqlConnection con;
        ArtistaMota clsArtistaMota = new ArtistaMota();
        #endregion

        public frmArtistaMotak()
        {
            InitializeComponent();
        }

        private void frmArtistaMotak_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
            con.Open();


            String parametro = " where KodMota != -1 ";

            SqlDataReader reader = clsArtistaMota.getArtistaMotak(con, parametro);

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgArtistaMota.DataSource = dt;


            //datagridview-aren zutabeak eta itxura aldatu
            datagridView_estiloa_aldatu();




            DataGridViewRow initial_row = dgArtistaMota.Rows[1];
            string deskribapena_value = Convert.ToString(initial_row.Cells["Deskribapena"].Value);
            string infoGehiago_value = Convert.ToString(initial_row.Cells["MotaInfoGehiago"].Value);

            this.lblDeskribapena.Text = deskribapena_value.Trim();
            this.lblInformazioGehiago.Text = infoGehiago_value.Trim();

            dgArtistaMota.Refresh();
            //con.Close();
        }

        private void dgArtistaMota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgArtistaMota.Rows[index].Selected = true;

            DataGridViewRow selectedRow = dgArtistaMota.Rows[index];
            string deskribapena_value = Convert.ToString(selectedRow.Cells["Deskribapena"].Value);
            string infoGehiago_value = Convert.ToString(selectedRow.Cells["MotaInfoGehiago"].Value);

            this.lblDeskribapena.Text = deskribapena_value.Trim();
            this.lblInformazioGehiago.Text = infoGehiago_value.Trim();

        }


        private void datagridView_estiloa_aldatu()
        {
            //KodMota
            this.dgArtistaMota.Columns["KodMota"].Visible = true;
            this.dgArtistaMota.Columns["KodMota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistaMota.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistaMota.Columns[0].HeaderText = "Kodea";
            this.dgArtistaMota.Columns[0].Width = 100;

            //MotaIzena
            this.dgArtistaMota.Columns["MotaIzena"].Visible = true;
            this.dgArtistaMota.Columns["MotaIzena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistaMota.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistaMota.Columns[1].HeaderText = "Motaren Izena";
            this.dgArtistaMota.Columns[1].Width = 375;
            //Deskribapena
            this.dgArtistaMota.Columns["Deskribapena"].Visible = false;
            //MotaInfoGehiago
            this.dgArtistaMota.Columns["MotaInfoGehiago"].Visible = false;
        }



    }
}
