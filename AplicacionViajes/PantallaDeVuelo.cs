﻿using System;
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
        public ViajesDisponibles classViajesDisponibles = new ViajesDisponibles();
        public PantallaDeVuelo()
        {
            InitializeComponent();
            classViajesDisponibles._ReferenciarData(dataTableroViajesDisponibles);
            classViajesDisponibles._ActualizarData();
        }

        private void bttProgramarViaje_Click(object sender, EventArgs e)
        {
        }

        private void bttAgregarViaje_Click(object sender, EventArgs e)
        {

        }
    }
}
