using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;
using conexion;

namespace ProyectoBiblioteca
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }
        DatosLibros libro = new DatosLibros();
        Utilidades uti = new Utilidades();
        Validar val = new Validar();
        public void listarPrestamos()
        {
           dataPrestamos.DataSource = Utilidades.llenarDatosTabla("Prestamos").Tables[0];
        }
       
        private void Prestamos_Load(object sender, EventArgs e)
        {
            listarPrestamos();
            dateFecha.Enabled = false;
            dateFecha.Value = DateTime.Now;
        }
        private bool validarcampo()
        {
            bool error = true;
            if (textCodLibro.Text=="")
            {
                errorIcono.SetError(textCodLibro, "Ingrese el codigo del libro");
                error = false;
            }
            else if (textLibro.Text=="")
            {
                errorIcono.Clear();
                errorIcono.SetError(textLibro, "Ingrese el Nombre del libro");
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
                errorIcono.SetError(textDNI, "Ingrese el DNI de la Persona");
                error = false;
            }
            else if (textEstado.Text=="")
            {
                errorIcono.Clear();
                errorIcono.SetError(textEstado, "Ingrese el Estado del Libro");
                error = false;
            }
            return error;
        }
        private void btnConsultarPrestamo_Click(object sender, EventArgs e)
        {
            Consulta consu = new Consulta("Gratuito");
            consu.ShowDialog();
            if (consu.DialogResult==DialogResult.OK)
            {
                textCodLibro.Text = consu.dataLibrosConsulta.Rows[consu.dataLibrosConsulta.CurrentRow.Index].Cells[0].Value.ToString();
                textLibro.Text= consu.dataLibrosConsulta.Rows[consu.dataLibrosConsulta.CurrentRow.Index].Cells[1].Value.ToString();
                textPersona.Focus();
            }
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            if (validarcampo())
            {
                try
                {
                    string CMD = string.Format("Select * FROM Libros WHERE codigo_de_libro='{0}'", textCodLibro.Text);
                    DataSet ds = Utilidades.Ejecutar(CMD);
                    int codigolibro = int.Parse(ds.Tables[0].Rows[0]["codigo_de_libro"].ToString());
                    agregar();
                }
                catch (Exception)
                {
                    MessageBox.Show("no se encuentra libro");
                    LimpiarPrestamos();
                }
            }
            
        }
        void agregar()
        {
            errorIcono.Clear();
            libro.codigo_libro = Convert.ToInt32(textCodLibro.Text);
            libro.Nombre_libro = textLibro.Text;
            libro.Nombre_persona = textPersona.Text;
            libro.DNI = textDNI.Text;
            libro.fecha = dateFecha.Text;
            libro.Estado = textEstado.Text;
            uti.InsertarPrestamos(libro);
            MessageBox.Show("Libro guardado con exito");
            LimpiarPrestamos();
            listarPrestamos();
            textCodLibro.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Sistema de Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (textLibro.Text == "")
            {
                errorIcono.SetError(textLibro, "Ingrese el Nombre del libro");
                textLibro.Focus();
                
            }
            else if (textPersona.Text=="")
            {
                errorIcono.Clear();
                textPersona.Focus();
                errorIcono.SetError(textPersona, "Ingrese el Nombre");
            }
            else
            {
                try
                {
                    errorIcono.Clear();
                    string CMD = string.Format("Select*FROM Prestamos WHERE nombre_persona='{0}' AND nombre_libro='{1}'", textPersona.Text, textLibro.Text);
                    DataSet ds = Utilidades.Ejecutar(CMD);
                    string nombre = ds.Tables[0].Rows[0]["nombre_persona"].ToString();
                    string nonlibro = ds.Tables[0].Rows[0]["nombre_libro"].ToString();
                    if (nombre == textPersona.Text && nonlibro == textLibro.Text)
                    {
                        string procedimiento = "EliminarPrestamo";
                        uti.EliminarPrestamoVenta(procedimiento, nombre, nonlibro);
                        MessageBox.Show("Eliminado con exito");
                        listarPrestamos();
                        LimpiarPrestamos();
                        textCodLibro.Focus();
                    }
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Libro no encontrado");
                }
               
            }
            
        }
        public void LimpiarPrestamos()
        {
            textCodLibro.Clear();
            textLibro.Clear();
            textPersona.Clear();
            textDNI.Clear();
            textEstado.Clear();
            dateFecha.Value = DateTime.Now;
        }

        private void textCodLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            textCodLibro.Text = dataPrestamos.Rows[dataPrestamos.CurrentRow.Index].Cells[0].Value.ToString();
            textLibro.Text= dataPrestamos.Rows[dataPrestamos.CurrentRow.Index].Cells[1].Value.ToString();
            textPersona.Text= dataPrestamos.Rows[dataPrestamos.CurrentRow.Index].Cells[2].Value.ToString();
            textDNI.Text= dataPrestamos.Rows[dataPrestamos.CurrentRow.Index].Cells[3].Value.ToString();
            dateFecha.Text= dataPrestamos.Rows[dataPrestamos.CurrentRow.Index].Cells[4].Value.ToString();
            textEstado.Text= dataPrestamos.Rows[dataPrestamos.CurrentRow.Index].Cells[5].Value.ToString();
        }
    }
}
