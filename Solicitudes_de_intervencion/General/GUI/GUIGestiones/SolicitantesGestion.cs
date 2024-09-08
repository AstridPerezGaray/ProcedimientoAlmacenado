using General.CLS;
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
    public partial class SolicitantesGestion : Form
    {
        BindingSource _Datos = new BindingSource();

        private void FiltrarRemotamente()
        {
            try
            {
                // Obtener el texto ingresado en el cuadro de texto de filtro
                string filtro = txtFiltro.Text.Trim();

                // Crear una instancia de Solicitante para realizar la búsqueda
                Solicitante solicitante = new Solicitante();
                DataTable resultados;

                // Filtrar los datos en función del texto ingresado
                if (string.IsNullOrEmpty(filtro))
                {
                    // Si no hay filtro, carga todos los datos
                    resultados = DataLayer.Consulta.Solicitudes();  // Asumiendo que este método carga todos los registros
                }
                else
                {
                    // Realizar la búsqueda en la base de datos
                    resultados = solicitante.Buscar(filtro);
                }

                // Actualizar el BindingSource con los resultados obtenidos
                _Datos.DataSource = resultados;
                dgvSolicitudes.AutoGenerateColumns = false;
                dgvSolicitudes.DataSource = _Datos;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void FiltrarLocalmente()
        {
            try
            {
                // Obtener el texto ingresado en el cuadro de texto de filtro
                string filtro = txtFiltro.Text.Trim();

                // Filtrar los datos en función del texto ingresado
                if (string.IsNullOrEmpty(filtro))
                {
                    _Datos.RemoveFilter();
                }
                else
                {
                    // Escapar comillas simples en el texto de filtro
                    string filtroEscapado = filtro.Replace("'", "''");

                    // Construir la expresión de filtro para filtrar por nombre de usuario
                    string filtroExpresion = $"Solicitante LIKE '%{filtroEscapado}%'";

                    // Aplicar el filtro
                    _Datos.Filter = filtroExpresion;
                }

                dgvSolicitudes.AutoGenerateColumns = false;
                dgvSolicitudes.DataSource = _Datos;
            }
            catch (Exception ex)
            {
                // Manejo básico de excepciones
                MessageBox.Show("Ocurrió un error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void Cargar()
        {
            try
            {
                _Datos.DataSource = DataLayer.Consulta.Solicitudes();
                dgvSolicitudes.DataSource = _Datos;
                dgvSolicitudes.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {}
        }
        public SolicitantesGestion()
        {
            InitializeComponent();
            Cargar();
        }
        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitantesEdicion E = new SolicitantesEdicion();
                E.ShowDialog();
                Cargar();
            }
            catch (Exception)
            {}
        }
        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            Cargar();
            //FiltrarLocalmente();
            FiltrarRemotamente();
            ContarEmpleados();
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar la solicitud?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SolicitantesEdicion solicitantes = new SolicitantesEdicion();
                    solicitantes.txtIDsolicitante.Text = dgvSolicitudes.CurrentRow.Cells["id_Solicitante"].Value.ToString();
                    solicitantes.txtSolicitante.Text = dgvSolicitudes.CurrentRow.Cells["Solicitante"].Value.ToString();
                    solicitantes.txtArea.Text = dgvSolicitudes.CurrentRow.Cells["Area"].Value.ToString();
                    solicitantes.txtDestinatario.Text = dgvSolicitudes.CurrentRow.Cells["Destinatario"].Value.ToString();
                    solicitantes.txtEquipo.Text = dgvSolicitudes.CurrentRow.Cells["Equipo"].Value.ToString();   
                    solicitantes.dTFecha.Text = dgvSolicitudes.CurrentRow.Cells["Fecha"].Value.ToString();
                    solicitantes.txtDetalle.Text = dgvSolicitudes.CurrentRow.Cells["Detalle"].Value.ToString();
                    solicitantes.ShowDialog();
                    Cargar();
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar la solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Solicitante f = new Solicitante();
                    f.Id = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["id_Solicitante"].Value.ToString());

                    if (f.Eliminar())
                    {
                        MessageBox.Show("solicitud eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La solicitud no puede ser eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cargar();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //FiltrarLocalmente();
            FiltrarRemotamente();
        }
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {        }
        private void ContarEmpleados()
        {
            int totalSolicitudes = dgvSolicitudes.RowCount;
            TotalSolicitudes.Text = totalSolicitudes.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {}
        private void label1_Click(object sender, EventArgs e)
        {}


    }
}
