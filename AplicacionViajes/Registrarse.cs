using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionViajes
{
    public partial class Registrarse : Form
    {
        formPantallaDeLogin formPantallaLogin;
        public Registrarse()
        {
            InitializeComponent();
            formPantallaLogin = new formPantallaDeLogin();
        }

        private void bttRegistrarse_Click(object sender, EventArgs e)
        {
            if(formPantallaLogin.classRegistroDeUsuario._RegistrarNuevoUsuario(txtUserNameRegister, txtPasswordRegister) == true)
            {
                formPantallaLogin.Show();
                this.Hide();
            }
        }
    }
}
