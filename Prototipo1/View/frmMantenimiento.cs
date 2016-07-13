using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WS_ProduccionUtilitario;

namespace Prototipo1.View
{
    public partial class frmMantenimiento : Form
    {
        public string TituloFormulario
        {
            get
            {
                return lblTitulo.Text;
            }
            set
            {
                lblTitulo.Text = value;
            }
        }

        public frmMantenimiento()
        {
            InitializeComponent();
        }

        #region Botones de Mantenimiento
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IMantenimiento currenForm = (IMantenimiento)this;
            if (currenForm != null)
                currenForm.SISCO_Mantenimiento_Nuevo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            IMantenimiento currenForm = (IMantenimiento)this;
            if (currenForm != null)
                currenForm.SISCO_Mantenimiento_Grabar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            IMantenimiento currenForm = (IMantenimiento)this;
            if (currenForm != null)
                currenForm.SISCO_Mantenimiento_Modificar();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            IMantenimiento currenForm = (IMantenimiento)this;
            if (currenForm != null)
                currenForm.SISCO_Mantenimiento_Cancelar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IMantenimiento currenForm = (IMantenimiento)this;
            if (currenForm != null)
                currenForm.SISCO_Mantenimiento_Eliminar();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            IMantenimiento currenForm = (IMantenimiento)this;
            if (currenForm != null)
                currenForm.SISCO_Mantenimiento_Listado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
