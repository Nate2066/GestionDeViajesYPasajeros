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
    public partial class formPantallaDeLogin : Form
    {
        //forms
        public Registrarse formRegistrarse;
        public PantallaDeVuelo formPantallaDeVuelo;
        //class
        public RegistroDeUsuarios classRegistroDeUsuario;
        public formPantallaDeLogin()
        {
            InitializeComponent();
            formPantallaDeVuelo = new PantallaDeVuelo();
            formRegistrarse = new Registrarse();
            classRegistroDeUsuario = new RegistroDeUsuarios();
        }

        private void bttIniciarSesion_Click(object sender, EventArgs e)
        {
            if(classRegistroDeUsuario._IniciarSesion(txtUserName, txtPassword) == true)
            {
                formPantallaDeVuelo.Show();
                this.Hide();
            }
        }

        private void bttRegistrarse_Click(object sender, EventArgs e)
        {
            formRegistrarse.Show();
            this.Hide();
        }
    }
}
