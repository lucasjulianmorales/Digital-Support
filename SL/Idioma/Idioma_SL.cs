using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace SL.Idioma
{
    public class Idioma_SL
    {

         public void CambiarIdioma(string cultura)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-AR");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-AR");
            //Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        }

         public string Traducir(String Palabra)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            StreamReader sr = new StreamReader(Thread.CurrentThread.CurrentUICulture.Name + ".id");

            string file;
            int indice;


            while ((file = sr.ReadLine()) != null)
            {
                if (file.Contains(Palabra))
                {
                    indice = file.IndexOf(";" + Palabra);
                    Palabra = file.Remove(indice);
                    break;
                }
            }

            return Palabra;
        }

    }
}
