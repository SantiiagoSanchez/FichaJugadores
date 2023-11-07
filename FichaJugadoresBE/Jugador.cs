using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaJugadoresBE
{
    public class Jugador
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Posicion { get; set; }

        public string Dorsal { get; set; }

        public void Agregar(string aNombre,
            string aApellido,
            string aPosicion,
            string aDorsal)
        {
            Nombre = aNombre;
            Apellido = aApellido;
            Posicion = aPosicion;
            Dorsal = aDorsal;
        }




    }
}





