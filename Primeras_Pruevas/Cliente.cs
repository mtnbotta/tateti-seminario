using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_Pruebas
{
    public class Cliente
    {   //son propiedades de la clase cliente
        private string nombre, apellido, mes, anio, dia, direccion, localidad, telefono, codigo;
        private DateTime Fecha_Nacimiento;

        public Cliente()
        {
            Console.WriteLine("Creando un objeto basado en la clase cliente");

        }

        private void CapturarCodigo()
        {
            Console.WriteLine("Ingrese el Codigo: ");
            codigo = Console.ReadLine();
            if (codigo == "")
            {
                Console.WriteLine("ERROR, debe escribir un CODIGO");
                CapturarCodigo();
            }
        
        }

        private void CapturarNombre()
        {
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            if (nombre == "")

            {
                Console.WriteLine("ERROR, debe escribir un NOMBRE");
                CapturarNombre();

            }
        }

        private void CapturarApellido()
        {
            Console.WriteLine("Ingresa tu apellido");
            apellido = Console.ReadLine();
            if (apellido == "")
            {
                Console.WriteLine("ERROR, debe escribir un APELLIDO");
                CapturarApellido();
            }
        }

        private void CapturarDireccion()
        {
            Console.WriteLine("Ingrese su dirección");
            direccion = Console.ReadLine();
            if (direccion == "")
            {
                Console.WriteLine("ERROR, debe escribir una DIRECCION");
                CapturarDireccion();
            }
        }

        private void CapturarLocalidad()
        {
            Console.WriteLine("Ingrese su localidad");
            localidad = Console.ReadLine();
            if (localidad == "")
            {
                Console.WriteLine("ERROR, debe escribir una LOCALIDAD");
                CapturarLocalidad();
            }
        }

        private void CapturarDia()
        {
            Console.Write("Ingrese el dia de nacimiento: ");
            dia = Console.ReadLine();
        }

        private void CapturarMes()
        {
            Console.Write("Ingrese el mes de nacimiento: ");
            mes = Console.ReadLine();
        }

        private void CapturarAnio()
        {
            Console.Write("Ingrese el Año de nacimiento: ");
            anio = Console.ReadLine();
        }

        private void CapturarTelefono()
        {
            Console.WriteLine("Por último ingrese su teléfono");
            telefono = Console.ReadLine();
            if (telefono == "")
            {
                Console.WriteLine("ERROR, debe escribir un NUMERO");
                CapturarTelefono();
            }
        }
        public void CapturarDatos()
        {
            CapturarCodigo();
            CapturarApellido();
            CapturarNombre();
            //CapturarDia();
            //CapturarMes();
            //CapturarAnio();
            CapturarDireccion();
            CapturarLocalidad();
            CapturarTelefono();
            CapturarFechaNacimento();
        }

        private string AnunciarEdad()
        {
            // tomamos la fecha de hoy y la almacenamos en la variable "hoy"
            DateTime hoy = DateTime.Now;
            int edad = 0;
            //evalua si la persona ya cumplio años en el año actual
            if (hoy.DayOfYear >= Fecha_Nacimiento.DayOfYear)
            {
                edad = hoy.Year - Fecha_Nacimiento.Year;
            }
            else
            {
                edad = (hoy.Year - Fecha_Nacimiento.Year) - 1;
            }
            return "Tengo " + edad + " años";

        }
        private string Presentarse()
        {
            return "Hola soy: " + (apellido + " " + nombre);
        }
         
        private string AnunciarDomicilio()
        {
            return "Vivo en: " + (direccion + " " + localidad);
        }

        public void Hablar()
        {
            // inicializacion; condicion; modificacion
            for (int x = 0; x < 40; x++)
                Console.Write("*");
            Console.WriteLine("\n");
            Console.WriteLine(Presentarse());
            Console.WriteLine(AnunciarDomicilio());
            Console.WriteLine(AnunciarEdad());
        }


        private void CapturarFechaNacimento()
        {
            Console.Write("Ingrese Su Fecha Nacimiento");
            // Intenta hacer esta secuencia
            try
            {
                Fecha_Nacimiento = Convert.ToDateTime(Console.ReadLine());
            }
            // Si hay error informa
            catch
            {
                Console.Write("ERROR, ingrese la fecha correctamente");
                CapturarFechaNacimento();
            }
        }

        public void ImprimirFicha()
        {
            Console.WriteLine("Prueva de Consola en \"C#\"");

            Console.WriteLine("\nFICHA PERSONAL DEL CLIENTE");
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Dirección: " + direccion);
            Console.WriteLine("Localidad: " + localidad);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("Fecha de Nacimiento: " + Fecha_Nacimiento.ToShortDateString());

        }

        public void ImprimirHorizontal()
        {
            Console.WriteLine("{0} {1} {2} {3}", codigo, apellido, nombre, direccion);


        
        }
        
        public string MostrarNombreCompleto()
        {
            return apellido + " " + nombre;
        }
    }
}
