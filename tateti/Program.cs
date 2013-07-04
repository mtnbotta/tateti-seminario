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
                juego.PintarTablero();
                if (juego.ComprobarGanador())
                {
                    Console.WriteLine("Existe Un Ganador");
                    Console.ReadLine();
                    return;
                }

                if (fichaActual == 0)
                {
                    //pedimos al usuario que defina la ficha a mover
                    int ficha_a_mover = juego.SeleccionarFicha(jugadorActual);               
                    int posicionElegida = juego.SeleccionarPosicion(jugadorActual, ficha_a_mover);
                    juego.Jugar(jugadorActual, ficha_a_mover, posicionElegida);
                }

                else
                {
                    int posicionElegida = juego.SeleccionarPosicion(jugadorActual, fichaActual);
                    
                    juego.Jugar(jugadorActual, fichaActual, posicionElegida);

                }
                jugadorActual++;



                if (jugadorActual == 3)
                {
                    jugadorActual = 1;
                    // Solucion al problema despues del movimiento 8
                    if (fichaActual>0)
                        fichaActual++;
                    if (fichaActual == 4)
                        fichaActual = 0;
                }
            }
        }
    }
}
