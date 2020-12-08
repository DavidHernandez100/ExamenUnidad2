using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPersonal
{
    public class Datos
    {
        public static string Hora (string a)
        {
            return a = DateTime.Now.ToShortTimeString();
        }

        public static string Dia (string b)
        {
            return b = DateTime.Now.ToLongDateString();
        }
    }
}
