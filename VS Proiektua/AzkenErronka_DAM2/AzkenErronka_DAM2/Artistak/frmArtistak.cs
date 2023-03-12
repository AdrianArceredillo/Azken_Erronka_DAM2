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
using AzkenErronka_DAM2.Nazionalitateak;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AzkenErronka_DAM2.Artistak
{
    public partial class frmArtistak : Form
    {

        #region "DECLARACIONES"
        SqlConnection con;
        Artista clsArtista = new Artista();
        SqlDataReader reader;
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
            String parametro = " where KodArtista != -1 ";

            //artistaren kodea
            if (this.txtArtistaKodea.Text != "")
            {
                parametro = parametro + " and KodArtista = " + Int32.Parse(this.txtArtistaKodea.Text.Trim());
            }

            //artistaren izena
            if (this.txtArtistaIzena.Text != "")
            {
                parametro = parametro + " and IzenaArtista LIKE '%" + this.txtArtistaIzena.Text.Trim() + "%'";
            }

            //artista-mota
            if (this.txtArtistaMotaKodea.Text != "")
            {
                parametro = parametro + " and KodArtistaMota = " + Int32.Parse(this.txtArtistaMotaKodea.Text.Trim()) + "";
            }

            //artista-deskribapena
            if (this.txtArtistaDeskribapena.Text != "")
            {
                parametro = parametro + " and Deskribapena LIKE '%" + this.txtArtistaDeskribapena.Text.Trim() + "%'";
            }


            //kide kopurua
            if (this.numKideKopurua.Value != null)
            {
                if (this.numKideKopurua.Value == 0)
                {
                    parametro = parametro + " and KideKopurua > 0";
                }
                else
                {
                    parametro = parametro + " and KideKopurua = " + this.numKideKopurua.Value + "";
                }
            }

            //hasiera-urtea
            if (this.cbHasieraUrtea.Text != null)
            {
                int cb_urtea = Int32.Parse(this.cbHasieraUrtea.Text.Trim());
                parametro = parametro + " and FundazioUrtea = " + cb_urtea;
            }
            //else if (this.cbHasieraUrtea.SelectedValue != null)
            //{
            //    Int32 urtea_hasiera = Int32.Parse(this.cbHasieraUrtea.SelectedValue.ToString());
            //    parametro = parametro + " and FundazioUrtea = " + urtea_hasiera;
            //}

            //egoera
            if (this.rdbJardunean.Checked == true)
            {
                parametro = parametro + " and Egoera = 'S'";
            }
            else if (this.rdbErretiratuta.Checked == true)
            {
                parametro = parametro + " and Egoera = 'R'";
            }
            else if (this.rdbEzezaguna.Checked == true)
            {
                parametro = parametro + " and Egoera = 'D'";
            }




            parametro = parametro + " order by KodArtista asc";


            //SqlDataReader reader = clsArtista.getArtistak(con, parametro);
            reader = clsArtista.getArtistak(con, parametro);


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

            if (_frmArtistaMotak.aukeraturiko_mota_kodea != null)
            {
                this.txtArtistaMotaKodea.Text = _frmArtistaMotak.aukeraturiko_mota_kodea.ToString();
                this.txtArtistaMotaIzena.Text = _frmArtistaMotak.aukeraturiko_mota_izena.ToString();
            }

        }

        private void btnAtzera_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //reader.Close();
            //reader.Close();

            //this.cbHasieraUrtea.ResetText();
            this.cbHasieraUrtea.Text = "";

            limpiar_contenido_filtros();

            SqlDataReader reader2 = clsArtista.getArtistak(con, " where KodArtista = -90");

            DataTable dt2 = new DataTable();
            dt2.Load(reader2);

            dgArtistas.DataSource = dt2;
            dgArtistas.Refresh();
            //con.Close();

        }

        private void limpiar_contenido_filtros()
        {
            //this.txtArtistaKodea.Text = "";
            //this.txtArtistaIzena.Text = "";
            //this.txtArtistaMotaKodea.Text = "";
            //this.txtArtistaMotaIzena.Text = "";
            //this.txtArtistaDeskribapena.Text = "";
            //this.txtNazionalitateKodea.Text = "";
            //this.txtNazionalitateIzena.Text = "";
            //this.numKideKopurua.Value = 0;

            
            //this.cbHasieraUrtea.Text = "";
            this.rdbGuztiak.Checked = true;
        }

        private void pctNazionalitatea_Click(object sender, EventArgs e)
        {
            frmNazionalitateak _frmNazionalitateak = new frmNazionalitateak();
            _frmNazionalitateak.ShowDialog();

            if (_frmNazionalitateak.nazionalitate_kodea != "-?")
            {
                this.txtNazionalitateKodea.Text = _frmNazionalitateak.nazionalitate_kodea.ToString();
                this.txtNazionalitateIzena.Text = _frmNazionalitateak.nazionalitate_izena.ToString();
            }
        }

        private void cbHasieraUrtea_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.ComboBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }
    }
}



//Guardar datos en dataset: https://www.youtube.com/watch?v=O-D9yuH3Cu4
