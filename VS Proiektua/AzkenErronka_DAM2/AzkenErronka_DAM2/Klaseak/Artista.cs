using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzkenErronka_DAM2.Klaseak
{
    public class Artista
    {


        public SqlDataReader getArtistak(SqlConnection conn, String parametro)
        {
            String sql = "select * from Artista" + parametro;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


        public int getArtistak_MaxCode(SqlConnection conn, String parametro)
        {
            int maxnum = 0;

            using (conn)

            {
                SqlCommand cmd = new SqlCommand("select MAX(KodArtista) from Artista", conn);

                //conn.Open();
                maxnum = Convert.ToInt32(cmd.ExecuteScalar());
                //conn.Close();

            }

            return maxnum;
        }



    }
}
