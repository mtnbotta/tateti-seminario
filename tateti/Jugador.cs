using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti
{
    class Jugador
    {
        //Declaración de la propiedad que almacena el tipo de ficha del jugador.
        public string tipoFicha;
        public Hashtable fichas;
        public Hashtable posiciones;

        public Jugador(string ficha)
        {
            tipoFicha = ficha;

            fichas = new Hashtable();
            fichas.Add(1, 0);
            fichas.Add(2, 0);
            fichas.Add(3, 0);

            posiciones = new Hashtable();
            posiciones.Add(1, 0);
            posiciones.Add(2, 0);
            posiciones.Add(3, 0);
        }
    }
}
