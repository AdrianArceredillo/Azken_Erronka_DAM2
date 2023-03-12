using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzkenErronka_DAM2.Klaseak
{
    public class Nazionalitatea
    {
        #region "DECLARACIONES"

        #endregion


        public SqlDataReader getNazionalitateak(SqlConnection conn, String parametro)
        {
            String sql = "select * from Nazionalitateak" + parametro;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }


    }
}
