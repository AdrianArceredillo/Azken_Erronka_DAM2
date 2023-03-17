using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Klasea
{
    public class Conexion
    {

        public SqlConnection abri_conexion()
        {
            String conn_str = "Data Source=LENOVO_ADRI\\SQLEXPRESS;Initial Catalog=MusikaBilduma;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn_str);
            con.Open();
            return con;
        }

        public void cerrar_conexion(SqlConnection conn)
        {
            conn.Close();
        }

    }
}
