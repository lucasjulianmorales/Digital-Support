using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DataSource
    {
            public SqlCommand getCommand()
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DigitalSupportDB"].ToString());
                SqlCommand cmm = conexion.CreateCommand();
                return cmm;
            }

            public SqlConnection getConexion()
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DigitalSupportDB"].ToString());
                return conexion;
            }
        }
    }
}
