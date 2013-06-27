using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti
{
    class Tablero
    {
        //Declarando diccionario hash que manejará las posiciones del tablero.
        public Hashtable posiciones;

        //Constructor que inicializa las posiciones en un valor vacío
        public Tablero()
        {
            posiciones = new Hashtable();

            for (int i = 1; i < 10; i++)
                posiciones.Add(i, "  ");
        }

        public void Limpiar()
        {
            for (int i = 1; i < 10; i++)
                posiciones[i]= "  ";
        }

        public bool ControlPosicionVacia(int posicion)
        {
            if (posiciones[posicion] == "  ")
            {
                return true;
            }
            return false;
        }

        public void PintarTablero()
        {
            Console.Clear();

            for (int i = 1; i < 10; i++)
            {
                Console.Write("[ {0} ] ", posiciones[i]);

                //Comprobamos si "i" es módulo de 3, imprimo un salto de linea
                if (i % 3 == 0)
                    Console.Write("\n");
            }
        }
    }
}
