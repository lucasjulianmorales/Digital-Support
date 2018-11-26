using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using SL;
using SL.Idioma;

namespace BLL
{
    public static class Usuario_BLL
    {
        static public void  AddUser()
        {
           
        }
        static public Usuario LogIn( Usuario user)
        {

            Usuario_DAL.UserCredentials(user);
            
            return user;
        }

        
        

    }
}
