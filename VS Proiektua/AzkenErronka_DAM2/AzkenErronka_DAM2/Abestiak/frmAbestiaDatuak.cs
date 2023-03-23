using AzkenErronka_DAM2.Artistak;
using AzkenErronka_DAM2.ArtistaMotak;
using AzkenErronka_DAM2.Edukia;
using AzkenErronka_DAM2.Klaseak;
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


namespace AzkenErronka_DAM2.Abestiak
{
    public partial class frmAbestiaDatuak : Form
    {

        #region "DECLARACIONES"

        string zeregina_jaso = "";
        Abestia clsAbestia = new Abestia();
        #endregion

        public frmAbestiaDatuak()
        {
            InitializeComponent();
        }

        private void frmAbestiaDatuak_Load(object sender, EventArgs e)
        {
            zeregina_jaso = frmEdukiaArtista.zeregina;

            zeregina_irakurri(zeregina_jaso);

            //this.txtAbestiaKodea.Text = frmEdukiaArtista.kod_abestia.ToString();


            /*
             recibir "zeregina"
             */
        }

        private void zeregina_irakurri(string zere)
        {
            if (zere == "berria")
            {
                //cargar nuevo código + cargar vacío
                clsAbestia.getAbestiak_MaxCode("");
                this.txtAbestiaKodea.Text = Abestia.prueba_enviar.ToString();
                laukiak_hutsik();
            }
            else if (zere == "editatu")
            {
                //cargar datos de la canción
                this.txtAbestiaKodea.Enabled = false;
                abestia_kargatu();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (zeregina_jaso == "berria")
            {
                //newAbestia
                int kodabestia = Int32.Parse(this.txtAbestiaKodea.Text);
                String abestiaIzena = this.txtAbestiaIzena.Text;

                int egileaKodea = 0;
                if (this.txtEgileaKodea.Text != "")
                {
                    egileaKodea = Int32.Parse(this.txtEgileaKodea.Text);
                }
                else
                {
                    egileaKodea = 0;
                }

                int albumaKodea = Int32.Parse(this.txtAlbumaKodea.Text);
                String abestiMota = this.txtMotaKodea.Text;
                int generoa = 0;

                int collab1 = 0;
                if (this.txtCollab1_Kodea.Text != "")
                {
                    collab1 = Int32.Parse(this.txtCollab1_Kodea.Text);
                }
                else
                {
                    collab1 = 0;
                }

                int collab2 = 0;
                if (this.txtCollab2_Kodea.Text != "")
                {
                    collab2 = Int32.Parse(this.txtCollab2_Kodea.Text);
                }
                else
                {
                    collab2 = 0;
                }

                int collab3 = 0;
                if (this.txtCollab3_Kodea.Text != "")
                {
                    collab3 = Int32.Parse(this.txtCollab3_Kodea.Text);
                }
                else
                {
                    collab3 = 0;
                }

                String deskribapena = this.txtDeskribapena.Text;
                int urtea = 2023;



                bool sarrera_egiaztatu = clsAbestia.new_abestia_2(
                    kodabestia, abestiaIzena, egileaKodea, albumaKodea, abestiMota, generoa, collab1, collab2, collab3, deskribapena, urtea);
            }
            else if (zeregina_jaso == "editatu")
            {
                //setAbestia
            }
        }

        private void abestia_kargatu()
        {
            int kod_abe = frmEdukiaArtista.kod_abestia;
            string abe_izena = frmEdukiaArtista.abestia_izena;
            string artista_izena = frmEdukiaArtista.artista;
            string albuma_izena = frmEdukiaArtista.albuma;
            string abesti_mota = frmEdukiaArtista.mota;
            int egilea_kodea = frmEdukiaArtista.egilea_kodea;
            int albuma_kodea = frmEdukiaArtista.albuma_kodea;
            string mota_kodea = frmEdukiaArtista.abesti_mota;

            //++++++

            this.txtAbestiaKodea.Text = kod_abe.ToString();
            this.txtAlbumaKodea.Text = albuma_kodea.ToString();
            this.txtMotaKodea.Text = mota_kodea.ToString();
            this.txtEgileaKodea.Text = egilea_kodea.ToString();

            this.txtAbestiaIzena.Text = abe_izena;
            this.txtAlbumaIzena.Text = albuma_izena;
            this.txtMotaIzena.Text = abesti_mota;
            this.txtEgileaIzena.Text = artista_izena;

        }

        private void laukiak_hutsik()
        {
            this.txtAbestiaIzena.Text = "";

            this.txtAlbumaKodea.Text = "";
            this.txtAlbumaIzena.Text = "";

            this.txtMotaKodea.Text = "";
            this.txtMotaIzena.Text = "";

            this.txtEgileaKodea.Text = frmEdukiaArtista.egilea_kodea.ToString();
            this.txtEgileaIzena.Text = "";

            this.txtCollab1_Kodea.Text = "";
            this.txtCollab1_Izena.Text = "";

            this.txtCollab2_Kodea.Text = "";
            this.txtCollab2_Izena.Text = "";

            this.txtCollab3_Kodea.Text = "";
            this.txtCollab3_Izena.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
