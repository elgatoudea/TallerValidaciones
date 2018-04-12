namespace Taller_Validaciones
{
    partial class frmRegistroPrestacionServicios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroPrestacionServicios));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.gbServicio = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostoServicio = new System.Windows.Forms.TextBox();
            this.cbRango = new System.Windows.Forms.ComboBox();
            this.gbInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPrincipal.SuspendLayout();
            this.gbServicio.SuspendLayout();
            this.gbInformacionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.gbServicio);
            this.pnlPrincipal.Controls.Add(this.gbInformacionPaciente);
            this.pnlPrincipal.Controls.Add(this.btnCancelar);
            this.pnlPrincipal.Controls.Add(this.btnRegistrar);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(692, 312);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // gbServicio
            // 
            this.gbServicio.Controls.Add(this.label5);
            this.gbServicio.Controls.Add(this.label3);
            this.gbServicio.Controls.Add(this.txtCostoServicio);
            this.gbServicio.Controls.Add(this.cbRango);
            this.gbServicio.Location = new System.Drawing.Point(25, 138);
            this.gbServicio.Name = "gbServicio";
            this.gbServicio.Size = new System.Drawing.Size(643, 125);
            this.gbServicio.TabIndex = 20;
            this.gbServicio.TabStop = false;
            this.gbServicio.Text = "Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Rango";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Costo Servicio";
            // 
            // txtCostoServicio
            // 
            this.txtCostoServicio.Location = new System.Drawing.Point(307, 65);
            this.txtCostoServicio.Name = "txtCostoServicio";
            this.txtCostoServicio.Size = new System.Drawing.Size(176, 20);
            this.txtCostoServicio.TabIndex = 5;
            this.ttMensaje.SetToolTip(this.txtCostoServicio, "Este es el Costo del Servicio");
            // 
            // cbRango
            // 
            this.cbRango.FormattingEnabled = true;
            this.cbRango.Location = new System.Drawing.Point(307, 32);
            this.cbRango.Name = "cbRango";
            this.cbRango.Size = new System.Drawing.Size(176, 21);
            this.cbRango.TabIndex = 9;
            this.ttMensaje.SetToolTip(this.cbRango, "Seleccione el Rango deseado");
            // 
            // gbInformacionPaciente
            // 
            this.gbInformacionPaciente.Controls.Add(this.label1);
            this.gbInformacionPaciente.Controls.Add(this.txtNombrePaciente);
            this.gbInformacionPaciente.Controls.Add(this.label2);
            this.gbInformacionPaciente.Controls.Add(this.radioButton2);
            this.gbInformacionPaciente.Controls.Add(this.txtNumeroDocumento);
            this.gbInformacionPaciente.Controls.Add(this.radioButton1);
            this.gbInformacionPaciente.Controls.Add(this.label4);
            this.gbInformacionPaciente.Controls.Add(this.label6);
            this.gbInformacionPaciente.Controls.Add(this.cbTipoDocumento);
            this.gbInformacionPaciente.Location = new System.Drawing.Point(25, 14);
            this.gbInformacionPaciente.Name = "gbInformacionPaciente";
            this.gbInformacionPaciente.Size = new System.Drawing.Size(643, 118);
            this.gbInformacionPaciente.TabIndex = 19;
            this.gbInformacionPaciente.TabStop = false;
            this.gbInformacionPaciente.Text = "Información Personal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nombre del Paciente";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(136, 28);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(499, 20);
            this.txtNombrePaciente.TabIndex = 1;
            this.ttMensaje.SetToolTip(this.txtNombrePaciente, "Ingrese su Nombre Completo por favor");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de &Documento";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(227, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "&Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(459, 55);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(176, 20);
            this.txtNumeroDocumento.TabIndex = 3;
            this.ttMensaje.SetToolTip(this.txtNumeroDocumento, "Ingrese el número de su Documento");
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(136, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "&Femenino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Tipo de Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "&Sexo";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(136, 55);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(176, 21);
            this.cbTipoDocumento.TabIndex = 7;
            this.ttMensaje.SetToolTip(this.cbTipoDocumento, "Seleccione el Tipo de Documento");
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(360, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "&Cancelar";
            this.ttMensaje.SetToolTip(this.btnCancelar, "Cancelar el Registro de los datos, tenga en cuenta que este boton borrara los dat" +
        "os ingresados");
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(259, 276);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "&Registrar";
            this.ttMensaje.SetToolTip(this.btnRegistrar, "Registrar todos los datos ingresados");
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            this.erpMensaje.Icon = ((System.Drawing.Icon)(resources.GetObject("erpMensaje.Icon")));
            this.erpMensaje.RightToLeft = true;
            // 
            // frmRegistroPrestacionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 336);
            this.Controls.Add(this.pnlPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmRegistroPrestacionServicios";
            this.Text = "Registro de Prestación de Servicios";
            this.pnlPrincipal.ResumeLayout(false);
            this.gbServicio.ResumeLayout(false);
            this.gbServicio.PerformLayout();
            this.gbInformacionPaciente.ResumeLayout(false);
            this.gbInformacionPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.GroupBox gbServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCostoServicio;
        private System.Windows.Forms.ComboBox cbRango;
        private System.Windows.Forms.GroupBox gbInformacionPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}

