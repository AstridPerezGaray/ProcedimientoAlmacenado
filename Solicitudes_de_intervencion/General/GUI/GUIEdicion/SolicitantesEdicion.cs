using DataLayer;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class SolicitantesEdicion : Form
    {
        BindingSource _Datos = new BindingSource();
       
        private Boolean Validar()
        {
            Boolean Valido = true;
            try
            {
                if (txtSolicitante.Text.Trim().Length == 0)
                {
                    //valida que los campos no queden vacios
                    notificador.SetError(txtSolicitante, "Este campo no puede quedar vacio");
                    Valido = false;
                }
            }
            catch (Exception ex)
            {
                Valido = false;
            }
            return Valido;
        }
        public SolicitantesEdicion()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {}
        private void EmpleadosEdicion_Load(object sender, EventArgs e)
        {
           
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    CLS.Solicitante oSolicitante = new CLS.Solicitante();
                    try
                    {
                        oSolicitante.Id = Convert.ToInt32(txtIDsolicitante.Text);
                    }
                    catch (Exception)
                    {
                        
                    }
                    //asinga los datos que estan en las cajas de texto a la variable de la clase empleados creda
                        
                        oSolicitante.Solicitante1 = txtSolicitante.Text;
                        oSolicitante.Area1 = txtArea.Text;
                        oSolicitante.Destinatario = txtDestinatario.Text;
                        oSolicitante.Equipo1 = txtEquipo.Text;
                        oSolicitante.Fecha1 = dTFecha.Value;
                        oSolicitante.Detalle1 = txtDetalle.Text;

                    if (txtIDsolicitante.Text.Trim().Length == 0)
                    {
                        //GUARDAR NUEVO 
                            if (oSolicitante.Insertar()) // llama al metodo insertar empleado
                            {
                                Close();
                                MessageBox.Show("Registro Guardado");
                            }
                            else
                            {
                                MessageBox.Show("El registro no pude ser almacenado");
                            }                         
                    }
                    else
                    { //ACTUALIZAR REGISTRO
                        if (oSolicitante.Actualizar())
                        {
                            MessageBox.Show("Registro Actualizado");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no pude ser actualizado");
                        }
                    }
                }
            }catch(Exception ex)
            { }
        }
        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
