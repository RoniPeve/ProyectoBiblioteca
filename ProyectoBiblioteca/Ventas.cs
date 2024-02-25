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

namespace ProyectoBiblioteca
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        DatosLibros libro = new DatosLibros();
        Utilidades uti = new Utilidades();
        Validar val = new Validar();
        private void Ventas_Load(object sender, EventArgs e)
        {
            textPrecio.Enabled = false;
            dateVenta.Enabled = false;
            listarVentas();
            dateVenta.Value = DateTime.Now;
        }
        private bool validarcampos()
        {
            bool error = true;
            if (textcodigo.Text=="")
            {
                errorIcono.SetError(textcodigo, "Ingrese el codigo");
                error = false;
            }
            else if (textLibro.Text=="")
            {
                errorIcono.Clear();
                errorIcono.SetError(textLibro, "Ingrese el Nombre del Libro");
                error = false;
            }
            else if (textPersona.Text=="")
            {
                errorIcono.Clear();
                errorIcono.SetError(textPersona, "Ingrese el Nombre de la Persona");
                error = false;
            }
            else if (textDNI.Text=="")
            {
                errorIcono.Clear();
                errorIcono.SetError(textDNI, "Ingrese el Nombre el DNI");
                error = false;
            }
            return error;
        }
        private void btnAgregarCompras_Click(object sender, EventArgs e)
        {
            if (validarcampos())
            {
                try
                {
                    string CMD = string.Format("Select * FROM Libros WHERE codigo_de_libro='{0}'", textcodigo.Text);
                    DataSet ds = Utilidades.Ejecutar(CMD);
                    int codigolibro = int.Parse(ds.Tables[0].Rows[0]["codigo_de_libro"].ToString());
                    errorIcono.Clear();
                    agregar();
                    listarVentas();
                    limpiar();
                    textcodigo.Focus();
                }
                catch (Exception)
                {

                    MessageBox.Show("no se encuentra libro");
                    limpiar();
                }
                
            }
            
        }
        void agregar()
        {
            libro.codigo_libro = Convert.ToInt32(textcodigo.Text);
            libro.Nombre_libro = textLibro.Text;
            libro.Nombre_persona = textPersona.Text;
            libro.DNI = textDNI.Text;
            libro.precio_libro = float.Parse(textPrecio.Text);
            libro.fecha = dateVenta.Text;
            uti.InsertarVentas(libro);
            MessageBox.Show("guardado con exito");
            listarVentas();
            limpiar();
        }
        private void btnConsultarVenta_Click(object sender, EventArgs e)
        {
            Consulta consu = new Consulta("Venta");
           consu.ShowDialog();
            if (consu.DialogResult == DialogResult.OK)
            {
                textcodigo.Text = consu.dataLibrosConsulta.Rows[consu.dataLibrosConsulta.CurrentRow.Index].Cells[0].Value.ToString();
                textLibro.Text = consu.dataLibrosConsulta.Rows[consu.dataLibrosConsulta.CurrentRow.Index].Cells[1].Value.ToString();
                textPrecio.Text = consu.dataLibrosConsulta.Rows[consu.dataLibrosConsulta.CurrentRow.Index].Cells[6].Value.ToString();
                textPersona.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminarCompras_Click(object sender, EventArgs e)
        {
            if (textLibro.Text == "")
            {
                errorIcono.SetError(textLibro, "Ingrese el Nombre de la Persona");
                textLibro.Focus();

            }
            else if(textPersona.Text=="")
            {
                errorIcono.Clear();
                textPersona.Focus();
                errorIcono.SetError(textPersona, "Ingrese el Nombre de la Persona");
            }
            else
            {
                errorIcono.Clear();
                try
                {
                    string CMD = string.Format("Select*FROM Ventas WHERE nombre_persona='{0}' AND nombre_libro='{1}'", textPersona.Text, textLibro.Text);
                    DataSet ds = Utilidades.Ejecutar(CMD);
                    string nombre = ds.Tables[0].Rows[0]["nombre_persona"].ToString();
                    string nonLibro = ds.Tables[0].Rows[0]["nombre_libro"].ToString();
                    if (nombre == textPersona.Text && nonLibro== textLibro.Text)
                    {
                        string procedimiento = "EliminarVentas";
                        uti.EliminarPrestamoVenta(procedimiento, nombre, nonLibro);
                        MessageBox.Show("Eliminado con exito");
                        listarVentas();
                        limpiar();
                        textcodigo.Focus();
                    }

                }
                catch (Exception )
                {
                    MessageBox.Show("Libro no encontrado ");
                    
                }
                
                
            }
           
        }
        
        public void listarVentas()
        {
            dataVentas.DataSource = Utilidades.llenarDatosTabla("Ventas").Tables[0];
        }
        void limpiar()
        {
            textcodigo.Clear();
            textPersona.Clear();
            textLibro.Clear();
            textDNI.Clear();
            textPrecio.Clear();
            dateVenta.Value = DateTime.Now;

        }

        private void textcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }

        private void textPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }

        private void textDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            textcodigo.Text = dataVentas.Rows[dataVentas.CurrentRow.Index].Cells[0].Value.ToString();
            textLibro.Text= dataVentas.Rows[dataVentas.CurrentRow.Index].Cells[1].Value.ToString();
            textPersona.Text= dataVentas.Rows[dataVentas.CurrentRow.Index].Cells[2].Value.ToString();
            textDNI.Text= dataVentas.Rows[dataVentas.CurrentRow.Index].Cells[3].Value.ToString();
            textPrecio.Text= dataVentas.Rows[dataVentas.CurrentRow.Index].Cells[4].Value.ToString();
            dateVenta.Text= dataVentas.Rows[dataVentas.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void textcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
