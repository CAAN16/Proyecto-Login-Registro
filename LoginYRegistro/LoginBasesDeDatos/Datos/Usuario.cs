using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginBasesDeDatos.Datos
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public string usuario { get; set; }
        public string apellidos { get; set; }
        public string password { get; set; }
        public string correo {  get; set; }
        public string telefono {  get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
