using System;
using System.Collections.Generic;
using System.Web.UI;
using CapaEntidades;
using CapaNegocios;

namespace RutasWeb
{
    public partial class Rutas : System.Web.UI.Page
    {
        private N_Ruta objNegocio = new N_Ruta();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRuta();
            }
        }

        private void CargarRuta()
        {
            try
            {
                bool? ATiempo = null;

                // Determinar filtro
                if (ddlFiltro.SelectedValue == "1")
                    ATiempo = true;
                else if (ddlFiltro.SelectedValue == "2")
                    ATiempo = false;

                //Obtener lista de rutas
                List<E_Ruta> lista = objNegocio.ListarRutas(ATiempo);

                // Asignar al GridView
                gvRuta.DataSource = lista;
                gvRuta.DataBind();

                // Mostrar mensaje si no hay datos
                if (lista == null || lista.Count == 0)
                {
                    MostrarMensaje("No se encontraron rutas con el filtro seleccionado", "info");
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

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/");
        }
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarRuta();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
           ddlFiltro.SelectedIndex = 0;
            CargarRuta();
        }

        private void MostrarMensaje(string mensaje, string tipo)
        {
            pnlMensaje.Visible = true;
            lblMensaje.Text = mensaje;
            pnlMensaje.CssClass = "info-mensaje " + tipo;
        }
    }
}