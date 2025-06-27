using Flow_Solver.ObjectsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Solver
{
    internal partial class login_form : Form
    {
        private SysUser[] loadedUsers;

        public login_form()
        {
            InitializeComponent();
            loadedUsers = SysUser.GetAll().Object;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Select();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            SysUser? TARGET_USER = loadedUsers.Cast<SysUser?>()
                .FirstOrDefault(user => user.Username.Equals(this.txtUsuario.Value, StringComparison.OrdinalIgnoreCase));

            if (TARGET_USER != null)
            {
                if (TARGET_USER.ValidateUserPassword(this.txtContraseña.Value).Success)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta!", "Credenciales erroneas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("No se encontro al usuario correspondiente! Reinicia el programa y reintenta una vez mas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
