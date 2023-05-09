using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSRCoppel.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (ValidarControles())
            {
                Classes.Controllers.Login login = new Classes.Controllers.Login(txtUsuario.Text, txtPassword.Text);
                if (!login.ValidarLogin())
                {
                    MessageBox.Show("Usuario o contraseña incorrecto, favor de revisar");
                    return;
                }

                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
        }

        #region Metodos Privados
        private bool ValidarControles()
        {
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor de ingresar el usuario");
                return false;
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Favor de ingresar la contraseña");
                return false;
            }

            return true;
        }
        #endregion
    }
}
