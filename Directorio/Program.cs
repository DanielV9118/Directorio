using Directorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            String nombreCompleto = string.Empty;



            persona.setNombre("Pedro Antonio");
            persona.setApellidos("Perez Perez");


            nombreCompleto = persona.getNombreCompleto();
            Console.WriteLine("Persona 1" + nombreCompleto);
            nombreCompleto = persona.getNombreCompleto("Juan", "Lopez Lopez");  
            Console.WriteLine("Persona 2" + nombreCompleto); 


        }
    }
}
