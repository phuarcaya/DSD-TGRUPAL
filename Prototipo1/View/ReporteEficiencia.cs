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
    public partial class ReporteEficiencia : frmReporte
    {
        public ReporteEficiencia()
        {
            InitializeComponent();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string fechaInicio = DateTime.Parse(dateTimePicker1.Text).Year.ToString().PadLeft(4, '0') + DateTime.Parse(dateTimePicker1.Text).Month.ToString().PadLeft(2, '0') + DateTime.Parse(dateTimePicker1.Text).Day.ToString().PadLeft(2, '0');
            string fechaFinal = DateTime.Parse(dateTimePicker2.Text).Year.ToString().PadLeft(4, '0') + DateTime.Parse(dateTimePicker2.Text).Month.ToString().PadLeft(2, '0') + DateTime.Parse(dateTimePicker2.Text).Day.ToString().PadLeft(2, '0');

            BindingSource BindingSource = new System.Windows.Forms.BindingSource();
            BindingSource.DataSource = new WSReportes.ReportServiceClient().ListarEficiencia(fechaInicio, fechaFinal);
            BindingNavigator.BindingSource = BindingSource;

            dgvListados.AutoGenerateColumns = false;
            dgvListados.DataSource = BindingNavigator.BindingSource;
        }
    }
}
