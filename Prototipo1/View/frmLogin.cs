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
    public partial class frmLogin : Form
    {
        public int IdUsuario { get; set; }
        
        public frmLogin()
        {
            InitializeComponent();
        }

        #region :: Metodos ::
        private bool ValidarUsuario(string User,string Password) {
            try
            {
                bool Retorno = true;

                return Retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnIngresar_Click(sender, e);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text)) {
                MessageBox.Show("Ingrese Nombre de Usuario...!!!", Funciones.Insfor_NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingrese Password...!!!", Funciones.Insfor_NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (ValidarUsuario(txtUsuario.Text.Trim(), txtPassword.Text.Trim()))
            {
                //Registrar Auditoria
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this.Close();
            }
            else {
                MessageBox.Show("Nombre de Usuario ó Password Incorrecto...!!!", Funciones.Insfor_NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }
    }
}
