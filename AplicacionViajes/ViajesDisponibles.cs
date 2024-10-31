using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionViajes
{
    public class ViajesDisponibles
    {
        private DataGridView dataGridViewViajesDisponibles;
        public List<Viaje> viajesDisponibles = new List<Viaje>()
        {
            new Viaje(new DateTime(2024, 11, 05, 15, 30, 00), "MADRID"),
            new Viaje(new DateTime(2024, 10, 10, 08, 00, 00), "LONDRES"),
            new Viaje(new DateTime(2025, 01, 01, 03, 45, 00), "COLOMBIA"),
            new Viaje(new DateTime(2024, 11, 03, 06, 30, 00), "CANADA")
        };

        public void _ReferenciarData(DataGridView dataGridViewViajesDisponibles)
        {
            this.dataGridViewViajesDisponibles = dataGridViewViajesDisponibles;
        }

        public void _AgregarViaje(DateTime pHorarioporgramado, string pDestino)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridViewViajesDisponibles);
            row.Cells[0].Value = pHorarioporgramado.ToString();
            row.Cells[1].Value = pDestino.ToString();
            dataGridViewViajesDisponibles.Rows.Add(row);
        }
        public void _ActualizarData()
        {
            for(int i = 0; i < viajesDisponibles.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewViajesDisponibles);
                row.Cells[0].Value = viajesDisponibles[i].horarioProgramado;
                row.Cells[1].Value = viajesDisponibles[i].destino;
                dataGridViewViajesDisponibles.Rows.Add(row);
            }
        }
    }
}
