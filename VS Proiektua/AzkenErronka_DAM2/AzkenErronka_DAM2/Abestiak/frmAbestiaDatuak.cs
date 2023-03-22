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
            int mota_kodea = frmEdukiaArtista.abesti_mota;

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

    }
}
