using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti
{
    class Program
    {
        public static void Main(string[] args)
        {
            // declaramos e inicializamos los objetos
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador ("X");
            Jugador jugador2 = new Jugador("O");
            // iniciamos las variables
            int jugador_actual = 1;
            int ficha_actual = 1;
            // iniciamos un bucle que dure indefinidamente hasta que el juego finalice
            while (true)
            {
                tablero.PintarTablero();
                if (ficha_actual == 0)
                {
                    Console.Write("Jugador {0}: ingrese el numero de ficha a mover", jugador_actual);
                    ficha_actual = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Jugador {0}: ingrese posicion para la ficha {1}: ", jugador_actual, ficha_actual);
                int pocicion_elegida = Convert.ToInt32(Console.ReadLine());
                // Imprimiendo el tipo de ficha apropiado segun el jugador actual ("X" o "O")
                if (jugador_actual == 1)
                    tablero.posiciones[pocicion_elegida] = jugador1.tipo_ficha;
                else
                    tablero.posiciones[pocicion_elegida] = jugador2.tipo_ficha;
                jugador_actual++;

                if (jugador_actual == 3)
                {
                    jugador_actual = 1;
                    ficha_actual++;
                    if (ficha_actual == 4)
                    {
                        ficha_actual = 0;
                    }

                }
            }

            Console.ReadLine();
        }
        
            
        
    }
}
