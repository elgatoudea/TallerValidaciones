using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Validaciones
{
    public partial class frmRegistroPrestacionServicios : Form
    {
        public frmRegistroPrestacionServicios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Control.ControlTaller controlVacio = new Control.ControlTaller();

            if (controlVacio.esVacio(txtNombrePaciente.Text)==true)
            {
                erpMensaje.SetError(txtNombrePaciente, "El nombre es obligatorio");
            }
            else { erpMensaje.SetError(txtNombrePaciente, ""); }


        }
    }
}
