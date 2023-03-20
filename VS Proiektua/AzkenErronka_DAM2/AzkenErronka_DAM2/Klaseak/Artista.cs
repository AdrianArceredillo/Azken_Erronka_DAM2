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
                "ArtistaEgoera.EgoeraDeskribapena, " +

                "Artista.KodArtistaMota, " +
                "Nazionalitateak.NazioaIzena " +


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





            //            KodArtista, IzenaArtista, Artista.Deskribapena, Nazionalitateak.IdNazioa, ArtistaMota.MotaIzena as Mota, KideKopurua, FundazioUrtea, 
            //ArtistaEgoera.EgoeraDeskribapena, Artista.KodArtistaMota, Nazionalitateak.NazioaIzena
            //from Artista, ArtistaMota, Nazionalitateak, ArtistaEgoera where Artista.KodArtistaMota = ArtistaMota.KodMota and Artista.Nazionalitatea = Nazionalitateak.IdNazioa
            //and Artista.Egoera = ArtistaEgoera.KodEgoera
        }


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


        //public void new_artista(SqlConnection conn, String parametro)
        public void new_artista(SqlConnection conn,
            int kodartista, String izenaArtista, int kodartistaMota, String nazionalitatea, String deskribapena,
            int kideKopurua, int fundazioUrtea, String egoera, String artistaInfoGehiago
            )
        {
            using (SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True"))
            {
                con.Open();
                SqlCommand sql_cmnd = new SqlCommand("new_artista", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;

                sql_cmnd.Parameters.AddWithValue("@kodartista", SqlDbType.Int).Value = kodartista;
                sql_cmnd.Parameters.AddWithValue("@izenaArtista", SqlDbType.VarChar).Value = izenaArtista;
                sql_cmnd.Parameters.AddWithValue("@KodArtistaMota", SqlDbType.Int).Value = kodartistaMota;
                sql_cmnd.Parameters.AddWithValue("@Nazionalitatea", SqlDbType.VarChar).Value = nazionalitatea;
                sql_cmnd.Parameters.AddWithValue("@Deskribapena", SqlDbType.VarChar).Value = deskribapena;
                sql_cmnd.Parameters.AddWithValue("@KideKopurua", SqlDbType.Int).Value = kideKopurua;
                sql_cmnd.Parameters.AddWithValue("@FundazioUrtea", SqlDbType.Int).Value = fundazioUrtea;
                sql_cmnd.Parameters.AddWithValue("@Egoera", SqlDbType.Char).Value = egoera;
                sql_cmnd.Parameters.AddWithValue("@ArtistaInfoGehiago", SqlDbType.VarChar).Value = artistaInfoGehiago;

                sql_cmnd.ExecuteNonQuery();
                con.Close();
            }
        }


        public bool new_artista_2(
            int kodartista, String izenaArtista, int kodartistaMota, String nazionalitatea, String deskribapena,
            int kideKopurua, int fundazioUrtea, String egoera, String artistaInfoGehiago
            )
        {
            bool sartuta = false;

            SqlDataAdapter adapter = new SqlDataAdapter();

            using (SqlConnection con = new SqlConnection("Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True"))
            {
                con.Open();
                SqlCommand sql_cmnd = new SqlCommand("new_artista", con);
                sql_cmnd.CommandType = CommandType.StoredProcedure;

                sql_cmnd.Parameters.AddWithValue("@kodartista", SqlDbType.Int).Value = kodartista;
                sql_cmnd.Parameters.AddWithValue("@izenaArtista", SqlDbType.VarChar).Value = izenaArtista;
                sql_cmnd.Parameters.AddWithValue("@KodArtistaMota", SqlDbType.Int).Value = kodartistaMota;
                sql_cmnd.Parameters.AddWithValue("@Nazionalitatea", SqlDbType.VarChar).Value = nazionalitatea;
                sql_cmnd.Parameters.AddWithValue("@Deskribapena", SqlDbType.VarChar).Value = deskribapena;
                sql_cmnd.Parameters.AddWithValue("@KideKopurua", SqlDbType.Int).Value = kideKopurua;
                sql_cmnd.Parameters.AddWithValue("@FundazioUrtea", SqlDbType.Int).Value = fundazioUrtea;
                sql_cmnd.Parameters.AddWithValue("@Egoera", SqlDbType.Char).Value = egoera;
                sql_cmnd.Parameters.AddWithValue("@ArtistaInfoGehiago", SqlDbType.VarChar).Value = artistaInfoGehiago;

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


//Stored procedures: https://www.c-sharpcorner.com/article/execute-a-stored-procedure-programmatically/
//insert into: https://stackoverflow.com/questions/20971680/sql-server-insert-if-not-exists
//inser into 2: https://stackoverflow.com/questions/12142806/how-to-insert-records-in-database-using-c-sharp-language