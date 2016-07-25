using Prototipo1.WSOrdenesTrabajos;
using SISCO.Presentacion.IU;
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
    public partial class BuscarOrdenesTrabajo : frmBuscador
    {
        public string idsEstadoOrdenTrabajo { get; set; }
        private List<OrdenTrabajo> Resultado { get; set; }
        public DataView dvResultado;

        public BuscarOrdenesTrabajo()
        {
            InitializeComponent();
        }

        private void BuscarOrdenesTrabajo_Load(object sender, EventArgs e)
        {
            WSOrdenesTrabajos.OrdenTrabajosClient Proxy = new OrdenTrabajosClient();
            Resultado = Proxy.listarOrd(idsEstadoOrdenTrabajo).ToList();
            dgvBusqueda.AutoGenerateColumns = false;
            dgvBusqueda.DataSource = Resultado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            List<OrdenTrabajo> objOrdenTrabajo = new List<OrdenTrabajo>();
            foreach (DataGridViewRow row in dgvBusqueda.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Sel"].Value))
                {
                    int idArticulo = Int32.Parse(row.Cells["Id"].Value.ToString());
                    objOrdenTrabajo.Add(Resultado.Where(x => x.Id == idArticulo).FirstOrDefault());
                    break;
                }
            }

            if (objOrdenTrabajo.Count > 0)
            {
                dvResultado = Funciones.convertToDataTable(objOrdenTrabajo).DefaultView;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                lblError.Text = "Seleccione registro.";
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
