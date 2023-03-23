using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using AzkenErronka_DAM2.Artistak;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace AzkenErronka_DAM2.Klaseak
{
    public class Abestia
    {
        #region "DECLARACIONES"
        //SqlConnection conn = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
        public static int prueba_enviar = 0;
        #endregion


        public void getAbestiak_MaxCode(String parametro)
        {
            int a = 0;

            using (SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True"))
            {
                con.Open();
                SqlCommand sql_cmnd = new SqlCommand("maxAbestiaCodigo", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@parametro", SqlDbType.NVarChar).Value = "";
                //sql_cmnd.Parameters.AddWithValue("@LAST_NAME", SqlDbType.NVarChar).Value = lastName;
                //sql_cmnd.Parameters.AddWithValue("@AGE", SqlDbType.Int).Value = age;
                sql_cmnd.ExecuteNonQuery();

                SqlDataReader read = sql_cmnd.ExecuteReader();
                while (read.Read())
                {
                    ReadSingleRow((IDataRecord)read);//irakurri lerro bakar bat

                    prueba_enviar = Int32.Parse(read[0].ToString());
                    prueba_enviar = prueba_enviar + 1;
                }

                con.Close();
            }
        }

        //private static int ReadSingleRow(IDataRecord dataRecord)
        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            Console.WriteLine(String.Format("{0}", dataRecord[0]));

            int prueba = (int)dataRecord[0];
        }


        public bool new_abestia_2(
            int kodabestia, String abestiaIzena, int egileaKodea, int albumaKodea, String abestiMota, int generoa,
            int collab1, int collab2, int collab3, String deskribapena, int urtea
            )
        {
            bool sartuta = false;

            SqlDataAdapter adapter = new SqlDataAdapter();

            using (SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True"))
            {
                con.Open();
                SqlCommand sql_cmnd = new SqlCommand("new_abestia_2", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;

                sql_cmnd.Parameters.AddWithValue("@kodabestia", SqlDbType.Int).Value = kodabestia;
                sql_cmnd.Parameters.AddWithValue("@abestiaIzena", SqlDbType.VarChar).Value = abestiaIzena;
                sql_cmnd.Parameters.AddWithValue("@egileaKodea", SqlDbType.Int).Value = egileaKodea;
                sql_cmnd.Parameters.AddWithValue("@albumaKodea", SqlDbType.VarChar).Value = albumaKodea;
                sql_cmnd.Parameters.AddWithValue("@abestiMota", SqlDbType.VarChar).Value = abestiMota;
                sql_cmnd.Parameters.AddWithValue("@generoa", SqlDbType.Int).Value = generoa;
                sql_cmnd.Parameters.AddWithValue("@collab1", SqlDbType.Int).Value = collab1;
                sql_cmnd.Parameters.AddWithValue("@collab2", SqlDbType.Char).Value = collab2;
                sql_cmnd.Parameters.AddWithValue("@collab3", SqlDbType.VarChar).Value = collab3;
                sql_cmnd.Parameters.AddWithValue("@deskribapena", SqlDbType.VarChar).Value = deskribapena;
                sql_cmnd.Parameters.AddWithValue("@urtea", SqlDbType.VarChar).Value = urtea;

                // Let's ask the db to execute the query
                int rowsAdded = sql_cmnd.ExecuteNonQuery();
                if (rowsAdded > 0)
                {
                    MessageBox.Show("Row inserted!!");
                    sartuta = true;
                }
                else
                {
                    MessageBox.Show("No row inserted");

                    sartuta = false;
                }
                //sql_cmnd.ExecuteNonQuery();
                con.Close();
            }
            return sartuta;
        }



    }


}
