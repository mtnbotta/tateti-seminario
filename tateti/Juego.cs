using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti
{
    class Juego
    {
        //Declaramos los objetos.
        public Tablero tablero;
        public Jugador jugador1;
        public Jugador jugador2;

        public Juego()
        {
            //Inicializamos los objetos.
            tablero = new Tablero();
            jugador1 = new Jugador("X");
            jugador2 = new Jugador("O");
        }

        public int SeleccionarFicha(int jugador)
        {
            int ficha_a_mover = 0;
            
            do
            {
                Console.Write("Jugador {0}: Ingrese el número de ficha a mover: ", jugador);
               
                try
                {
                    ficha_a_mover = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    ficha_a_mover=0;
                }

                if (ficha_a_mover<1||ficha_a_mover>3)
                {
                    Console.WriteLine("Error, Ficha No Válida");
                    Console.ReadLine();
                }

            } while (ficha_a_mover<1||ficha_a_mover>3);
            
            return ficha_a_mover;
        }

        public int SeleccionarPosicion(int jugador, int ficha)
        {
            int posicionElegida=0;
            
            do
            {
                Console.Write("Jugador {0}: Digame que posición pondrá la ficha \"{1}\": ", jugador, ficha);
                try
                {
                    posicionElegida = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    posicionElegida = 0;
                }
                               
                if (posicionElegida<1||posicionElegida>9)
                {
                    Console.WriteLine("Error, Posicion No Válida");
                    Console.ReadLine();
                }

                if (!tablero.ControlPosicionVacia(posicionElegida))
                {
                    Console.WriteLine("Error, Posicion Ocupada");
                    Console.ReadLine();
                    posicionElegida = 0;
                }

                if (!ControlMovimientoValido(posicionElegida, jugador, ficha))
                {
                    Console.WriteLine("Error, Movimiento No Valido");
                    Console.ReadLine();
                    posicionElegida = 0;
                }


            } while (posicionElegida < 1 || posicionElegida > 9);
            
            return posicionElegida;
        }

        public bool ControlMovimientoValido(int posicion_elegida, int jugador, int ficha)
        {
            int posicion_previa = 0;
            // tomamos el valor de la posicion donde estaba previamente la ficha
            if (jugador == 1)
                posicion_previa = (int)jugador1.fichas[ficha];
            else
                posicion_previa = (int)jugador2.fichas[ficha];
           //si pocision previa es igual a cero, no existen movimientos no validos
            if (posicion_previa == 0)
                return true;
            if (posicion_previa == 1 && (posicion_elegida == 2 || posicion_elegida == 4 || posicion_elegida == 5))
                return true;
            if (posicion_previa == 2 && (posicion_elegida == 1 || posicion_elegida == 3 || posicion_elegida == 5))
                return true;
            if (posicion_previa == 3 && (posicion_elegida == 2 || posicion_elegida == 5 || posicion_elegida == 6))
                return true;
            if (posicion_previa == 4 && (posicion_elegida == 1 || posicion_elegida == 5 || posicion_elegida == 7))
                return true;
            if (posicion_previa == 5 && (posicion_elegida != 5))
                return true;
            if (posicion_previa == 6 && (posicion_elegida == 3 || posicion_elegida == 5 || posicion_elegida == 9))
                return true;
            if (posicion_previa == 7 && (posicion_elegida == 4 || posicion_elegida == 5 || posicion_elegida == 8))
                return true;
            if (posicion_previa == 8 && (posicion_elegida == 5 || posicion_elegida == 7 || posicion_elegida == 9))
                return true;
            if (posicion_previa == 9 && (posicion_elegida == 5 || posicion_elegida == 6 || posicion_elegida == 8))
                return true;
            
            return false;
        }


        public void PintarTablero()
        {
            tablero.Limpiar();

            foreach (DictionaryEntry ficha in jugador1.fichas)
            {
                //Grabamos la posicion de la ficha del jugador en el tablero, sumandole el numero de ficha
                tablero.posiciones[ficha.Value] = jugador1.tipoFicha + ficha.Key.ToString();
            }

            foreach (DictionaryEntry ficha in jugador2.fichas)
            {
                //Grabamos la posicion de la ficha del jugador en el tablero, sumandole el numero de ficha
                tablero.posiciones[ficha.Value] = jugador2.tipoFicha + ficha.Key.ToString();
            }

            tablero.PintarTablero();
        }

        
        public void Jugar(int jugador, int ficha, int posicion)
        {
            if (jugador == 1)

                jugador1.fichas[ficha] = posicion;
            else
                jugador2.fichas[ficha] = posicion;
        }
    }
}
