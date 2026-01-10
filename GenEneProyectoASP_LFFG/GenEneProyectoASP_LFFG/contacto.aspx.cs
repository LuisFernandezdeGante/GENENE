using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contacto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //recuperacion de los datos mandados en el formulario
        string from = Request.Form["contact_email"].ToString();
        string nombre = Request.Form["contact_name"].ToString();
        string personas = Request.Form["contact_personas"].ToString();
        string extra = Request.Form["contact_adicionales"].ToString();
        string fecha = Request.Form["contact_fecha"].ToString();
        string hora = Request.Form["contact_hora"].ToString();
        string subject = nombre + " Fecha: " + fecha + ". Hora: " + hora + ". Personas: " + (int.Parse(personas) + int.Parse(extra)).ToString();
        string mensaje = "El cliente " + nombre + "ha realizado una reservacion para el dia: " + " Fecha: " + fecha + " a las: " + hora + " hrs para " +
"Personas: " + (int.Parse(personas) + int.Parse(extra)).ToString();
        //string resultado = sendGmail(from, subject, mensaje);
        //Estatus.Text = resultado;
        //redireccionar a http:localhost:789/Default.aspx?Id=2

        Response.Write("<script>alert('RESERVACION CREADA'); window.location='/Default.aspx?Id=2';</script>");

        //Response.Redirect("/Default.aspx?Id=2");

    }
    }
