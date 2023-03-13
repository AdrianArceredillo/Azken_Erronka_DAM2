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

namespace AzkenErronka_DAM2.Klaseak
{
    public class Artista
    {

        #region "DECLARACIONES"
        //SqlConnection conn = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True");
        public static int prueba_enviar = 0;
        #endregion


        public SqlDataReader getArtistak_completo(SqlConnection conn, String parametro)
        {
            String sql = "select * from Artista" + parametro;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader getArtistak_grid_artistak(SqlConnection conn, String parametro)
        {
            String sql = "select " +
                "KodArtista, " +
                "IzenaArtista, " +
                "Artista.Deskribapena," +
                "Nazionalitateak.IdNazioa, " +

                "ArtistaMota.MotaIzena as Mota, " +
                "KideKopurua, " +
                "FundazioUrtea, " +
                "ArtistaEgoera.EgoeraDeskribapena " +


                //"ArtistaInfoGehiago, " +
                //"Adina " +

                "from " +
                "Artista, ArtistaMota, Nazionalitateak, ArtistaEgoera " +

                "where " +
                "Artista.KodArtistaMota = ArtistaMota.KodMota " +
                "and Artista.Nazionalitatea = Nazionalitateak.IdNazioa " +
                "and Artista.Egoera = ArtistaEgoera.KodEgoera" + parametro;

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        //public int getArtistak_MaxCode(SqlConnection conn, String parametro)
        //{
        //    int maxnum = 0;

        //    using (conn)

        //    {
        //        SqlCommand cmd = new SqlCommand("select MAX(KodArtista) from Artista", conn);

        //        //conn.Open();
        //        maxnum = Convert.ToInt32(cmd.ExecuteScalar());
        //        //conn.Close();

        //    }

        //    return maxnum;
        //}


        //public int getArtistak_MaxCode(SqlConnection conn, String parametro)
        //{
        //    //conn.Open();

        //    int maxnum = 0;

        //    using (conn)

        //    {
        //        SqlCommand cmd = new SqlCommand("select MAX(KodArtista) from Artista", conn);

        //        maxnum = Convert.ToInt32(cmd.ExecuteScalar());
        //    }

        //    //conn.Close();

        //    return maxnum;
        //}


        public void getArtistak_MaxCode(SqlConnection conn, String parametro)
        {
            int a = 0;

            using (SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True"))
            {
                con.Open();
                SqlCommand sql_cmnd = new SqlCommand("maxArtistaCodigo", con);
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
                }
                
                con.Close();
            }

            //return a;
        }



        //private static int ReadSingleRow(IDataRecord dataRecord)
        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            //Console.WriteLine(String.Format("{0}, {1}, {2}", dataRecord[0], dataRecord[1], dataRecord[2]));
            Console.WriteLine(String.Format("{0}", dataRecord[0]));

            int prueba = (int)dataRecord[0];
            //return prueba;
        }


    }
}


//Stored procedures: https://www.c-sharpcorner.com/article/execute-a-stored-procedure-programmatically/