using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaJugadoresBE
{
    public class Jugadores
    {
        public Jugador[] Lista {get; set;} = new Jugador[10];
        private int fila = 0;

    public void Agregar(Jugador aJug)
        {
            Lista[fila] = aJug;
            fila++;
        }

        public string Listar()
        {
            string res = "";
        for (int i = 0; i < fila; i++)
            {
                res = res + Lista[i].Listar() + "\n";
            }
        return res;
        }
    }
}
