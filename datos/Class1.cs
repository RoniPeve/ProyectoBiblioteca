using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class DatosLibros
    {
        public int codigo_libro { get; set; }
        public string Nombre_libro { get; set; }
        public string Autor_libro { get; set; }
        public string Categoria_libro { get; set; }
        public string Idioma_libro { get; set; }
        public string tipo_libro { get; set; }
        public float precio_libro { get; set; }
        public string Nombre_persona { get; set; }
        public string DNI { get; set; }

        public string fecha { get; set; }
        public string Estado { get; set; }
    }
}
