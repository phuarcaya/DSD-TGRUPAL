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
    public partial class IngresoProducto : Form
    {
        public IngresoProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta Seguro que desea Cancelar?",
                "Salida", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog== DialogResult.Yes)
            {
                Dispose();
            }
            else if (dialog == DialogResult.No)
            {
               
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void IngresoProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
