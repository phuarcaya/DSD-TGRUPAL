using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototipo1.View
{
    public partial class frmReporte : Form
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

        public frmReporte()
        {
            InitializeComponent();
        }
    }
}
