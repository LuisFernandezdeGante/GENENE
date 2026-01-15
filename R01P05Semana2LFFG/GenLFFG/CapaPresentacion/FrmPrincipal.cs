using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de Gestion de Camiones y Rutas -GenE";
        }

        private void mnuGestionarCamiones_Click(object sender, EventArgs e)
        {
            //FrmCamiones frm = new FrmCamiones();
            FrmCamiones frm = new FrmCamiones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuGestionarChoferes_Click(object sender, EventArgs e)
        {
            FrmChoferes frm = new FrmChoferes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuGestionarRutas_Click(object sender, EventArgs e)
        {
            FrmRutas frm = new FrmRutas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if ( result== DialogResult.Yes )
            {
                Application.Exit();
            }
        }
    }
}
