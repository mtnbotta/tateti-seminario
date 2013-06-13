using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace tateti
{   
    class Jugador
    {
        public string tipo_ficha;
        public Hashtable fichas;

        public Jugador(string tipoficha)
        {
            fichas = new Hashtable();
            tipo_ficha = tipoficha;
            fichas.Add(1,0);
            fichas.Add(2,0);
            fichas.Add(3,0);

        }

    }
}
