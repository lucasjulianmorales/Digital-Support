using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ENTITY
{
   public class Cotizacion_DAL
    {
        public static void AddCotizacion(Cotizacion cotizacion)
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-HJ3D0O9\\SQLEXPRESS;Initial Catalog=Digita_Support;Integrated Security=True");
            conexion.Open();
            SqlCommand Cmm = conexion.CreateCommand();


            Cmm.CommandText = "Insert into Cotizacion (Descripcion, Fecha_crea_cot, Monto, Creada_por) values ";
            Cmm.Parameters.AddWithValue("@Fecha_crea_cot", cotizacion.Fecha_crea_cot);
            Cmm.Parameters.AddWithValue("@Descripcion", cotizacion.Descripcion);
            Cmm.Parameters.AddWithValue("@Creada_por", cotizacion.Creada_por);
            Cmm.Parameters.AddWithValue("@Monto", cotizacion.Monto);
            Cmm.Parameters.AddWithValue("@ID_estado", cotizacion.ID_estado);

                 
        }
    }
}
