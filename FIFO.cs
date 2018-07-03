using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario
{
    class FIFO
    {
        char caracter;
        FIFO siguiente;

        public char Caracter
        {
            get { return caracter; }
            set { caracter = value; }
        }

        public FIFO Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public FIFO (char caracter)
        {
            this.caracter = caracter;
        }
    }
}
