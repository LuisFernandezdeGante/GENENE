
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class FrmCamiones : Form
    {
        private N_Camion objNegocio = new N_Camion();
        private int idCamionSeleccionado = 0;
        private bool esNuevo = false;
        public FrmCamiones()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }
        private void FrmCamiones_Load(object sender, EventArgs e)
        {
            CargarTiposCamion();
            CargarFiltros();
            ListarCamiones();
            BloquearControles();
        }

        private void ConfigurarDataGridView()
        {
            dgvCamiones.AutoGenerateColumns = false;
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "IdCamion", HeaderText = "IdCamion", Width = 50 });
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Matricula", HeaderText = "Matrícula", Width = 100 });
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "TipoCamion", HeaderText = "Tipo", Width = 100 });
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Marca", HeaderText = "Marca", Width = 100 });
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Modelo", HeaderText = "Modelo", Width = 80 });
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Capacidad", HeaderText = "Capacidad", Width = 100 });
            dgvCamiones.Columns.Add(new DataGridViewCheckBoxColumn
            { DataPropertyName = "Disponibilidad", HeaderText = "Disponible", Width = 80 });
            //{ DataPropertyName = "Disponibilidad", HeaderText = "Disponible", Width = 80 });
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "Kilometraje", HeaderText = "Kilometraje", Width = 100 });
            dgvCamiones.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = "UrlFoto", HeaderText = "UrlFoto", Width = 100 });


        }
        private void ListarCamiones()
        {
            try
            {
                bool? disponibilidad = null;
                if (cboFiltro.SelectedIndex == 1) disponibilidad = true;
                else if (cboFiltro.SelectedIndex == 2) disponibilidad = false;
                dgvCamiones.DataSource = objNegocio.ListarCamiones(disponibilidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);


            }
        }
        
        private void CargarTiposCamion()
        {
            cboTipoCamion.Items.Clear();
            cboTipoCamion.Items.Add("Rigido");
            cboTipoCamion.Items.Add("Articulado");
            cboTipoCamion.Items.Add("Trailer");
            cboTipoCamion.Items.Add("Tanque");
            cboTipoCamion.Items.Add("Plataforma");
            cboTipoCamion.Items.Add("Remolque");
        }

        private void CargarFiltros()
        {
            cboFiltro.Items.Clear();
            cboFiltro.Items.Add("Todos");
            cboFiltro.Items.Add("Disponibles");
            cboFiltro.Items.Add("No disponibles");
            cboFiltro.SelectedIndex = 0;
        }


        private void BloquearControles()
        {
            txtMatricula.Enabled = false;
            cboTipoCamion.Enabled = false;
            nudModelo.Enabled = false;
            txtMarca.Enabled = false;
            nudCapacidad.Enabled = false;
            nudKilometraje.Enabled = false;
            txtUrlFoto.Enabled = false;
            chkDisponibilidad.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void DesbloquearControles()
        {
            txtMatricula.Enabled = true;
            cboTipoCamion.Enabled = true;
            nudModelo.Enabled = true;
            txtMarca.Enabled = true;
            nudCapacidad.Enabled = true;
            nudKilometraje.Enabled = true;
            txtUrlFoto.Enabled = true;
            chkDisponibilidad.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimpiarControles()
        {
            idCamionSeleccionado = 0;
            txtMatricula.Clear();
            cboTipoCamion.SelectedIndex = -1;
            nudModelo.Value = DateTime.Now.Year;
            txtMarca.Clear();
            nudCapacidad.Value = 5000;
            nudKilometraje.Value = 0;
            txtUrlFoto.Clear();
            chkDisponibilidad.Checked = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarControles();
            DesbloquearControles();
            txtMatricula.Focus();
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarCamiones();
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
            if (idCamionSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un camión de la lista", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            esNuevo = false;
            DesbloquearControles();
            txtMatricula.Enabled = false; // No permitir cambiar la matrícula
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }



        private void dgvCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMatricula.Text = Convert.ToString(e.RowIndex);
            //txtMarca.Text = Convert.ToString(e.ColumnIndex );

            if (e.RowIndex > 0)
            {
                try
                {
                    DataGridViewRow fila = dgvCamiones.Rows[e.RowIndex];

                    idCamionSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                    txtMatricula.Text = fila.Cells[1].Value.ToString();
                    cboTipoCamion.Text = fila.Cells[2].Value.ToString();
                    nudModelo.Value = Convert.ToInt32(fila.Cells[4].Value);
                    txtMarca.Text = fila.Cells[3].Value.ToString();
                    nudCapacidad.Value = Convert.ToInt32(fila.Cells[5].Value);
                    //nudKilometraje.Value = Convert.ToDecimal(fila.Cells[6].Value);
                    chkDisponibilidad.Checked = Convert.ToBoolean(fila.Cells[6].Value);

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtMatricula.Text))
                {
                    MessageBox.Show("La matrícula es obligatoria", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatricula.Focus();
                    return;
                }

                if (cboTipoCamion.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de camión", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTipoCamion.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    MessageBox.Show("La marca es obligatoria", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMarca.Focus();
                    return;
                }

                // Crear objeto Camion
                E_Camion camion = new E_Camion
                {
                    IdCamion = idCamionSeleccionado,
                    Matricula = txtMatricula.Text.Trim().ToUpper(),
                    TipoCamion = cboTipoCamion.Text,
                    Modelo = (int)nudModelo.Value,
                    Marca = txtMarca.Text.Trim(),
                    Capacidad = (int)nudCapacidad.Value,
                    Kilometraje = (double)nudKilometraje.Value,

                    Disponibilidad = chkDisponibilidad.Checked,
                    UrlFoto = txtUrlFoto.Text.Trim()
                };

                string resultado;

                if (esNuevo)
                {
                    resultado = objNegocio.InsertarCamion(camion);
                }
                else
                {
                    resultado = objNegocio.ActualizarCamion(camion);
                }

                if (resultado == "OK")
                {
                    MessageBox.Show(
                        esNuevo ? "Camión registrado exitosamente" : "Camión actualizado exitosamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ListarCamiones();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCamionSeleccionado == 0)
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
                string resultado = objNegocio.EliminarCamion(idCamionSeleccionado);

                if (resultado == "OK")
                {
                    MessageBox.Show("Camión eliminado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarCamiones();
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

    }
}

