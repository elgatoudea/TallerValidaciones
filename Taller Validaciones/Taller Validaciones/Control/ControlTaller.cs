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
        public bool EsVacio(string campo)
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


        public bool CumpleNUIP( long seleccion)
        {
            bool estado = false;
           
            if (seleccion >= 1000000000 && seleccion <= 9999999999)
            {
                estado = true;
            }
            else
            {
                MessageBox.Show("El NUIP (número único de identificación personal) debe ser mayor a 1000000000 y menor de 9999999999");
                estado = false;
            }
            return estado;
        }

        public long CalcularDescuento (Int64 rango, long costoServicio)
        {
            long descuento = 0;

            if (rango == 0)
            {
                descuento = costoServicio-((costoServicio * 30)/100);
            }
            else if (rango == 1)
                {
                    descuento = costoServicio - ((costoServicio * 20) / 100);
                }
                else if (rango == 2)
                {
                    descuento = costoServicio - ((costoServicio * 10) / 100);
                }
            return descuento;
        }

        
    }
}
