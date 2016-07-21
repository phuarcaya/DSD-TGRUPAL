
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS_ProduccionUtilitario;


namespace Prototipo1.View
{
    public partial class Orden_Trabajo : frmMantenimiento, IMantenimiento
    {
        public Orden_Trabajo()
        {
            InitializeComponent();
        }

        public void SISCO_Mantenimiento_Nuevo()
        {
            throw new NotImplementedException();
        }

        public void SISCO_Mantenimiento_Grabar()
        {
            throw new NotImplementedException();
        }

        public void SISCO_Mantenimiento_Modificar()
        {
            throw new NotImplementedException();
        }

        public void SISCO_Mantenimiento_Cancelar()
        {
            throw new NotImplementedException();
        }

        public void SISCO_Mantenimiento_Eliminar()
        {
            throw new NotImplementedException();
        }

        public void SISCO_Mantenimiento_Listado()
        {
            WSord.OrdenTrabajosClient proxy = new WSord.OrdenTrabajosClient();
            dgvListados.DataSource = proxy.listarOrd();
            //dgvListados.DataBind();
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void dgvListados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
