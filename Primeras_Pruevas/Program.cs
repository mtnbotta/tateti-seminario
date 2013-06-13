using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            while (true)
            {
                //limpiamos la consola cada vez que se ejecuta el while (clear)
                Console.Clear();
                Console.WriteLine("*****Aplicacion de Prueba******");
                Console.WriteLine("*****1- Cargar Cliente******");
                Console.WriteLine("*****2- Hacerlo Hablar******");
                Console.WriteLine("*****3- Salir******");
                Console.Write("Ingrese una Opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        cliente1.CapturarDatos();
                        break;

                    case 2:
                        cliente1.Hablar();
                        Console.ReadKey();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("ERROR!");
                        break;
                }
                /*
                if (opcion == 1) 
                { 
                    cliente1.CapturarDatos();                   
                }

                else if (opcion == 2)
                {
                    cliente1.Hablar();
                    Console.ReadKey();
                }
                else if (opcion == 3)
                {
                    break;
                }
               
            }
                 */








                /* PRIMERA PRUEBA
                String nombre, apellido = "";
                sbyte edad = 20;
                Console.WriteLine(edad);
                Console.WriteLine("Ingresa tu nombre:");
                nombre = Console.ReadLine();
                //Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Ingresa tu apellido:");
                apellido = Console.ReadLine();
                //Console.WriteLine("Hola " + nombre + " "+ apellido);
                Console.WriteLine("Hola tu nombre es {0} y tu apellido es {1}", nombre,apellido);
            
                 */
                /* SEGUNDA PRUEBA 
                 * USANDO CLASES*/
                /*Saludo misaludo = new Saludo();
                misaludo.CapturarNombre();
                misaludo.CapturarApellido();
                //misaludo.Saludar();
                //misaludo.SaludoFormal();
                misaludo.SaludoFormal("Chango");
                /* TERCERA FORMA UTILIZANDO CONSTRUSTORES SOBRECARGADOS*/
                /*
                Saludo misaludo = new Saludo("Martin","Botta");
                misaludo.SaludoFormal(); 
                */

                //MI FICHA: VARIABLE QUE HACE REFERENCIA A UN OBJEtO!!!!!!!!!!!!!!!!!!!!

                /*mificha.CapturarNombre(); 
                mificha.CapturarApellido(); 
                mificha.CapturarDireccion(); 
                mificha.CapturarLocalidad(); 
                mificha.CapturarTelefono(); 
                mificha.ImprimirFicha();
                 */

                /* Cliente micliente1 = new Cliente();
                //Cliente micliente2 = new Cliente();
                //Cliente micliente3 = new Cliente();
                ///micliente1 es una variable que hace referencia al objeto
                micliente1.CapturarDatos();
                //micliente2.CapturarDatos();
                //micliente3.CapturarDatos();
                micliente1.Hablar();
                //micliente2.Hablar();
                //micliente3.Hablar();
                ///micliente1.ImprimirFicha();


                ///micliente.MostrarNombreCompleto();
                //Console.WriteLine(micliente1.MostrarNombreCompleto());
                //micliente1.ImprimirFicha();
                //Console.WriteLine(micliente2.MostrarNombreCompleto());
                //micliente2.ImprimirFicha();
                ///Console.WriteLine(micliente3.MostrarNombreCompleto());
               // micliente3.ImprimirFicha();
               //micliente1.ImprimirHorizontal();
                //micliente2.ImprimirHorizontal();
                //micliente3.ImprimirHorizontal();
                 * /
                 */





                Console.ReadKey();
            }
        }
    }
}

