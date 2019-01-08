using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    static class ServicioOT_DAL
    {
        private static DataSource Dsource;

        public static List<ServicioOT> SelectAllServices()
        {
            SqlConnection conexion;

            conexion = Dsource.getConexion();
            conexion.Open();

            List<Libreta> libretas = new List<Libreta>();

            SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["ConexionBaseDeDatos"]);

            conexion.Open();

            SqlCommand query = conexion.CreateCommand();

            query.CommandText = "SELECT Libreta.ID_libreta, Libreta.NameLibreta, Libreta.ID_color FROM Usuario_Libreta INNER JOIN Libreta ON Usuario_Libreta.ID_libreta = Libreta.ID_libreta INNER JOIN Usuario ON Usuario_Libreta.ID_usuario = Usuario.ID_usuario WHERE Usuario.ID_usuario = @ID_usuario";
            query.Parameters.AddWithValue("@ID_usuario", usuario);

            //5-ejecutamos la consulta
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read()) //mientras haya un registro para leer
            {
                //creo libreta, le completo los datos 
                Libreta libreta = new Libreta();
                libreta.ID_libreta = (int)reader["ID_libreta"];
                libreta.NameLibreta = reader["NameLibreta"].ToString();

                libretas.Add(libreta);
            }

            //CERRAR EL READER AL TERMINAR DE LEER LOS REGISTROS
            reader.Close();
            //CERRAR LA CONEXION AL TERMINAR!!!!
            conexion.Close();

            return libretas;



        }
    }

}