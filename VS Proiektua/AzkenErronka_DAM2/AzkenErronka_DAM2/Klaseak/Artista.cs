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

        #region "DECLARACIONES"

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
            //String sql = "select " +
            //    "KodArtista, IzenaArtista, " +
            //    "ArtistaMota.MotaIzena as Mota, " +
            //    "Nazionalitatea, KideKopurua, FundazioUrtea, Egoera, ArtistaInfoGehiago, Adina " +
            //    "from Artista, ArtistaMota " +
            //    "where Artista.KodArtistaMota = ArtistaMota.KodMota" + parametro;


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
