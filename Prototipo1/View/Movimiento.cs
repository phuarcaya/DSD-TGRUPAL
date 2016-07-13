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
    public partial class Movimiento : frmMantenimiento, IMantenimiento
    {
        public enum eTipoMovimiento
        {
            Ninguno = 0,
            IngresoProductoTerminado = 1,
            SalidaMateriales
        }

        public eTipoMovimiento TipoMovimiento
        {
            get;
            set;
        }

        public Movimiento()
        {
            InitializeComponent();
        }


        private void IngresoProducto_Load(object sender, EventArgs e)
        {

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
            throw new NotImplementedException();
        }
    }
}
