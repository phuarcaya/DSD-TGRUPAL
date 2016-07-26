using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS_Produccion;
using WS_ProduccionUtilitario;

namespace Prototipo1.View
{
    public partial class Aprobar_Orden_Trabajo : frmReporte
    {
        protected WSOrdenesTrabajos.OrdenTrabajosClient Proxy = new WSOrdenesTrabajos.OrdenTrabajosClient();

        public Aprobar_Orden_Trabajo()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void Aprobar_Orden_Trabajo_Load(object sender, EventArgs e)
        {
            WSConsultasGenerales.ParametroDetallesClient proxy = new WSConsultasGenerales.ParametroDetallesClient();
            var resultado = proxy.ListarParametroDetalle(EParametro.EstadoOrdenTrabajo.GetHashCode());
            List<ParametroDetalle> lista = new List<ParametroDetalle>();
            resultado.ToList().ForEach(x =>
            {
                if (x.Id == EEstadoOrdenTrabajo.Pendiente.GetHashCode() ||
                    x.Id == EEstadoOrdenTrabajo.Aprobado.GetHashCode())
                {
                    lista.Add(x);
                }
            });

            cboEstado.DataSource = lista;
            cboEstado.DisplayMember = "Descripcion";
            cboEstado.ValueMember = "Id";

            ListarDatos();
        }

        private void ActualizarEstadoOrdenTrabajo(int idEstado)
        {
            List<OrdenTrabajo> objOrdenTrabajo = new List<OrdenTrabajo>();
            foreach (DataGridViewRow row in dgvListados.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Sel"].Value))
                {
                    int idOrdenTrabajo = Int32.Parse(row.Cells["Id"].Value.ToString());
                    Proxy.ModificarEstado(idOrdenTrabajo, idEstado);
                }
            }
        }

        private void ListarDatos()
        {
            BindingSource BindingSource = new System.Windows.Forms.BindingSource();
            BindingSource.DataSource = Proxy.listarOrd(cboEstado.SelectedValue.ToString());
            BindingNavigator.BindingSource = BindingSource;

            dgvListados.AutoGenerateColumns = false;
            dgvListados.DataSource = BindingNavigator.BindingSource;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            ActualizarEstadoOrdenTrabajo(EEstadoOrdenTrabajo.Aprobado.GetHashCode());
            ListarDatos();
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            ActualizarEstadoOrdenTrabajo(EEstadoOrdenTrabajo.Pendiente.GetHashCode());
            ListarDatos();
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }
    }
}
