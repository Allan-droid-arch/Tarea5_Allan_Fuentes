using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tarea5_Allan_Fuentes.Clases
{
    class operacion
    {
       

        public double tanque(double a,double an)
        {
            double r = 3.14 * Math.Pow(a, 2) * an*1000;
            return r;
        }

        public double nota(double a, double b, double c)
        {
            double total = 65-(a + b + c);
            return total;
        }
    }
}
