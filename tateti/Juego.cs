using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void Jugar(int jugador, int ficha, int posicion)
        {
            if (jugador == 1)
                tablero.posiciones[posicion] = jugador1.tipoFicha;
            else
                tablero.posiciones[posicion] = jugador2.tipoFicha;
        }
    }
}
