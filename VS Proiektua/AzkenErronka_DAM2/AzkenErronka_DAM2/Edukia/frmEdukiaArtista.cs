using AzkenErronka_DAM2.Artistak;
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
        DataSet dsAlbumak = new DataSet();
        DataTable dtAlbumak = new DataTable();

        public int kodAlb, artistaKodea, abestiKopurua, urtea;
        String albumaIzena;
        #endregion


        public frmEdukiaArtista()
        {   
            InitializeComponent();
        }

        private void frmEdukiaArtista_Load(object sender, EventArgs e)
        {
            //artistaKodea = clsAlbuma.artistaKodea;
            artistaKodea = frmArtistak.kod_art;

            String parametro = " kodAlb <> -1 and ArtistaKodea = " + artistaKodea;
            //dsAlbumak = clsAlbuma.getAlbumak("0");


            //dsAlbumak = clsAlbuma.getAlbumak_last(" kodAlb <> 0 and AbestiKopurua = 10");
            dsAlbumak = clsAlbuma.getAlbumak_last(parametro);


            //String parametro = "";
            //dsAlbumak = clsAlbuma.getAlbumak(" 1");

            dgAlbumes.DataSource = dsAlbumak.Tables["Table1"];
        }


        public void llenarDataGrid()
        {
            //String consulta = "select idUsuario,Nombre,ApellidoP,ApellidoM,Sexo,Telefono,Edad,Puesto from usuarios;";
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, new BaseDeDatos().obtenerConexion());
            //DataSet ds = new DataSet();
            //dataAdapter.Fill(ds);
            //dataGridUsuarios.ItemsSource = ds.Tables[0].DefaultView;
        }

    }
}
