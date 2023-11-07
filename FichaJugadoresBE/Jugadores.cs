using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaJugadoresBE
{
    public class Jugadores
    {
        public DataTable ListaDT { get; set; } = new DataTable();

       
   

        public void InsertaJugador(Jugador aJugador) 
        {
            ListaDT.Rows.Add();
            int NuevoRenglon = ListaDT.Rows.Count- 1;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aJugador.Nombre;
            ListaDT.Rows[NuevoRenglon]["Apellido"] = aJugador.Apellido;
            ListaDT.Rows[NuevoRenglon]["Posicion"] = aJugador.Posicion;
            ListaDT.Rows[NuevoRenglon]["Dorsal"] = aJugador.Dorsal;

            ListaDT.WriteXml("Jugadores.xml");
           


        }
        public Jugadores()
        {
            ListaDT.TableName = "ListaJugadores";
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Apellido");
            ListaDT.Columns.Add("Posicion");
            ListaDT.Columns.Add("Dorsal");

            LeeArchivos();

        }

        public void LeeArchivos() 
        {
            if (System.IO.File.Exists("Jugadores.xml"))
            {
                ListaDT.ReadXml("Jugadores.xml");
            }
                
        }


       
    }
}
