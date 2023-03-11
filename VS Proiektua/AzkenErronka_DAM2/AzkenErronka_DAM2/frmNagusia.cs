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
using System.Xml.Linq;

using System.Data.SqlClient;
using AzkenErronka_DAM2.Artistak;

namespace AzkenErronka_DAM2
{
    public partial class frmNagusia : Form
    {
        public frmNagusia()
        {
            InitializeComponent();
        }

        private void frmNagusia_Load(object sender, EventArgs e)
        {
            //< add name = "NameofConnectionString" connectionString = "server=YourServerInstanceName; database=DatabaseName; integrated security=SSPI" providerName = "System.Data.SqlClient" />

            //SqlConnection con = new SqlConnection("Data source = LENOVO_ADRI/SQLEXPRESS; Initial catalog = MusikaBilduma; User id = 'sa'; password = 'admin'");

            //con.Open();


            //https://www.youtube.com/watch?v=0M0C_d5dxSQ
            //SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");


            //Console.WriteLine("Hola! ");
        }


        private void btnConectar_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=0M0C_d5dxSQ
            SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");

            con.Open();
            MessageBox.Show("sql is connected");

            SqlCommand cmd = new SqlCommand("select * from Kideak", con);//sentencia SQL

            // if the command has no return value
            cmd.ExecuteNonQuery();
            //else you might want a Sql data reader to read the return value
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow((IDataRecord)read);//irakurri lerro bakar bat

                ////do something
                //Console.WriteLine(read.ToString());
            }

            //read.Close();// gehiago irakurtzeko ez dagoenean, itxi metodoari deitu
            //con.Close();//konexioa amaitu edo itxi


            frmArtistak frmArtistak = new frmArtistak();
            frmArtistak.Show();

        }



        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            Console.WriteLine(String.Format("{0}, {1}, {2}", dataRecord[0], dataRecord[1], dataRecord[2]));
        }





    }





}


//BIBLIOGRAFÍA

//Conectarse a SQL Express: https://www.youtube.com/watch?v=0M0C_d5dxSQ
//REPORTS: https://stackoverflow.com/questions/9700840/how-to-print-a-report-from-an-sql-database-using-visual-basic
//Save data in DataGridView: https://www.c-sharpcorner.com/article/display-data-in-a-datagridview-C-Sharp-6/