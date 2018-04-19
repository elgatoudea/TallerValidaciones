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
            long NUIP;


            Control.ControlTaller controlVacio = new Control.ControlTaller();

            if (controlVacio.esVacio(txtNombrePaciente.Text)==true)
            {
                erpMensaje.SetError(txtNombrePaciente, "El nombre no puede ser vacio"); return;
            }
            else
            {
                erpMensaje.SetError(txtNombrePaciente, "");
            }

            if (controlVacio.esVacio(txtNumeroDocumento.Text) == true)
            {
                erpMensaje.SetError(txtNumeroDocumento, "El Numero del Documento no puede ser vacio"); return;
            }
            else
            {
                erpMensaje.SetError(txtNumeroDocumento, "");
            }
            if (cboTipoDocumento.SelectedIndex == 1)
            {
                NUIP = Convert.ToInt64(txtNumeroDocumento.Text);
                if (NUIP < 1000000000 || NUIP > 9999999999)
                {
                    MessageBox.Show(this, "El NUIP (número único de identificación personal) debe ser mayor a 1000000000 y menor de 9999999999");
                    erpMensaje.SetError(txtNumeroDocumento, "Para continuar y grabar correctamente el registro debes modificar este campo");
                    return;
                }
            }
            if (controlVacio.esVacio(txtCostoServicio.Text) == true)
            {
                erpMensaje.SetError(txtCostoServicio, "El Costo del Servicio no puede ser vacio y debe ser mayor o igual a cero"); return;
            }
            else if (Convert.ToInt64(txtCostoServicio.Text) >= 0)
            {
                erpMensaje.SetError(txtCostoServicio, "");
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


            List<TipoRango> tiposRango = new List<TipoRango>();
            tiposRango.Add(new TipoRango() { Id = 1, Nombre = "A" });
            tiposRango.Add(new TipoRango() { Id = 2, Nombre = "B" });
            tiposRango.Add(new TipoRango() { Id = 3, Nombre = "C" });

            cbRango.DataSource = tiposRango;
            cbRango.DisplayMember = "Nombre";
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar campo solo numeros
            if (cboTipoDocumento.SelectedIndex == 0 || cboTipoDocumento.SelectedIndex == 1 || cboTipoDocumento.SelectedIndex == 3)
            {
                if (!((int)e.KeyChar == 8 || (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
            }

           
        }

        private void txtCostoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar campo solo numeros
            
                if (!((int)e.KeyChar == 8 || (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
        }
    }
}
