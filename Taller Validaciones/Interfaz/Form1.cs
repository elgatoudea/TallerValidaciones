using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_Validaciones.Entidades;

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
                erpMensaje.SetError(txtNombrePaciente, "El nombre no puede ser vacio");
            }
            else
            {
                erpMensaje.SetError(txtNombrePaciente, "");
            }

            if (controlVacio.esVacio(txtNombrePaciente.Text) == true)
            {
                erpMensaje.SetError(txtNombrePaciente, "El nombre no puede ser vacio");
            }
            else
            {
                erpMensaje.SetError(txtNombrePaciente, "");
            }


        }

        private void frmRegistroPrestacionServicios_Load(object sender, EventArgs e)
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();
            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cedula de Ciudadania" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "NUIP" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Tarjeta de Extranjería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Tarjeta de Identidad" });

            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cboTipoDocumento.SelectedValue== "Cedula de Ciudadania")
            {
                MessageBox.Show("Hola");
                if (!((int)e.KeyChar == 8 || (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
