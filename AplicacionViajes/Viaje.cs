using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionViajes
{
    public class Viaje
    {
        public DateTime horarioProgramado { get; set; }
        public string destino { get; set; }

        public Viaje(DateTime horarioProgramado, string destino)
        {
            this.horarioProgramado = horarioProgramado;
            this.destino = destino;
        }
    }
}
