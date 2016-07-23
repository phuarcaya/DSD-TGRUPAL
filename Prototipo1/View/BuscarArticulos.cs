using Prototipo1.WSArticulos;
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

namespace Prototipo1.View
{
    public partial class BuscarArticulos : frmBuscador
    {
        public string TipoExistencia { get; set; }
        private List<Articulo> Resultado { get; set; }
        public DataView dvArticulos;
        public BuscarArticulos()
        {
            InitializeComponent();
        }

        private void BuscarArticulos_Load(object sender, EventArgs e)
        {
            WSArticulos.ArticulosClient Proxy = new ArticulosClient();
            Resultado = Proxy.ListarArticulos(TipoExistencia).ToList();
            dgvBusqueda.AutoGenerateColumns = false;
            dgvBusqueda.DataSource = Resultado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Articulo> articuloList = new List<Articulo>();
            lblError.Text = string.Empty;
            foreach (DataGridViewRow row in dgvBusqueda.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Sel"].Value))
                {
                    Articulo objArticulo = new Articulo();
                    int idArticulo = Int32.Parse(row.Cells["Id"].Value.ToString());
                    objArticulo = Resultado.Where(x => x.Id == idArticulo).FirstOrDefault();
                    articuloList.Add(objArticulo);
                }
            }

            if (articuloList.Count > 0)
            {
                dvArticulos = Funciones.convertToDataTable(articuloList).DefaultView;
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
