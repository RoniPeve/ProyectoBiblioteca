using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexion;


namespace ProyectoBiblioteca
{
    public partial class Consulta : Form
    {
        string cons;
        public Consulta(string consulta)
        {
            InitializeComponent();
            cons = consulta;
        }
       
        private void Consulta_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            if (cons=="Venta")
            {
                dataLibrosConsulta.DataSource = Utilidades.llenarDatosConsulta("Libros", "Venta").Tables[0];
            }
            else if (cons=="Gratuito")
            {
                dataLibrosConsulta.DataSource = Utilidades.llenarDatosConsulta("Libros", "Gratuito").Tables[0];
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


           if (string.IsNullOrEmpty(textNombreBuscar.Text)==false)
            {
                    try
                    {

                    //string cmd = "select * from Libros where nombre_de_libro LIKE ('%" + textNombreBuscar.Text + "%')";
                    
                    string cmd = string.Format("select * from Libros where nombre_de_libro LIKE('%" + textNombreBuscar.Text + "%') AND tipo_libro='{1}'", textNombreBuscar.Text,cons);
                    
                    DataSet ds = Utilidades.Ejecutar(cmd);
                        dataLibrosConsulta.DataSource = ds.Tables[0];
                    }
                    catch (Exception )
                    {

                        MessageBox.Show("No se encontro libro" );
                    }


            }
            else
            {
                listar();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataLibrosConsulta.Rows.Count==0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
