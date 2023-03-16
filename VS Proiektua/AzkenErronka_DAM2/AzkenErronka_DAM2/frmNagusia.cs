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
using System.Data.Common;
using System.Globalization;
using AzkenErronka_DAM2.Login;

namespace AzkenErronka_DAM2
{
    public partial class frmNagusia : Form
    {

        #region "DECLARACIONES"
        public SqlConnection con;
        #endregion


        public frmNagusia()
        {
            InitializeComponent();
        }

        private void frmNagusia_Load(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=0M0C_d5dxSQ
            //SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");


            
        }


        private void btnConectar_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=0M0C_d5dxSQ
            //SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
            con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");

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


            

            frmLogin _frmLogin = new frmLogin();
            _frmLogin.ShowDialog();

            this.Close();
        }



        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            //Console.WriteLine(String.Format("{0}, {1}, {2}", dataRecord[0], dataRecord[1], dataRecord[2]));
            Console.WriteLine(String.Format("{0}, {1}, {2}", dataRecord[0], dataRecord[1], dataRecord[2]));
        }



        




    }

}


//BIBLIOGRAFÍA

//Conectarse a SQL Express: https://www.youtube.com/watch?v=0M0C_d5dxSQ
//REPORTS: https://stackoverflow.com/questions/9700840/how-to-print-a-report-from-an-sql-database-using-visual-basic
//Save data in DataGridView: https://www.c-sharpcorner.com/article/display-data-in-a-datagridview-C-Sharp-6/
//Ejemplos procedimientos SQL: https://www.srcodigofuente.es/aprender-sql/ejemplos-de-procedimientos-almacenados-sencillos
//Enviar datos entre formularios: https://stackoverflow.com/questions/7886544/passing-a-value-from-one-form-to-another-form
//Update datagridview using textbox: https://www.c-sharpcorner.com/UploadFile/718fc8/updating-datagridviews-record-using-textbox/
//Allow numbers only: https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
//Combobox change selected item: https://stackoverflow.com/questions/450059/how-do-i-set-the-selected-item-in-a-combobox-to-match-my-string-using-c
//allow only numbers and only one decimal point: https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
