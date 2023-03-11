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

using AzkenErronka_DAM2.Artistak;
using AzkenErronka_DAM2.ArtistaMotak;
using AzkenErronka_DAM2.Klaseak;

namespace AzkenErronka_DAM2.Artistak
{
    public partial class frmArtistak : Form
    {

        #region "DECLARACIONES"
        SqlConnection con;
        Artista clsArtista = new Artista();
        #endregion

        public frmArtistak()
        {
            InitializeComponent();
        }

        private void frmArtistak_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
            con.Open();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //String sql = "select * from Erabiltzaileak";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //SqlDataReader reader = cmd.ExecuteReader();

            String parametro = " where KodArtista != -1 ";

            if (this.txtArtistaKodea.Text != "")
            {
                parametro = parametro + " and KodArtista = " + Int32.Parse(this.txtArtistaKodea.Text.Trim());
            }

            if (this.txtArtistaIzena.Text != "")
            {
                parametro = parametro + " and IzenaArtista = '" + this.txtArtistaIzena.Text.Trim() + "'";
            }

            parametro = parametro + " order by KodArtista asc";

            

            SqlDataReader reader = clsArtista.getArtistak(con, parametro);

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgArtistas.DataSource = dt;
            dgArtistas.Refresh();
            //con.Close();
        }

        private void dgArtistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgArtistas.Rows[index].Selected = true;
        }

        private void pctArtistaMota_Click(object sender, EventArgs e)
        {
            frmArtistaMotak _frmArtistaMotak = new frmArtistaMotak();
            _frmArtistaMotak.ShowDialog();
        }
    }
}



//Guardar datos en dataset: https://www.youtube.com/watch?v=O-D9yuH3Cu4
