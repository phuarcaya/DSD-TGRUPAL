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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cbxmostrarcontraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxmostrarcontraseña.Checked == true)
            {
                txtpassw.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassw.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "adm" && txtpassw.Text=="1234" )
            {
                Pagina_Principal OT = new Pagina_Principal();
                Login lo = new Login();
                lo.Close();
                lo.Hide();
                OT.Show();
            }
        }

        private void txtpassw_TextChanged(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
