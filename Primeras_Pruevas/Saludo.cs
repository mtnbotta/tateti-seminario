using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_Pruevas
{
    public class Saludo
    {
        private string Nombre;
        private string Apellido;

        public Saludo()
        { 
            Nombre = "";
            Apellido = "";
        }

        public Saludo(string nom, string ape )
        { 
            Nombre = nom;
            Apellido = ape;
        }

        public void CapturarNombre()
        {
            Console.WriteLine("Ingrese su Nombre: ");
            Nombre = Console.ReadLine();
        }
        public void CapturarApellido()
        {
            Console.WriteLine("Ingrese su Apellido: ");
            Apellido = Console.ReadLine();

        }
        public void Saludar()
        {
            Console.WriteLine("Hola " + Nombre + " " + Apellido + " como andas");
        }

        public void SaludoFormal()
        {
            Console.WriteLine("Hola Sr/a. {0} {1}", Nombre, Apellido);
        }
        public void SaludoFormal(String Leyenda)
        {
            Console.WriteLine("Hola {0} {1} {2}",Leyenda, Nombre, Apellido);
        
        }
    }
}