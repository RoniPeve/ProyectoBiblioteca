using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using datos;

namespace conexion
{
    public class Utilidades
    {
       public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        
        public static DataSet Ejecutar(string cmd)
        {
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);
            con.Close();
            return DS;
        }
        public void InsertarLibros(DatosLibros li)
        {
            SqlCommand cmd = new SqlCommand("Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_de_libro",li.codigo_libro );
            cmd.Parameters.AddWithValue("@nombre_de_libro", li.Nombre_libro);
            cmd.Parameters.AddWithValue("@autor_libro", li.Autor_libro);
            cmd.Parameters.AddWithValue("@categoria_libro", li.Categoria_libro);
            cmd.Parameters.AddWithValue("@idioma_libro", li.Idioma_libro);
            cmd.Parameters.AddWithValue("@tipo_libro", li.tipo_libro);
            cmd.Parameters.AddWithValue("@precio_libro", li.precio_libro);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Eliminar(int codigo_de_libro)
        {
            SqlCommand cmd = new SqlCommand("Eliminar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_de_libro", codigo_de_libro );
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void EditarLibros(DatosLibros li)
        {
            SqlCommand cmd = new SqlCommand("ModificarLibro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_de_libro", li.codigo_libro);
            cmd.Parameters.AddWithValue("@nombre_de_libro", li.Nombre_libro);
            cmd.Parameters.AddWithValue("@autor_libro", li.Autor_libro);
            cmd.Parameters.AddWithValue("@categoria_libro",li.Categoria_libro);
            cmd.Parameters.AddWithValue("@idioma_libro", li.Idioma_libro);
            cmd.Parameters.AddWithValue("@tipo_libro", li.tipo_libro);
            cmd.Parameters.AddWithValue("@precio_libro", li.precio_libro);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void InsertarPrestamos(DatosLibros li)
        {
            SqlCommand cmd = new SqlCommand("InsertarPrestamo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_libro", li.codigo_libro);
            cmd.Parameters.AddWithValue("@nombre_libro", li.Nombre_libro);
            cmd.Parameters.AddWithValue("@nombre_persona", li.Nombre_persona);
            cmd.Parameters.AddWithValue("@DNI", li.DNI);
            cmd.Parameters.AddWithValue("@fecha_salida", li.fecha);
            cmd.Parameters.AddWithValue("@estado", li.Estado);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataSet llenarDatosTabla(string tabla)
        {
          
            string cmd = String.Format("select*from " + tabla);
            DataSet ds= Ejecutar(cmd);
            return ds;
        }
       public static DataSet llenarDatosConsulta(string tabla,string tipoLibro)
        {
            string cmd = String.Format("select*from " + tabla +" where tipo_libro='{0}'",tipoLibro);
            DataSet ds = Ejecutar(cmd);
            return ds;
        }
        public void EliminarPrestamoVenta(string procedimiento,string nombre, string nonlibro)
        {
            SqlCommand cmd = new SqlCommand(procedimiento, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre_persona", nombre);
            cmd.Parameters.AddWithValue("@nombre_libro", nonlibro);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InsertarVentas(DatosLibros li)
        {
            SqlCommand cmd = new SqlCommand("InsertarVentas", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo_libro", li.codigo_libro);
            cmd.Parameters.AddWithValue("@nombre_libro", li.Nombre_libro);
            cmd.Parameters.AddWithValue("@nombre_persona", li.Nombre_persona);
            cmd.Parameters.AddWithValue("@DNI", li.DNI);
            cmd.Parameters.AddWithValue("@precio", li.precio_libro );
            cmd.Parameters.AddWithValue("@fecha_venta", li.fecha);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
