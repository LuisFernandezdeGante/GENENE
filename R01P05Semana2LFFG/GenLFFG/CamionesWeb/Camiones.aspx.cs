using System;
using System.Collections.Generic;
using System.Web.UI;
using CapaEntidades;
using CapaNegocios;

namespace CamionesWeb
{
    public partial class Camiones : System.Web.UI.Page
    {
        private N_Camion objNegocio = new N_Camion();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCamiones();
            }
        }

        private void CargarCamiones()
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
                List<E_Camion> lista = objNegocio.ListarCamiones(disponibilidad);

                // Asignar al GridView
                gvCamion.DataSource = lista;
                gvCamion.DataBind();

                // Mostrar mensaje si no hay datos
                if (lista == null || lista.Count == 0)
                {
                    MostrarMensaje("No se encontraron camiones con el filtro seleccionado", "info");
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

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarCamiones();
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ddlFiltro.SelectedIndex = 0;
            CargarCamiones();
        }

        private void MostrarMensaje(string mensaje, string tipo)
        {
            pnlMensaje.Visible = true;
            lblMensaje.Text = mensaje;
            pnlMensaje.CssClass = "info-mensaje " + tipo;
        }

        //private void btnNuevo_Click(object sender, EventArgs e)
        //{
        //    ////esNuevo = true;
        //    //LimpiarControles();
        //    //DesbloquearControles();
        //    ////txtMatricula.Focus();
        //    ////btnNuevo.Enabled = false;
        //    //btnModificar.Enabled = false;
        //    //btnEliminar.Enabled = false;
        //}

        //private void BloquearControles()
        //{
        //    //txtMatricula.Enabled = false;
        //    //cboTipoCamion.Enabled = false;
        //    //nudModelo.Enabled = false;
        //    //txtMarca.Enabled = false;
        //    //nudCapacidad.Enabled = false;
        //    //nudKilometraje.Enabled = false;
        //    //txtUrlFoto.Enabled = false;
        //    //chkDisponibilidad.Enabled = false;

        //    //btnGuardar.Enabled = false;
        //    //btnCancelar.Enabled = false;
        //    //btnModificar.Enabled = false;
        //    //btnEliminar.Enabled = false;
        //}



    }
}


