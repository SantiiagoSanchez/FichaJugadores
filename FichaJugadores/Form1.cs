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
        int cursor;

        Jugadores ListaJugadores {get;set;} = new Jugadores();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ListaJugadores.ListaDT;
            dataGridView1.Visible = false;
            btNuevoJugador.Visible = false;
            btEliminar.Visible = false;
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Jugador jug = new Jugador();


            jug.Agregar(txtNombre.Text,
                txtApellido.Text,
                txtPosicion.Text,
                txtDorsal.Text);


            if (txtNombre.Text == "")
            {
                MessageBox.Show("No ingreso Nombre");

                return;

            }

            if (txtApellido.Text == "")
            {
                MessageBox.Show("No ingreso Apellido");

                return;


            }

            if (txtPosicion.Text == "")
            {
                MessageBox.Show("No ingreso Posicion");

                return;
            }

            if (txtDorsal.Text == "")
            {
                MessageBox.Show("No ingreso Dorsal");

                return;
            }

            ListaJugadores.InsertaJugador(jug);
            dataGridView1.DataSource = ListaJugadores.ListaDT;
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtPosicion.Text = "";
            txtDorsal.Text = "";

        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
     

            dataGridView1.Visible = true;
            btNuevoJugador.Visible = true;
            btEliminar.Visible = true;
            btMostrar.Visible = false;
            btCargar.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtDorsal.Visible = false;
            txtPosicion.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            //Como hacer para que 
            
        }



        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNuevoJugador_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            btNuevoJugador.Visible = false;
            btEliminar.Visible = false;
            btMostrar.Visible = true;
            btCargar.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtDorsal.Visible = true;
            txtPosicion.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(cursor);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cursor = dataGridView1.CurrentRow.Index;
        }
    }
}
