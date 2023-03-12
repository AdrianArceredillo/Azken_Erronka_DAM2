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
using AzkenErronka_DAM2.Klaseak;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AzkenErronka_DAM2.Login
{
    public partial class frmLogin : Form
    {
        #region "DECLARACIONES"
        SqlConnection con = new SqlConnection();
        Erabiltzaileak usuarios = new Erabiltzaileak();
        String username, password;
        #endregion


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Conexion();
        }

        private void btnSartu_Click(object sender, EventArgs e)
        {
            //this.Hide();

            username = this.txtLoginUsername.Text.Trim();
            password = this.txtLoginPassword.Text.Trim();

            String parametro_login = " ";


            

            frmArtistak _frmArtistak = new frmArtistak();
            
            _frmArtistak.ShowDialog();
            //this.Hide();
            //this.Close();
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void Conexion()
        {
            con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
            con.Open();
        }

        //private void btnConectar_Click(object sender, EventArgs e)
        //{
        //    //https://www.youtube.com/watch?v=0M0C_d5dxSQ
        //    //SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
        //    con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");

        //    con.Open();
        //    MessageBox.Show("sql is connected");

        //    frmLogin frmLogin = new frmLogin();
        //    frmLogin.Show();

        //}

    }
}
