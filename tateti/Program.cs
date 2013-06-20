using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Tablero más groso de TaTeTi...!!\n");

            //Inicializamos las variables.
            int jugadorActual = 1, fichaActual = 1;
            Juego juego = new Juego();
            

            

            //Iniciamos un bucle que dure indefinidamente, hasta que el juego finalice.
            while (true)
            {
                juego.tablero.PintarTablero();

                if (fichaActual == 0)
                {
                    Console.Write("Jugador {0}: Ingrese el número de ficha a mover: ", jugadorActual);
                    fichaActual = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Jugador {0}: Digame que posición pondrá la ficha \"{1}\": ", jugadorActual, fichaActual);

                int posicionElegida = Convert.ToInt32(Console.ReadLine());

                juego.Jugar(jugadorActual, fichaActual, posicionElegida);

                jugadorActual++;

                if (jugadorActual == 3)
                {
                    jugadorActual = 1;
                    fichaActual++;
                    if (fichaActual == 4)
                        fichaActual = 0;
                }
            }
        }
    }
}
