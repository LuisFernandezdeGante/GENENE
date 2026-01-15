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
//    public partial class FrmChoferes : Form
//    {
//        public FrmChoferes()
//        {
//            InitializeComponent();
//        }

//        private void FrmChoferes_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}


//PRUEBA----------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class FrmChoferes : Form
    {
        private N_Chofer objNegocio = new N_Chofer();
        private int idChoferSeleccionado = 0;
        private bool esNuevo = false;
        public FrmChoferes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }
        private void FrmChoferes_Load(object sender, EventArgs e)
        {
            
            CargarFiltros();
            ListarChoferes();
            BloquearControles();
        }

        private void ConfigurarDataGridView()
        {
            dgvChoferes.AutoGenerateColumns = false;
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "IdChofer", HeaderText = "ID", Width = 50 });
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Nombre", HeaderText = "Nombre", Width = 100 });
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "ApPaterno", HeaderText = "Apellido Paterno", Width = 100 });
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "ApMaterno", HeaderText = "Apellido Materno", Width = 100 });
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Telefono", HeaderText = "Telefono", Width = 80 });
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "FechaNacimiento", HeaderText = "Fecha de Nacimiento", Width = 100 });
            dgvChoferes.Columns.Add(new DataGridViewCheckBoxColumn
            { DataPropertyName = "Disponibilidad", HeaderText = "Disponible", Width = 80 });
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Licencia", HeaderText = "Licencia", Width = 50 });
            dgvChoferes.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "UrlFoto", HeaderText = "URL", Width = 50 });
            //{ DataPropertyName = "Disponibilidad", HeaderText = "Disponible", Width = 80 });
        }
        private void ListarChoferes()
        {
            try
            {
                bool? disponibilidad = null;
                if (cboFiltro.SelectedIndex == 1) disponibilidad = true;
                else if (cboFiltro.SelectedIndex == 2) disponibilidad = false;
                dgvChoferes.DataSource = objNegocio.ListarChoferes(disponibilidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);


            }
        }

        private void BloquearControles()
        {
            txtNombre.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;
            txtTelefono.Enabled = false;
            dtmFechaNacimiento.Enabled = false;
            txtLicencia.Enabled = false;
            txtUrlFoto.Enabled = false;
            chkDisponibilidad.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void DesbloquearControles()
        {
            txtNombre.Enabled = true;
            txtApPaterno.Enabled = true;
            txtApMaterno.Enabled = true;
            txtTelefono.Enabled = true;
            dtmFechaNacimiento.Enabled = true;
            txtLicencia.Enabled = true;
            txtUrlFoto.Enabled = true;
            chkDisponibilidad.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimpiarControles()
        {
            idChoferSeleccionado = 0;
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtTelefono.Clear();
            dtmFechaNacimiento.Value = DateTime.Now;
            txtLicencia.Clear();
            txtUrlFoto.Clear();
            chkDisponibilidad.Checked = false;
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarControles();
            DesbloquearControles();
            txtNombre.Focus();
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarChoferes();
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
            if (idChoferSeleccionado == 0)
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

        private void dgvChofer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMatricula.Text = Convert.ToString(e.RowIndex);
            //txtMarca.Text = Convert.ToString(e.ColumnIndex);

            if (e.RowIndex > 0)
            {
                try
                {
                    DataGridViewRow row = dgvChoferes.Rows[e.RowIndex];

                    idChoferSeleccionado = Convert.ToInt32(row.Cells[0].Value);
                    txtNombre.Text = row.Cells[1].Value.ToString();
                    txtApPaterno.Text = row.Cells[2].Value.ToString();
                    txtApMaterno.Text = row.Cells[3].Value.ToString();
                    txtTelefono.Text = row.Cells[4].Value.ToString();
                    dtmFechaNacimiento.Value = Convert.ToDateTime(row.Cells[5].Value);
                    txtLicencia.Text = row.Cells[7].Value.ToString();
                    chkDisponibilidad.Checked = Convert.ToBoolean(row.Cells[6].Value);


                    // Obtener disponibilidad del badge
                    //var disponibilidadCell = row.Cells[8];
                    //chkDisponibilidad.Checked = disponibilidadCell.Value.Equals("Disponible") &&
                    //                            !disponibilidadCell.Value.Equals("No Disponible");

                    
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
            if (idChoferSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un camión de la lista", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar este camión?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                string resultado = objNegocio.EliminarChofer(idChoferSeleccionado);

                if (resultado == "OK")
                {
                    MessageBox.Show("Camión eliminado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarChoferes();
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
            cboFiltro.Items.Add("Todos");
            cboFiltro.Items.Add("Disponibles");
            cboFiltro.Items.Add("No disponibles");
            cboFiltro.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio");
                    txtNombre.Focus();
                    return;
                }

                

                if (string.IsNullOrWhiteSpace(txtApPaterno.Text))
                {
                    MessageBox.Show("El apellido paterno es obligatorio", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApPaterno.Focus();
                    return;
                }

                // Crear objeto Chofer
                E_Chofer chofer = new E_Chofer
                {
                    IdChofer = idChoferSeleccionado,
                    Nombre = txtNombre.Text.Trim().ToUpper(),
                    ApPaterno = txtApPaterno.Text.Trim(),
                    ApMaterno = txtApMaterno.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    FechaNacimiento = (DateTime)dtmFechaNacimiento.Value,
                    Licencia = txtLicencia.Text.Trim(),

                    Disponibilidad = chkDisponibilidad.Checked,
                    UrlFoto = txtUrlFoto.Text.Trim()
                };

                string resultado;

                if (esNuevo)
                {
                    resultado = objNegocio.InsertarChofer(chofer);
                }
                else
                {
                    resultado = objNegocio.ActualizarChofer(chofer);
                }

                if (resultado == "OK")
                {
                    MessageBox.Show(
                        esNuevo ? "Chofer registrado exitosamente" : "Chofer actualizado exitosamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ListarChoferes();
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