//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace CapaPresentacion
//{
//    public partial class FrmRutas : Form
//    {
//        public FrmRutas()
//        {
//            InitializeComponent();
//        }

//        private void FrmRutas_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class FrmRutas : Form
    {
        private N_Ruta objNegocio = new N_Ruta();
        private int idRutaSeleccionado = 0;
        private bool esNuevo = false;
        public FrmRutas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }
        private void FrmRutas_Load(object sender, EventArgs e)
        {
            //CargarTiposCamion();
            CargarFiltros();
            ListarRutas();
            BloquearControles();
        }

        private void ConfigurarDataGridView()
        {
            dgvRutas.AutoGenerateColumns = false;
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "IdRutas", HeaderText = "ID", Width = 50 });
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "IdChofer", HeaderText = "Chofer", Width = 100 });
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "IdCamion", HeaderText = "Camion", Width = 100 });
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Origen", HeaderText = "Origen", Width = 100 });
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Destino", HeaderText = "Destino", Width = 80 });
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "FechaSalida", HeaderText = "Fecha de Salida", Width = 100 });
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "FechaLlegada", HeaderText = "Fecha de Llegada", Width = 80 });
            dgvRutas.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Distancia", HeaderText = "Distancia", Width = 80 });
            dgvRutas.Columns.Add(new DataGridViewCheckBoxColumn
            { DataPropertyName = "ATiempo", HeaderText = "ATiempo", Width = 80 });
            //{ DataPropertyName = "Disponibilidad", HeaderText = "Disponible", Width = 80 });
        }
        private void ListarRutas()
        {
            try
            {
                bool? ATiempo=null;
                
                if (cboFiltro.SelectedIndex == 1) ATiempo = true;
                else if (cboFiltro.SelectedIndex == 2) ATiempo = false;
                
                
                    dgvRutas.DataSource = objNegocio.ListarRutas(ATiempo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);


            }
        }

        private void BloquearControles()
        {
            nudCamion.Enabled = false;
            nudChofer.Enabled = false;
            txtOrigen.Enabled = false;
            txtDestino.Enabled = false;
            dtpSalida.Enabled = false;
            dtpLlegada.Enabled = false;
            nudDistancia.Enabled = false;
            chkATiempo.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void DesbloquearControles()
        {
            nudCamion.Enabled = true;
            nudChofer.Enabled = true;
            txtOrigen.Enabled = true;
            txtDestino.Enabled = true;
            dtpSalida.Enabled = true;
            dtpLlegada.Enabled = true;
            nudDistancia.Enabled = true;
            chkATiempo.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimpiarControles()
        {
            

            nudCamion.Value = 0;
            nudChofer.Value = 0;
            txtOrigen.Clear();
            txtDestino.Clear();
            dtpSalida.Value = DateTime.Now;
            dtpLlegada.Value = DateTime.Now;
            nudDistancia.Value = 100;
            chkATiempo.Checked = true;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarControles();
            DesbloquearControles();
            nudCamion.Focus();
            nudChofer.Focus();
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarRutas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            BloquearControles();
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            esNuevo = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idRutaSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un camión de la lista", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            esNuevo = false;
            DesbloquearControles();
            //txtMatricula.Enabled = false; // No permitir cambiar la matrícula
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dgvRuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMatricula.Text = Convert.ToString(e.RowIndex);
            //txtMarca.Text = Convert.ToString(e.ColumnIndex);

            if (e.RowIndex > 0)
            {
                try
                {
                    DataGridViewRow fila = dgvRutas.Rows[e.RowIndex];

                    idRutaSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                    nudCamion.Value = Convert.ToInt32(fila.Cells[2].Value); 
                    nudChofer.Value = Convert.ToInt32(fila.Cells[1].Value);
                    txtOrigen.Text = fila.Cells[3].Value.ToString();
                    txtDestino.Text = fila.Cells[4].Value.ToString();
                    dtpSalida.Value = Convert.ToDateTime(fila.Cells[5].Value);
                    dtpLlegada.Value = Convert.ToDateTime(fila.Cells[6].Value);
                    nudDistancia.Value = Convert.ToInt32(fila.Cells[7].Value);
                    chkATiempo.Checked = Convert.ToBoolean(fila.Cells[8].Value);

                    // Cargar la foto si existe
                    //E_Camion camion = objNegocio.ObtenerCamionPorID(idCamionSeleccionado);
                    //if (camion != null)
                    //{
                    //    txtUrlFoto.Text = camion.UrlFoto ?? "";
                    //}

                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idRutaSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar una ruta de la lista", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar esta ruta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                string resultado = objNegocio.EliminarRuta(idRutaSeleccionado);

                if (resultado == "OK")
                {
                    MessageBox.Show("Ruta eliminada exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarRutas();
                    LimpiarControles();
                    BloquearControles();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MessageBox.Show(resultado, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarFiltros()
        {
            cboFiltro.Items.Clear();
            cboFiltro.Items.Add("Todas");
            cboFiltro.Items.Add("A Tiempo");
            cboFiltro.Items.Add("A Destiempo");
            cboFiltro.SelectedIndex = 0;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                //if (int.IsNullOrWhiteSpace(nudCamion.Value))
                //{
                //    MessageBox.Show("El chofer");
                //    txtNombre.Focus();
                //    return;
                //}



                //if (string.IsNullOrWhiteSpace(txtApPaterno.Text))
                //{
                //    MessageBox.Show("El apellido paterno es obligatorio", "Validación",
                //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtApPaterno.Focus();
                //    return;
                //}

                // Crear objeto Ruta
                E_Ruta ruta = new E_Ruta 
                { 
                    IdRutas = idRutaSeleccionado,
                    IdCamion = (int)nudCamion.Value,
                    IdChofer = (int)nudChofer.Value,
                    Origen = txtOrigen.Text.Trim(),
                    Destino = txtDestino.Text.Trim(),
                    FechaSalida = (DateTime)dtpSalida.Value,
                    FechaLlegada = (DateTime)dtpLlegada.Value,
                    Distancia = (int)nudDistancia.Value,

                    ATiempo = chkATiempo.Checked,
                   
                };

                string resultado;

                if (esNuevo)
                {
                    resultado = objNegocio.InsertarRuta(ruta);
                }
                else
                {
                    resultado = objNegocio.ActualizarRuta(ruta);
                }

                if (resultado == "OK")
                {
                    MessageBox.Show(
                        esNuevo ? "ruta registrada exitosamente" : "Ruta actualizada exitosamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ListarRutas();
                    LimpiarControles();
                    BloquearControles();
                    btnNuevo.Enabled = true;
                    esNuevo = false;
                }
                else
                {
                    MessageBox.Show(resultado, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Implementar los demás métodos: BloquearControles, LimpiarControles, etc.
    }
}
