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
    public partial class PantallaDeVuelo : Form
    {
        public ViajesDisponibles classViajesDisponibles;
        public ProgramarViaje formProgramarViaje;
        public PantallaDeVuelo()
        {
            InitializeComponent();
            classViajesDisponibles = new ViajesDisponibles(dataTableroViajesDisponibles);
            classViajesDisponibles._ActualizarData();
            formProgramarViaje = new ProgramarViaje();
        }

        private void bttProgramarViaje_Click(object sender, EventArgs e)
        {
            formProgramarViaje.Show();
        }
    }
}
