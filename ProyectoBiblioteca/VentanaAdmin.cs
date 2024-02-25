using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros lib = new Libros();
            lib.ShowDialog();
            
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos pres = new Prestamos();
            pres.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas com = new Ventas();
            com.ShowDialog();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
