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


        //Crear Objeto de la Clase Control
        private Control.ControlTaller objetoControl = new Control.ControlTaller();
        private long DescuentoFinal = 0;


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Definición de Variables Locales
            long NUIP = 0;

            //Validador de vacio Paciente
            if (objetoControl.EsVacio(txtNombrePaciente.Text) == true)
            {
                erpMensaje.SetError(txtNombrePaciente, "El nombre no puede ser vacio"); return;
            }
            else
            {
                erpMensaje.SetError(txtNombrePaciente, "");
            }

            //Validador de vacio Numero de Documento
            if (cboTipoDocumento.SelectedIndex == 2)
            {
                if (objetoControl.EsVacio(txtNumeroDocumento.Text) == true)
                {
                    erpMensaje.SetError(txtNumeroDocumento, "El Numero del Documento no puede ser vacio o debe ser mayor a 0"); return;
                }
                else
                {
                    erpMensaje.SetError(txtNumeroDocumento, "");
                }
            }
            else
            {

                if (objetoControl.EsVacio(txtNumeroDocumento.Text) == true || Convert.ToInt64(txtNumeroDocumento.Text) == 0)
                {
                    erpMensaje.SetError(txtNumeroDocumento, "El Numero del Documento no puede ser vacio o debe ser mayor a 0"); return;
                }
                else
                {
                    erpMensaje.SetError(txtNumeroDocumento, "");
                }
            }

            //Validador de vacio Costo de Servicio
            if (objetoControl.EsVacio(txtCostoServicio.Text) == true)
            {
                erpMensaje.SetError(txtCostoServicio, "El Costo del Servicio no puede ser vacio y debe ser mayor o igual a cero"); return;
            }
            else if (Convert.ToInt64(txtCostoServicio.Text) >= 0)
            {
                erpMensaje.SetError(txtCostoServicio, "");
            }


            //Validador de Tipo de Documento para el item NUIP
            if (cboTipoDocumento.SelectedIndex == 1)
                {
                    NUIP = Convert.ToInt64(txtNumeroDocumento.Text);
                    if (objetoControl.CumpleNUIP(NUIP) == false)
                    {
                        erpMensaje.SetError(txtNumeroDocumento, "Para continuar y grabar correctamente el registro debes modificar este campo");
                        return;
                    }
                }

            if (objetoControl.EsVacio(txtNombrePaciente.Text) == false && objetoControl.EsVacio(txtCostoServicio.Text) == false && objetoControl.EsVacio(txtCostoServicio.Text) == false)
            {
                DescuentoFinal = objetoControl.CalcularDescuento(cbRango.SelectedIndex, Convert.ToInt64(txtCostoServicio.Text));
                MessageBox.Show(this, "Los datos han sido verificados y guardados satisfactoria \nEl Nombre del Paciente es: "+txtNombrePaciente.Text+ "\nCon Número de Identificación: " + txtNumeroDocumento.Text+" \nCon un costo de servicio de: "+ DescuentoFinal + " Aplicado el descuento", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3);
            }
        }
        

        private void FrmRegistroPrestacionServicios_Load(object sender, EventArgs e)
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>
            {
                new TipoDocumento() { Id = 1, Nombre = "Cedula de Ciudadania" },
                new TipoDocumento() { Id = 2, Nombre = "NUIP" },
                new TipoDocumento() { Id = 3, Nombre = "Tarjeta de Extranjería" },
                new TipoDocumento() { Id = 4, Nombre = "Tarjeta de Identidad" }
            };

            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";


            List<TipoRango> tiposRango = new List<TipoRango>
            {
                new TipoRango() { Id = 1, Nombre = "A" },
                new TipoRango() { Id = 2, Nombre = "B" },
                new TipoRango() { Id = 3, Nombre = "C" }
            };

            cbRango.DataSource = tiposRango;
            cbRango.DisplayMember = "Nombre";
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCostoServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar campo solo numeros
            
                if (!((int)e.KeyChar == 8 || (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
        }

        private void BtnCalcularPago_Click(object sender, EventArgs e)
        {
            

            if (objetoControl.EsVacio(txtCostoServicio.Text) == true)
            {
                erpMensaje.SetError(txtCostoServicio, "El Costo del Servicio no puede ser vacio"); return;
            }
            else
            {
                erpMensaje.SetError(txtCostoServicio, "");
                DescuentoFinal= objetoControl.CalcularDescuento(cbRango.SelectedIndex, Convert.ToInt64(txtCostoServicio.Text));
                MessageBox.Show("El costo de servicio inicial es de: " + txtCostoServicio.Text + "\nEl valor de pago final es de: " + DescuentoFinal, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento.Text = "0";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombrePaciente.Text="";
            txtNumeroDocumento.Text = "0";
            txtCostoServicio.Text = "0";
        }

       
    }
}
