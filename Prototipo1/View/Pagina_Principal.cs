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
            Orden_Trabajo OT = new Orden_Trabajo();
            OT.MdiParent = this;
            OT.Show();
        }

        private void aprobarOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aprobar_Orden_Trabajo OT = new Aprobar_Orden_Trabajo();
            OT.MdiParent = this;
            OT.Show();
        }

        private void reporteEficienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEficiencia OT = new ReporteEficiencia();
            OT.MdiParent = this;
            OT.Show();
        }

        private void ingresarProductosTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoProducto OT = new IngresoProducto();
            OT.MdiParent = this;
            OT.Show();
        }

        private void salidaDeMAteriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalidaAlmacen OT = new SalidaAlmacen();
            OT.MdiParent = this;
            OT.Show();
        }

        public static implicit operator Pagina_Principal(SalidaAlmacen v)
        {
            throw new NotImplementedException();
        }
    }
    
}
