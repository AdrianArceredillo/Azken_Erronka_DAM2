using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Klasea.Conexion;

using System;
using System.Data.SqlClient;
using System.Text;

namespace Klasea
{
    public class Albuma
    {

        #region "DECLARACIONES"
        Conexion conexion = new Conexion();
        #endregion


        #region "METODOAK"
        public DataSet getAlbumak(string parametro)
        {
            DataSet dsAlbumak = new DataSet("Albumak");
            SqlConnection con = conexion.abri_conexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand("getAlbumak", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@parametro", parametro);
                    cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable("Albumakk");
                    DataRow row;
                    DataColumn column;

                    column = new DataColumn("KodAlb");
                    table.Columns.Add(column);

                    column = new DataColumn("AlbumaIzena");
                    table.Columns.Add(column);

                    column = new DataColumn("ArtistaKodea");
                    table.Columns.Add(column);

                    column = new DataColumn("AbestiKopurua");
                    table.Columns.Add(column);

                    column = new DataColumn("Urtea");
                    table.Columns.Add(column);


                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["KodAlb"] = reader.GetInt32(0);
                        row["AlbumaIzena"] = reader.GetString(1);
                        row["ArtistaKodea"] = reader.GetInt32(2);
                        row["AbestiKopurua"] = reader.GetInt32(3);
                        row["Urtea"] = reader.GetInt32(4);
                        table.Rows.Add(row);
                    }
                    dsAlbumak.Tables.Add(table);
                }
            }
            catch (Exception ex)
            {

            }

            conexion.cerrar_conexion(con);
            return dsAlbumak;
        }

        public DataSet getAlbumak_test(string parametro)
        {
            DataSet dsAlbumak = new DataSet("Albumak");
            SqlConnection con = conexion.abri_conexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand("getAlbumak_test", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@parametro", parametro);
                    cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    DataRow row;
                    DataColumn column;

                    column = new DataColumn("KodAlb");
                    table.Columns.Add(column);
                    column = new DataColumn("AlbumaIzena");
                    table.Columns.Add(column);
                    column = new DataColumn("ArtistaKodea");
                    table.Columns.Add(column);
                    column = new DataColumn("AbestiKopurua");
                    table.Columns.Add(column);
                    column = new DataColumn("Urtea");
                    table.Columns.Add(column);


                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["KodAlb"] = reader.GetInt32(0);
                        row["AlbumaIzena"] = reader.GetString(1);
                        row["ArtistaKodea"] = reader.GetInt32(2);
                        row["AbestiKopurua"] = reader.GetInt32(3);
                        row["Urtea"] = reader.GetInt32(4);
                        table.Rows.Add(row);
                    }
                    dsAlbumak.Tables.Add(table);
                }
            }
            catch (Exception ex)
            {

            }
            conexion.cerrar_conexion(con);
            return dsAlbumak;
        }

        
        #endregion


    }
}
