using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.SqlClient;

namespace DAL
{
    public static class Usuario_DAL
    {

      
        public static Usuario UserCredentials (Usuario user)
        {

            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-HJ3D0O9\\SQLEXPRESS;Initial Catalog=Digita_Support;Integrated Security=True");
            conexion.Open();
            SqlCommand Cmm = conexion.CreateCommand();


            Cmm.CommandText = "SELECT Usuario, Contraseña FROM Usuario WHERE Usuario = @Usuario and Contraseña = @Password ";
            Cmm.Parameters.AddWithValue("@Usuario", user.User_name);
            Cmm.Parameters.AddWithValue("@Password", user.Password);

            SqlDataReader reader = Cmm.ExecuteReader();
            if (reader.Read()) //mientras haya un registro para leer
            {
                user.User_name = reader["Usuario"].ToString();
                user.Password = reader["Contraseña"].ToString();
            }
            else
            {
                user = null;
            }

            return user;


        }

    }

    

    
}
