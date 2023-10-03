using FichaJugadoresBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaJugadores
{
    public partial class Form1 : Form
    {
        private Jugadores ListaJugadores = new Jugadores();  
        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Jugador jug = new Jugador();
            Jugador lim = new Jugador();

            jug.Agregar(txtNombre.Text,
                txtApellido.Text,
                txtPosicion.Text,
                txtDorsal.Text);

            ListaJugadores.Agregar(jug);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPosicion.Text = "";
            txtDorsal.Text = "";
            
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void MostrarLista() 
        {
            lblResss.Text = ListaJugadores.Listar();
        }

      
    }

}
