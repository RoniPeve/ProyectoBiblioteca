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
using datos;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoBiblioteca
{
    public partial class Libros : Form 
    {
        public Libros()
        {
            InitializeComponent();

        }
        Validar val = new Validar();
        DatosLibros libro = new DatosLibros();
        Utilidades uti = new Utilidades();
        bool estado = Login.status;
        void ListarLibros()
        {
            dataLibros.DataSource = Utilidades.llenarDatosTabla("Libros").Tables[0];
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            ListarLibros();
            if (estado)
            {
                btnAgregar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

            }
            else
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            textPrecio.Enabled = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             try
             {
                string CMD = string.Format("Select * FROM Libros WHERE codigo_de_libro='{0}'", textCodigoLibro.Text);
                DataSet ds = Utilidades.Ejecutar(CMD);
                int codigolibro = int.Parse(ds.Tables[0].Rows[0]["codigo_de_libro"].ToString());
                 if (codigolibro == int.Parse(textCodigoLibro.Text))
                 {
                     MessageBox.Show("ya existe un libro con ese codigo");
                 }
             }
             catch (Exception ee)
             {
                if (validarcampo())
                {
                    ErrorIcono.Clear();
                    agregar();
                    ListarLibros();
                    limpiarLibros();
                    textCodigoLibro.Focus();
                    MessageBox.Show(ee.Message);
                }
                
             }
        }
        private bool validarcampo()
        {
            bool error = true;
            if (textCodigoLibro.Text=="")
            {
                ErrorIcono.SetError(textCodigoLibro, "Ingrese codigo");
                error = false;
            }
            else if (textNombreLibro.Text=="")
            {
                ErrorIcono.Clear();
                ErrorIcono.SetError(textNombreLibro, "Ingrese Nombre del Libro");
                error = false;
            }
            else if (textAutorLibro.Text=="")
            {
                ErrorIcono.Clear();
                ErrorIcono.SetError(textAutorLibro, "Ingrese Autor de Libro");
                error = false;
            }
            else if (comboCategoriaLibro.Text=="")
            {
                ErrorIcono.Clear();
                ErrorIcono.SetError(comboCategoriaLibro, "Ingrese Categoria del Libro");
                error = false;
            }
            else if (textIdiomaLibro.Text=="")
            {
                ErrorIcono.Clear();
                ErrorIcono.SetError(textIdiomaLibro, "Ingrese Idioma del Libro");
                error = false;
            }
            else if (comboTipo.Text=="")
            {
                ErrorIcono.Clear();
                ErrorIcono.SetError(comboTipo, "Ingrese Tipo del Libro");
                error = false;
            }
            else if (textPrecio.Text=="")
            {
                ErrorIcono.Clear();
                ErrorIcono.SetError(textPrecio, "Ingrese Precio del Libro");
                error = false;
            }
            return error;
        }
        public void agregar()
        {
           
            libro.codigo_libro =Convert.ToInt32(textCodigoLibro.Text);
            libro.Nombre_libro = textNombreLibro.Text;
            libro.Autor_libro = textAutorLibro.Text; 
            libro.Categoria_libro =Convert.ToString(comboCategoriaLibro.Text);
            libro.Idioma_libro =textIdiomaLibro.Text;
            libro.tipo_libro = comboTipo.Text;
            libro.precio_libro = float.Parse(textPrecio.Text);
            uti.InsertarLibros(libro);
            MessageBox.Show("Libro guardado con exito");
        }
        void limpiarLibros()
        {
            textNombreLibro.Clear();
            textCodigoLibro.Clear();
            textAutorLibro.Clear();
            comboCategoriaLibro.Text = "";
            textCodigoLibro.Clear();
            textIdiomaLibro.Clear();
            comboTipo.Text = "";
            textPrecio.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCodigoLibro.Text=="")
                {
                    ErrorIcono.SetError(textCodigoLibro, "ingrese el codigo");
                }
                else
                {
                    ErrorIcono.Clear();
                    int codigo_De_libro = int.Parse(textCodigoLibro.Text);
                    uti.Eliminar(codigo_De_libro);
                    MessageBox.Show("Eliminado con exito");
                    ListarLibros();
                    limpiarLibros();
                    textCodigoLibro.Focus();
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("ha ocurrido un error");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validarcampo())
            {
                ErrorIcono.Clear();
                editarlibros();
                ListarLibros();
                limpiarLibros();
                textCodigoLibro.Focus();
            }
            
        }
        void editarlibros()
        {
                libro.codigo_libro = Convert.ToInt32(textCodigoLibro.Text);
                libro.Nombre_libro = textNombreLibro.Text;
                libro.Autor_libro = textAutorLibro.Text;
                libro.Categoria_libro = Convert.ToString(comboCategoriaLibro.Text);
                libro.Idioma_libro = textIdiomaLibro.Text;
                libro.tipo_libro = comboTipo.Text;
                libro.precio_libro = float.Parse(textPrecio.Text);
                uti.EditarLibros(libro);
                MessageBox.Show("Libro Editado con exito");    
        }
       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string CMD = string.Format("Select*FROM Libros WHERE codigo_de_libro='{0}'", textCodigoLibro.Text);
            DataSet ds = Utilidades.Ejecutar(CMD);
            try
            {

                int codigolibro = int.Parse(ds.Tables[0].Rows[0]["codigo_de_libro"].ToString());
                if (codigolibro==int.Parse(textCodigoLibro.Text))
                {
                    MessageBox.Show("se ha encontrado registro");
                    textNombreLibro.Text = ds.Tables[0].Rows[0]["nombre_de_libro"].ToString();
                    textAutorLibro.Text = ds.Tables[0].Rows[0]["autor_libro"].ToString();
                    comboCategoriaLibro.Text= ds.Tables[0].Rows[0]["categoria_libro"].ToString();
                    textIdiomaLibro.Text= ds.Tables[0].Rows[0]["idioma_libro"].ToString();
                    comboTipo.Text= ds.Tables[0].Rows[0]["tipo_libro"].ToString();
                    textPrecio.Text= ds.Tables[0].Rows[0]["precio_libro"].ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("no se ha encontrado");
                limpiarLibros();
            }
            

        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipo.Text == "Venta")
            {
                textPrecio.Enabled = true;
            }
            else if (comboTipo.Text == "Gratuito")
            {
                textPrecio.Enabled = false;
                textPrecio.Text = "0";
            }
        }

        private void textCodigoLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textNombreLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }

        private void textAutorLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }

        private void textIdiomaLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumerosDecimales(e);
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            textCodigoLibro.Text = dataLibros.Rows[dataLibros.CurrentRow.Index].Cells[0].Value.ToString();
            textNombreLibro.Text = dataLibros.Rows[dataLibros.CurrentRow.Index].Cells[1].Value.ToString();
            textAutorLibro.Text= dataLibros.Rows[dataLibros.CurrentRow.Index].Cells[2].Value.ToString();
            comboCategoriaLibro.Text= dataLibros.Rows[dataLibros.CurrentRow.Index].Cells[3].Value.ToString();
            textIdiomaLibro.Text= dataLibros.Rows[dataLibros.CurrentRow.Index].Cells[4].Value.ToString();
            comboTipo.Text= dataLibros.Rows[dataLibros.CurrentRow.Index].Cells[5].Value.ToString();
            textPrecio.Text= dataLibros.Rows[dataLibros.CurrentRow.Index].Cells[6].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
