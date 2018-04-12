using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_Validaciones;

namespace Taller_Validaciones.Control
{
    public class ControlTaller
    {
        public bool esVacio(string campo)
        {
            bool estado = true;

            if ( campo == "")
            {
                estado = true;
            }
            else
            {
                estado = false;
            }

            return estado;
        }
    }
}
