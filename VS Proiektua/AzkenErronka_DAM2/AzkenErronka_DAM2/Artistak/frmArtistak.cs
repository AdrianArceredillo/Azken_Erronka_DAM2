using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
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
        ArtistaMota clsArtistaMota = new ArtistaMota();
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
            //String parametro = " and KodArtista != -1 ";

            ////artistaren kodea
            //if (this.txtArtistaKodea.Text != "")
            //{
            //    parametro = parametro + " and KodArtista = " + Int32.Parse(this.txtArtistaKodea.Text.Trim());
            //}

            ////artistaren izena
            //if (this.txtArtistaIzena.Text != "")
            //{
            //    parametro = parametro + " and IzenaArtista LIKE '%" + this.txtArtistaIzena.Text.Trim() + "%'";
            //}

            ////artista-mota
            //if (this.txtArtistaMotaKodea.Text != "")
            //{
            //    parametro = parametro + " and Artista.KodArtistaMota = " + Int32.Parse(this.txtArtistaMotaKodea.Text.Trim()) + "";
            //}

            ////artista-deskribapena
            //if (this.txtArtistaDeskribapena.Text != "")
            //{
            //    parametro = parametro + " and Artista.Deskribapena LIKE '%" + this.txtArtistaDeskribapena.Text.Trim() + "%'";
            //}

            ////nazionalitatea
            //if (this.txtNazionalitateKodea.Text != "")
            //{
            //    parametro = parametro + " and Nazionalitatea LIKE '%" + this.txtNazionalitateIzena.Text.Trim() + "%'";
            //}

            ////kide kopurua
            //if (this.numKideKopurua.Value != null)
            //{
            //    if (this.numKideKopurua.Value == 0)
            //    {
            //        parametro = parametro + " and KideKopurua > 0";
            //    }
            //    else
            //    {
            //        parametro = parametro + " and KideKopurua = " + this.numKideKopurua.Value + "";
            //    }
            //}


            ////hasiera-urtea
            //if (this.cbHasieraUrtea.SelectedItem != null)
            //{
            //    if (this.cbHasieraUrtea.SelectedItem == "Zehaztu gabe" || this.cbHasieraUrtea.SelectedItem == "")
            //    {
            //        parametro = parametro + " and FundazioUrtea > 0";
            //    }
            //    else
            //    {
            //        int cb_urtea = Int32.Parse(this.cbHasieraUrtea.SelectedItem.ToString());
            //        parametro = parametro + " and FundazioUrtea = " + cb_urtea;
            //    }
            //}


            ////egoera
            //if (this.rdbJardunean.Checked == true)
            //{
            //    parametro = parametro + " and Egoera = 'S'";
            //}
            //else if (this.rdbErretiratuta.Checked == true)
            //{
            //    parametro = parametro + " and Egoera = 'R'";
            //}
            //else if (this.rdbAtsedenaldia.Checked == true)
            //{
            //    parametro = parametro + " and Egoera = 'D'";
            //}

            //parametro = parametro + " order by KodArtista asc";




            String param = comprobar_parametros();
            freskatu_artisten_datuak(con, param);

            
        }


        private String comprobar_parametros()
        {
            String parametro = " and KodArtista != -1 ";

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
                parametro = parametro + " and Artista.KodArtistaMota = " + Int32.Parse(this.txtArtistaMotaKodea.Text.Trim()) + "";
            }

            //artista-deskribapena
            if (this.txtArtistaDeskribapena.Text != "")
            {
                parametro = parametro + " and Artista.Deskribapena LIKE '%" + this.txtArtistaDeskribapena.Text.Trim() + "%'";
            }

            //nazionalitatea
            if (this.txtNazionalitateKodea.Text != "")
            {
                parametro = parametro + " and Nazionalitatea LIKE '%" + this.txtNazionalitateIzena.Text.Trim() + "%'";
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
            if (this.cbHasieraUrtea.SelectedItem != null)
            {
                if (this.cbHasieraUrtea.SelectedItem == "Zehaztu gabe" || this.cbHasieraUrtea.SelectedItem == "")
                {
                    parametro = parametro + " and FundazioUrtea > 0";
                }
                else
                {
                    int cb_urtea = Int32.Parse(this.cbHasieraUrtea.SelectedItem.ToString());
                    parametro = parametro + " and FundazioUrtea = " + cb_urtea;
                }
            }


            //egoera
            if (this.rdbJardunean.Checked == true)
            {
                parametro = parametro + " and Egoera = 'S'";
            }
            else if (this.rdbErretiratuta.Checked == true)
            {
                parametro = parametro + " and Egoera = 'R'";
            }
            else if (this.rdbAtsedenaldia.Checked == true)
            {
                parametro = parametro + " and Egoera = 'D'";
            }

            parametro = parametro + " order by KodArtista asc";


            return parametro;
        }

        private void freskatu_artisten_datuak(SqlConnection con, String parametro)
        {
            reader = clsArtista.getArtistak_grid_artistak(con, parametro);

            DataTable dt = new DataTable();
            dt.Load(reader);
            dgArtistas.DataSource = dt;

            itxura_aldatu();
            //dgArtistas.Refresh();


            //lehenengoa_aukeratu();//lehenengo datua hautatu
        }


        private void itxura_aldatu()
        {
            //KodArtista
            this.dgArtistas.Columns["KodArtista"].Visible = false;
            this.dgArtistas.Columns["KodArtista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[0].HeaderText = "Kodea";
            this.dgArtistas.Columns[0].Width = 0;

            //IzenaArtista
            this.dgArtistas.Columns["IzenaArtista"].Visible = true;
            this.dgArtistas.Columns["IzenaArtista"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistas.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[1].HeaderText = "Izena";
            this.dgArtistas.Columns[1].Width = 200;


            String sql = "select " +
                "KodArtista, " +
                "IzenaArtista, " +
                "Artista.Deskribapena," +
                "Nazionalitateak.IdNazioa, " +

                "ArtistaMota.MotaIzena as Mota, " +
                "KideKopurua, " +
                "FundazioUrtea, " +
                "ArtistaEgoera.EgoeraDeskribapena as Egoera, "


                //"ArtistaInfoGehiago, " +
                //"Adina " +
                ;



            //deskribapena
            this.dgArtistas.Columns["Deskribapena"].Visible = true;
            this.dgArtistas.Columns["Deskribapena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[2].HeaderText = "Deskribapena";
            this.dgArtistas.Columns[2].Width = 260;


            //nazionalitatea
            this.dgArtistas.Columns["IdNazioa"].Visible = true;
            this.dgArtistas.Columns["IdNazioa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[3].HeaderText = "Nazionalitatea";
            this.dgArtistas.Columns[3].Width = 80;

            //artista-motaren izena
            this.dgArtistas.Columns["Mota"].Visible = true;
            this.dgArtistas.Columns["Mota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgArtistas.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[4].HeaderText = "Mota";
            this.dgArtistas.Columns[4].Width = 90;


            //kide-kopurua
            this.dgArtistas.Columns["KideKopurua"].Visible = true;
            this.dgArtistas.Columns["KideKopurua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[5].HeaderText = "Kideak";
            this.dgArtistas.Columns[5].Width = 40;


            //sortze-data
            this.dgArtistas.Columns["FundazioUrtea"].Visible = true;
            this.dgArtistas.Columns["FundazioUrtea"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[6].HeaderText = "Urtea";
            this.dgArtistas.Columns[6].Width = 40;


            //egoera
            this.dgArtistas.Columns["EgoeraDeskribapena"].Visible = true;
            this.dgArtistas.Columns["EgoeraDeskribapena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[7].HeaderText = "Egoera";
            this.dgArtistas.Columns[7].Width = 90;


            //KodArtistaMota
            this.dgArtistas.Columns["KodArtistaMota"].Visible = false;
            this.dgArtistas.Columns["KodArtistaMota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[8].HeaderText = "Mota Kodea";
            this.dgArtistas.Columns[8].Width = 0;


            //NazioaIzena
            this.dgArtistas.Columns["NazioaIzena"].Visible = false;
            this.dgArtistas.Columns["NazioaIzena"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgArtistas.Columns[8].HeaderText = "Nazioa";
            this.dgArtistas.Columns[8].Width = 0;


            //UUUU


            ////kide-kopurua
            //this.dgArtistas.Columns["KideKopurua"].Visible = true;
            //this.dgArtistas.Columns["KideKopurua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistas.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistas.Columns[4].HeaderText = "Kideak";
            //this.dgArtistas.Columns[4].Width = 70;


            ////sortze-data
            //this.dgArtistas.Columns["FundazioUrtea"].Visible = true;
            //this.dgArtistas.Columns["FundazioUrtea"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistas.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //this.dgArtistas.Columns[5].HeaderText = "Sortze-Data";
            //this.dgArtistas.Columns[5].Width = 80;

        }

        private void dgArtistas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgArtistas.Rows[index].Selected = true;


            cargar_artista();

            //dgvName.Rows(yourRowIndex).Cells(yourColumnIndex).Value

        }

        private void cargar_artista()
        {
            if (this.dgArtistas.Rows.Count != 0)
            {
                //FundazioUrtea
                this.txtEdicionKodea.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["KodArtista"].Value.ToString();
                this.txtEdicionIzena.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["IzenaArtista"].Value.ToString();
                this.numEdicionKideak.Value = Int32.Parse(this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["KideKopurua"].Value.ToString());
                this.txtEdicionFundazioUrtea.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["FundazioUrtea"].Value.ToString();


                String egoera_cargar = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["EgoeraDeskribapena"].Value.ToString();
                if (egoera_cargar == "Jardueran")
                {
                    this.rdbEdicionJardueran.Checked = true;
                }
                else if (egoera_cargar == "Erretiratua")
                {
                    this.rdbEdicionErretiratuta.Checked = true;
                }
                else if (egoera_cargar == "Atsedenaldian")
                {
                    this.rdbEdicionAtsedenaldia.Checked = true;
                }

                //artista-mota
                this.txtEdicionArtistaMotaKodea.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["KodArtistaMota"].Value.ToString();
                this.txtEdicionArtistaMotaDesk.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["Mota"].Value.ToString();

                //nazionalitatea
                this.txtEdicionNazionalitateaKodea.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["IdNazioa"].Value.ToString();
                this.txtEdicionNazionalitateaDesk.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["NazioaIzena"].Value.ToString();

                //deskribapena
                this.txtEdicionDeskribapena.Text = this.dgArtistas.Rows[this.dgArtistas.CurrentRow.Index].Cells["Deskribapena"].Value.ToString();
            }



            

        }


        private void lehenengoa_aukeratu()
        {
            if (dgArtistas.Rows.Count != 0)
            {
                dgArtistas.Rows[0].Selected = true;
            }
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
            //this.cbHasieraUrtea.Select = 15;

            ////FindStringExact



            this.cbHasieraUrtea.SelectedItem = "";

            limpiar_contenido_filtros();

            //SqlDataReader reader2 = clsArtista.getArtistak_completo(con, " where KodArtista = -90");
            SqlDataReader reader2 = clsArtista.getArtistak_grid_artistak(con, " and KodArtista = -90");

            DataTable dt2 = new DataTable();
            dt2.Load(reader2);

            dgArtistas.DataSource = dt2;
            dgArtistas.Refresh();
            //con.Close();

        }

        private void limpiar_contenido_filtros()
        {
            this.txtArtistaKodea.Text = "";
            this.txtArtistaIzena.Text = "";
            this.txtArtistaMotaKodea.Text = "";
            this.txtArtistaMotaIzena.Text = "";
            this.txtArtistaDeskribapena.Text = "";
            this.txtNazionalitateKodea.Text = "";
            this.txtNazionalitateIzena.Text = "";
            this.numKideKopurua.Value = 0;

            this.cbHasieraUrtea.SelectedItem = "";
            //this.cbHasieraUrtea.SelectedIndex = cbHasieraUrtea.FindStringExact("Zehaztu gabe");

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

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            //con.Close();
            //con.Open();

            //int ultimo_artista = clsArtista.getArtistak_MaxCode(con, "");

            clsArtista.getArtistak_MaxCode(con, "");
            this.txtEdicionKodea.Text = Artista.prueba_enviar.ToString();



            //this.txtKodeaEdicion.Text = ultimo_artista.ToString();
        }

        private void btnOnartu_Click(object sender, EventArgs e)
        {
            Int32 kodea = 0;
            String izena = "";
            Int32 kod_mota = 0;
            String nazionalitatea = "";
            String deskribapena = "";
            Int32 kide_kopurua = 0;
            Int32 fundazio_urtea = 0;
            String egoera = "";
            String artista_info_gehiago = "";

            //+++++++++++++
            kodea = Int32.Parse(this.txtEdicionKodea.Text);


            if (this.txtEdicionIzena.Text != "")
            {
                izena = this.txtEdicionIzena.Text;
            }
            else
            {
                MessageBox.Show("Artistaren izena beharrezkoa da.", "Kontuz!");
                return;
            }

            //artista-mota
            if (this.txtEdicionArtistaMotaKodea.Text != "")
            {
                kod_mota = Int32.Parse(this.txtEdicionArtistaMotaKodea.Text);
            }
            else
            {
                MessageBox.Show("Ez da artista-mota zehaztu.", "Kontuz!");
                return;
            }

            //nazionalitatea
            if (this.txtEdicionNazionalitateaKodea.Text != "")
            {
                nazionalitatea = this.txtEdicionNazionalitateaKodea.Text.ToString().Trim();
            }
            else
            {
                MessageBox.Show("Artistaren nazionalitatea zehaztu behar da", "Kontuz!");
                return;
            }

            //deskribapena
            if (this.txtEdicionDeskribapena.Text != "")
            {
                deskribapena = this.txtEdicionDeskribapena.Text.Trim();
            }
            else
            {
                deskribapena = "";
            }

            //kide-kopurua
            if (this.numEdicionKideak.Value != null)
            {
                if (this.numEdicionKideak.Value == 0)
                {
                    MessageBox.Show("Artista-kopurua ezin da 0 izan. Gutxienez 1 izan behar du", "Kontuz!");
                    return;
                }
                else
                {
                    kide_kopurua = Int32.Parse(this.numEdicionKideak.Value.ToString());
                }
            }

            //fundazio-urtea
            if (this.txtEdicionFundazioUrtea.Text != "")
            {
                fundazio_urtea = Int32.Parse(this.txtEdicionFundazioUrtea.Text.Trim());
            }
            else
            {
                MessageBox.Show("Artistaren hasiera-urtea zehaztu behar duzu", "Kontuz!");
                return;
            }

            //egoera
            if (this.rdbEdicionJardueran.Checked == true)
            {
                egoera = "S";
            }
            else if (this.rdbEdicionErretiratuta.Checked == true)
            {
                egoera = "R";
            }
            else if (this.rdbEdicionAtsedenaldia.Checked == true)
            {
                egoera = "A";
            }



            String param = comprobar_parametros();


            //+++++++++++++

            //int kodartista, String izenaArtista, int kodartistaMota, String nazionalitatea, String deskribapena,
            //int kideKopurua, int fundazioUrtea, String egoera, String artistaInfoGehiago

            bool sarrera_egiaztatu = clsArtista.new_artista_2(
                kodea, izena, kod_mota, nazionalitatea, deskribapena,
                kide_kopurua, fundazio_urtea, egoera, artista_info_gehiago
                );

            if (sarrera_egiaztatu == true)
            {
                cambiar_estado_panel_inferior(false);
                limpiar_panel_edicion();

                //freskatu_artisten_datuak(con, "");
                freskatu_artisten_datuak(con, param);

                lehenengoa_aukeratu();
                //dgArtistas.Refresh();//datu guztiak freskatu
                //reader = clsArtista.getArtistak_grid_artistak(con, "");


                


                foreach (DataGridViewRow row in dgArtistas.Rows)    //bilatu orain sartu dugun artista eta lerro hori hautatu
                {
                    if (kodea == Int32.Parse(row.Cells["KodArtista"].Value.ToString()))
                    {
                        row.Selected = true;
                        this.dgArtistas.Rows[row.Index].Selected = true;
                        String a = this.dgArtistas.Rows[row.Index].Cells["Deskribapena"].Value.ToString();
                        Console.WriteLine(a);

                        //dgArtistas.Rows[row.Index].Selected = true;

                        //cargar_artista();
                    }
                }
                
            }

        }




        private void btnBerria_Click(object sender, EventArgs e)
        {


            limpiar_panel_edicion();
            cambiar_estado_panel_inferior(true);


            clsArtista.getArtistak_MaxCode(con, "");
            this.txtEdicionKodea.Text = Artista.prueba_enviar.ToString();
        }

        private void limpiar_panel_edicion()
        {
            this.txtEdicionIzena.Text = "";
            this.numEdicionKideak.Value = 0;
            this.txtEdicionFundazioUrtea.Text = "";

            this.txtEdicionArtistaMotaKodea.Text = "";
            this.txtEdicionArtistaMotaDesk.Text = "";

            this.txtEdicionNazionalitateaKodea.Text = "";
            this.txtEdicionNazionalitateaDesk.Text = "";

            this.rdbEdicionJardueran.Checked = true;    //activar por defecto

            this.txtEdicionDeskribapena.Text = "";
        }

        private void cambiar_estado_panel_inferior(bool est)
        {
            ////enabled
            //this.txtEdicionIzena.Enabled = est;
            //this.numEdicionKideak.Enabled = est;
            //this.pctEdicionArtistaMota.Enabled = est;
            //this.txtEdicionFundazioUrtea.Enabled = est;
            //this.txtEdicionIzena.Enabled = est;
            //this.pctEdicionNazionalitatea.Enabled = est;
            //this.gbEdicionArtistaEgoera.Enabled = est;
            //this.txtEdicionDeskribapena.Enabled = est;

            this.dgArtistas.Enabled = !est;

            this.btnBerria.Enabled = !est;
            this.btnEditatu.Enabled = !est;

            this.btnOnartu.Enabled = est;
            this.btnEzeztatu.Enabled = est;


            this.txtEdicionIzena.Enabled = est;
            this.numEdicionKideak.Enabled = est;
            this.txtEdicionFundazioUrtea.Enabled = est;
            this.pctEdicionArtistaMota.Enabled = est;
            this.pctEdicionNazionalitatea.Enabled = est;
            this.gbEdicionArtistaEgoera.Enabled = est;
            this.txtEdicionDeskribapena.Enabled = est;

        }

        private void pctEdicionArtistaMota_Click(object sender, EventArgs e)
        {
            frmArtistaMotak _frmArtistaMotak = new frmArtistaMotak();
            _frmArtistaMotak.ShowDialog();

            if (_frmArtistaMotak.aukeraturiko_mota_kodea != null)
            {
                this.txtEdicionArtistaMotaKodea.Text = _frmArtistaMotak.aukeraturiko_mota_kodea.ToString();
                this.txtEdicionArtistaMotaDesk.Text = _frmArtistaMotak.aukeraturiko_mota_izena.ToString();
            }
        }

        private void pctEdicionNazionalitatea_Click(object sender, EventArgs e)
        {
            frmNazionalitateak _frmNazionalitateak = new frmNazionalitateak();
            _frmNazionalitateak.ShowDialog();

            if (_frmNazionalitateak.nazionalitate_kodea != "-?")
            {
                this.txtEdicionNazionalitateaKodea.Text = _frmNazionalitateak.nazionalitate_kodea.ToString();
                this.txtEdicionNazionalitateaDesk.Text = _frmNazionalitateak.nazionalitate_izena.ToString();
            }
        }

        private void dgArtistas_KeyDown(object sender, KeyEventArgs e)
        {
            cargar_artista();
        }

        private void dgArtistas_KeyUp(object sender, KeyEventArgs e)
        {
            cargar_artista();
        }

        private void btnEzeztatu_Click(object sender, EventArgs e)
        {
            limpiar_panel_edicion();
            cambiar_estado_panel_inferior(false);
        }

        private void txtEdicionFundazioUrtea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}



//Guardar datos en dataset: https://www.youtube.com/watch?v=O-D9yuH3Cu4
