using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti
{
    class Tablero
    {

	// declarando el diccionario hash q manejara las pociciones del tablero
        public Hashtable posiciones;
	
	// metodo construcctor que inicializa las pociciones con un valor vacio
        public Tablero()
        {
            posiciones = new Hashtable();
            for (int x = 1; x < 10; x++)
                posiciones.Add(x, " ");
        }
        
        public void PintarTablero()
        {
            Console.Clear();

            for (int x = 1; x < 10; x++)
            {
                Console.Write("[{0}]", posiciones[x]);
                //comprovamos si se imprimieron 3 posiciones y hacemos un salto de lina
                if (x % 3 == 0)
                    Console.Write("\n");
            }
        }
    }
}
