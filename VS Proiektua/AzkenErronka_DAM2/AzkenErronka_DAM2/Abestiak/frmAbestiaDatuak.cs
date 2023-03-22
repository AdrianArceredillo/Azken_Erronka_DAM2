using AzkenErronka_DAM2.Artistak;
using AzkenErronka_DAM2.ArtistaMotak;
using AzkenErronka_DAM2.Edukia;
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

            this.txtAbestiaKodea.Text = frmEdukiaArtista.kod_abestia.ToString();


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
                //abestia_kargatu();

                

                //setAbestia
            }
        }
    }
}
