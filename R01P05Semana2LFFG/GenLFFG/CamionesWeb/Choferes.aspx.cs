using CamionesWeb;
using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChoferesWeb
{
    public partial class Choferes : System.Web.UI.Page
    {
        private N_Chofer objNegocio = new N_Chofer();
        private object txtFechaN;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarChoferes(); 
                
                BloquearControles();
                
            }
        }

        private void CargarChoferes()
        {
            try
            {
                bool? disponibilidad = null;

                // Determinar filtro
                if (ddlFiltro.SelectedValue == "1")
                    disponibilidad = true;
                else if (ddlFiltro.SelectedValue == "2")
                    disponibilidad = false;

                // Obtener lista de camiones
                List<E_Chofer> lista = objNegocio.ListarChoferes(disponibilidad);

                // Asignar al GridView
                gvChofer.DataSource = lista;
                gvChofer.DataBind();

                // Mostrar mensaje si no hay datos
                if (lista == null || lista.Count == 0)
                {
                    MostrarMensaje("No se encontraron choferes con el filtro seleccionado", "info");
                }
                else
                {
                    pnlMensaje.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al cargar camiones: " + ex.Message, "error");
            }
        }


        private int idChoferSeleccionado
        {
            get { return ViewState["idChoferSeleccionado"] != null ? (int)ViewState["idChoferSeleccionado"] : 0; }
            set { ViewState["idChoferSeleccionado"] = value; }
        }

        private bool esNuevo
        {
            get { return ViewState["esNuevo"] != null ? (bool)ViewState["esNuevo"] : false; }
            set { ViewState["esNuevo"] = value; }
        }

        

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarChoferes();
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ddlFiltro.SelectedIndex = 0;
            CargarChoferes();
        }

        private void MostrarMensaje(string mensaje, string tipo)
        {
            pnlMensaje.Visible = true;
            lblMensaje.Text = mensaje;
            pnlMensaje.CssClass = "info-mensaje " + tipo;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            

            esNuevo = true;
            LimpiarControles();
            DesbloquearControles();
            txtNombre.Focus();
            //btnNuevo.Enabled = false;
            //btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;

            //btnNuevo.Enabled = false;
            //btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;


        }

        private void BloquearControles()
        {
            txtNombre.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;
            txtTelefono.Enabled = false;
            txtFechaNacimiento.Enabled = false;
            txtLicencia.Enabled = false;
            txtUrlFoto.Enabled = false;
            chkDisponibilidad.Enabled = false;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void DesbloquearControles()
        {
            txtNombre.Enabled = true;
            txtApPaterno.Enabled = true;
            txtApMaterno.Enabled = true;
            txtTelefono.Enabled = true;
            txtFechaNacimiento.Enabled = true;
            txtLicencia.Enabled = true;
            txtUrlFoto.Enabled = true;
            chkDisponibilidad.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void LimpiarControles()
        {
            idChoferSeleccionado = 0;
            txtNombre.Text=string.Empty;
            txtApPaterno.Text = string.Empty;
            txtApMaterno.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtFechaNacimiento.Text = DateTime.Now.Year.ToString();
            txtLicencia.Text = string.Empty;
            txtUrlFoto.Text = string.Empty;
            chkDisponibilidad.Checked = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtFechaNacimiento.Text))
                {
                    MostrarMensaje("La fecha de nacimiento es obligatoria", "warning");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MostrarMensaje("El nombre es obligatorio", "warning");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApPaterno.Text))
                {
                    MostrarMensaje("El apellido paterno es obligatorio", "warning");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtApMaterno.Text))
                {
                    MostrarMensaje("El apellido materno es obligatorio", "warning");
                    return;
                }


                // Crear objeto E_Chofer
                E_Chofer chofer = new E_Chofer
                {
                   
                    IdChofer = idChoferSeleccionado,
                    Nombre = txtNombre.Text.Trim().ToUpper(),
                    ApPaterno = txtApPaterno.Text.Trim(),
                    ApMaterno = txtApMaterno.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                    Licencia = txtLicencia.Text.Trim(),

                    Disponibilidad = chkDisponibilidad.Checked,
                    UrlFoto = txtUrlFoto.Text.Trim()
                };


                // Guardar o actualizar
                string resultado = esNuevo ?
                    objNegocio.InsertarChofer(chofer) :
                    objNegocio.ActualizarChofer(chofer);

                


                    if (resultado == "Ok" || resultado == "OK")
                {
                    MostrarMensaje(
                        esNuevo ? " Chofer registrado exitosamente" : " Chofer actualizado exitosamente",
                        "success"
                    );

                    CargarChoferes();
                    LimpiarControles();
                    BloquearControles();
                    btnNuevo.Enabled = true;
                    esNuevo = false;
                }
                else
                {
                    MostrarMensaje(resultado, "danger");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al guardar: " + ex.Message, "danger");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (idChoferSeleccionado == 0)
            {
                MostrarMensaje(" Debe seleccionar un chofer de la lista", "warning");
                return;
            }

            esNuevo = false;
            DesbloquearControles();
            //btnNuevo.Enabled = false;
            //btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;

            MostrarMensaje("Modifique los datos y presione Guardar", "info");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idChoferSeleccionado == 0)
            {
                MostrarMensaje(" Debe seleccionar un camión de la lista", "warning");
                return;
            }

            try
            {
                string resultado = objNegocio.EliminarChofer(idChoferSeleccionado);

                if (resultado == "Ok" || resultado == "OK")
                {
                    MostrarMensaje(" Chofer eliminado exitosamente", "success");
                    CargarChoferes();
                    LimpiarControles();
                    BloquearControles();
                    btnNuevo.Enabled = true;
                }
                else
                {
                    MostrarMensaje(resultado, "danger");
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al eliminar: " + ex.Message, "danger");
            }
        }


        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            BloquearControles();
            btnNuevo.Enabled = true;
            //esNuevo = false;
            
        }

        public void gvChoferes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Seleccionar")
            {
                try
                {
                    int rowIndex = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = gvChofer.Rows[rowIndex];

                    idChoferSeleccionado = Convert.ToInt32(row.Cells[1].Text);
                    txtNombre.Text = row.Cells[2].Text.ToString();
                    txtApPaterno.Text = row.Cells[3].Text.ToString();
                    txtApMaterno.Text = row.Cells[4].Text.ToString();
                    txtTelefono.Text = row.Cells[5].Text.ToString();
                    //txtFechaNacimiento.Text = DateTime.Parse(row.Cells[5].Text).ToString();
                    txtLicencia.Text = row.Cells[6].Text.ToString();
                    //chkDisponibilidad.Checked = Convert.ToBoolean(row.Cells[7].Text);

                    // Obtener disponibilidad del badge
                    var disponibilidadCell = row.Cells[7];
                    chkDisponibilidad.Checked = disponibilidadCell.Text.Contains("Disponible") &&
                                                !disponibilidadCell.Text.Contains("No Disponible");
                }
                //    // Cargar datos completos del camión
                //    E_Camion camion = objNegocio.ObtenerChoferPorId(idChoferSeleccionado);
                //    if (camion != null)
                //    {
                //        txtUrlFoto.Text = camion.UrlFoto ?? "";
                //    }

                //    btnModificar.Enabled = true;
                //    btnEliminar.Enabled = true;

                //    MostrarMensaje(" Camión seleccionado. Puede Modificar o Eliminar.", "info");
                //}
                catch (Exception ex)
                {
                    MostrarMensaje("Error al seleccionar: " + ex.Message, "danger");
                }
            }
        }
    }
}

    
