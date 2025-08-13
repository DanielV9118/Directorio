using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.Clases
{
    public class Persona
    {
        private string nummeroid { get; set; }
        private string nombres { get; set; }
        public string apellidos { get; set; }

        public string direccion { get; set; }

        public int edad { get; set; }
        public DateTime fechanacimiento { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        public Persona()
        {
            this.nombres = "jose";

        }
        public Persona(string p_nombres)
        {
            this.nombres = p_nombres;
        }
        public string getNombre()
        {
            return this.nombres;

        }
        public void setNombre(string p_nombres)
        {
            this.nombres = p_nombres;
                    }
        public void setApellidos(string p_apellidos) {
        {
        this.apellidos = p_apellidos;   
        }
        }
        public string getNombreCompleto()
        {
            return this.nombres + " " + this.apellidos;
        }
        public string getNombreCompleto(string p_nombres, string p_apellidos)
        {
            this.nombres = p_nombres;
            this.apellidos = p_apellidos;
            return this.nombres + " " + p_apellidos;
        }
    }
    }

