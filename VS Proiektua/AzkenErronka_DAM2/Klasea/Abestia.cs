using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasea
{
    public class Abestia
    {

        #region "DECLARACIONES"
        Conexion conexion = new Conexion();
        #endregion


        #region "METODOAK"
        public DataSet getAbestiak(string parametro)
        {
            DataSet dsAbestiak = new DataSet("Abestiak");
            SqlConnection con = conexion.abri_conexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand("getAbestiak", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@parametro", parametro);
                    cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable("Abestiakk");
                    DataRow row;
                    DataColumn column;

                    column = new DataColumn("KodAbestia");
                    table.Columns.Add(column);

                    column = new DataColumn("AbestiaIzena");
                    table.Columns.Add(column);

                    column = new DataColumn("EgileaKodea");
                    table.Columns.Add(column);

                    column = new DataColumn("AlbumaKodea");
                    table.Columns.Add(column);

                    column = new DataColumn("AbestiMota");
                    table.Columns.Add(column);

                    column = new DataColumn("Generoa");
                    table.Columns.Add(column);

                    column = new DataColumn("Collab1");
                    table.Columns.Add(column);

                    column = new DataColumn("Collab2");
                    table.Columns.Add(column);

                    column = new DataColumn("Collab3");
                    table.Columns.Add(column);

                    column = new DataColumn("Deskribapena");
                    table.Columns.Add(column);

                    column = new DataColumn("Urtea");
                    table.Columns.Add(column);


                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["KodAbestia"] = reader.GetInt32(0);
                        row["AbestiaIzena"] = reader.GetString(1);
                        row["EgileaKodea"] = reader.GetInt32(2);
                        row["AlbumaKodea"] = reader.GetInt32(3);
                        row["AbestiMota"] = reader.GetString(4);

                        row["Generoa"] = reader.GetInt32(5);

                        row["Collab1"] = reader.GetInt32(6);
                        row["Collab2"] = reader.GetInt32(7);
                        row["Collab3"] = reader.GetInt32(8);

                        row["Deskribapena"] = reader.GetString(9);
                        row["Urtea"] = reader.GetInt32(10);

                        table.Rows.Add(row);
                    }
                    dsAbestiak.Tables.Add(table);
                }
            }
            catch (Exception ex)
            {

            }

            conexion.cerrar_conexion(con);
            return dsAbestiak;
        }



        public DataSet getAbestiak_luzea(string parametro)
        {
            DataSet dsAbestiak = new DataSet("Abestiak");
            SqlConnection con = conexion.abri_conexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand("getAbestiak_luzea", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@parametro", parametro);
                    cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable("Abestiakk");
                    DataRow row;
                    DataColumn column;

                    column = new DataColumn("KodAbestia");
                    table.Columns.Add(column);

                    column = new DataColumn("AbestiaIzena");
                    table.Columns.Add(column);

                    column = new DataColumn("EgileaKodea");
                    table.Columns.Add(column);

                    column = new DataColumn("IzenaArtista");
                    table.Columns.Add(column);

                    column = new DataColumn("AlbumaKodea");
                    table.Columns.Add(column);

                    column = new DataColumn("AlbumaIzena");
                    table.Columns.Add(column);

                    column = new DataColumn("AbestiMota");
                    table.Columns.Add(column);

                    column = new DataColumn("AbestiMota_Izena");
                    table.Columns.Add(column);

                    column = new DataColumn("Generoa");
                    table.Columns.Add(column);

                    column = new DataColumn("GeneroIzena");
                    table.Columns.Add(column);

                    column = new DataColumn("Deskribapena");
                    table.Columns.Add(column);

                    column = new DataColumn("Urtea");
                    table.Columns.Add(column);


                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["KodAbestia"] = reader.GetInt32(0);
                        row["AbestiaIzena"] = reader.GetString(1);
                        row["EgileaKodea"] = reader.GetInt32(2);
                        row["IzenaArtista"] = reader.GetString(3);
                        row["AlbumaKodea"] = reader.GetInt32(4);
                        row["AlbumaIzena"] = reader.GetString(5);
                        row["AbestiMota"] = reader.GetInt32(6);
                        row["AbestiMota_Izena"] = reader.GetString(7);
                        row["Generoa"] = reader.GetInt32(8);
                        row["GeneroIzena"] = reader.GetInt32(9);
                        row["Deskribapena"] = reader.GetString(10);
                        row["Urtea"] = reader.GetString(11);
                        //++++++++
                        table.Rows.Add(row);
                    }
                    dsAbestiak.Tables.Add(table);
                }
            }
            catch (Exception ex)
            {

            }

            conexion.cerrar_conexion(con);
            return dsAbestiak;
        }



        public DataSet getAbestiKopurua_filtratuta(String parametro)
        {
            DataSet dsAbestiak = new DataSet("Abestiak");
            SqlConnection con = conexion.abri_conexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand("getAbestiKopurua_filtratuta", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@parametro", parametro);
                    cmd.ExecuteNonQuery();

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable("Abestiak_Filtratuta");
                    DataRow row;
                    DataColumn column;

                    column = new DataColumn("Kopurua");
                    table.Columns.Add(column);

                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["Kopurua"] = reader.GetInt32(0);
                        //++++++++
                        table.Rows.Add(row);
                    }
                    dsAbestiak.Tables.Add(table);
                }
            }
            catch (Exception ex)
            {

            }

            conexion.cerrar_conexion(con);
            return dsAbestiak;
        }


        #endregion


    }
}
