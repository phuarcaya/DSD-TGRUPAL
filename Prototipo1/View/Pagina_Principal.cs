using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1.View
{
    public partial class Pagina_Principal : Form
    {
        public Pagina_Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grupoNeptunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo Urano del Curso de Sistemas Distribuidos");
        }

        private void generarOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden_Trabajo form = new Orden_Trabajo();
            form.TituloFormulario = "Orden de Trabajo";
            AbrirFormulario(form);
        }

        private void aprobarOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aprobar_Orden_Trabajo form = new Aprobar_Orden_Trabajo();
            form.TituloFormulario = "Aprobación Orden de Trabajo";
            AbrirFormulario(form);
        }

        private void reporteEficienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEficiencia form = new ReporteEficiencia();
            form.TituloFormulario = "Eficiencia Orden de Trabajo";
            AbrirFormulario(form);
        }

        private void ingresarProductosTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimiento form = new Movimiento();
            form.TituloFormulario = "Ingreso de Producto Terminado";
            form.TipoMovimiento = Movimiento.eTipoMovimiento.IngresoProductoTerminado;
            AbrirFormulario(form);
        }

        private void salidaDeMAteriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimiento form = new Movimiento();
            form.TituloFormulario = "Salida de Materia Prima";
            form.TipoMovimiento = Movimiento.eTipoMovimiento.SalidaMateriales;
            AbrirFormulario(form);
        }

        private void Pagina_Principal_Load(object sender, EventArgs e)
        {
            frmLogin Result = new frmLogin();
            if (Result.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                Application.Exit();
            }
            Result = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de cerrar la aplicación ???", Funciones.Insfor_NombreEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AbrirFormulario(Form Formulario)
        {
            Formulario.MdiParent = this;
            Formulario.StartPosition = FormStartPosition.CenterScreen;
            Formulario.WindowState = FormWindowState.Maximized;
            Formulario.Width = 850;
            Formulario.Height = 550;
            Formulario.Show();
            Formulario = null;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            generarOTToolStripMenuItem_Click(sender, e);
        }

        private void btnCronograma_Click(object sender, EventArgs e)
        {
            salidaDeMAteriaPrimaToolStripMenuItem_Click(sender, e);
        }

        private void btnTramites_Click(object sender, EventArgs e)
        {
            aprobarOTToolStripMenuItem_Click(sender, e);
        }

        private void btnRus_Click(object sender, EventArgs e)
        {
            ingresarProductosTerminadosToolStripMenuItem_Click(sender, e);
        }

        private void btnEspacial_Click(object sender, EventArgs e)
        {
            reporteEficienciaToolStripMenuItem_Click(sender, e);
        }

    }
    
}
