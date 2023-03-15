using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzkenErronka_DAM2.Klaseak
{
    public class ArtistaMota
    {

        public SqlDataReader getArtistaMotak(SqlConnection conn, String parametro)
        {
            String sql = "select * from ArtistaMota" + parametro;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public SqlDataReader getArtistaMotak_Concreto(SqlConnection conn, String parametro)
        {
            String sql = "select ArtistaMota.KodMota, ArtistaMota.MotaIzena from ArtistaMota" + parametro;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        public int getArtistaMota_MaxCode(SqlConnection conn, String parametro)
        {
            int maxnum = 0;

            using (conn)

            {
                SqlCommand cmd = new SqlCommand("select MAX(KodMota) from ArtistaMota", conn);

                //conn.Open();
                maxnum = Convert.ToInt32(cmd.ExecuteScalar());
                //conn.Close();

            }

            return maxnum;
        }



    }
}
