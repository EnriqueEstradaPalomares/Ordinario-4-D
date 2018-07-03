using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario
{
    class LIFO
    {
        private int numero;
        private LIFO siguiente;

        public int dato
        {
            get { return numero; }
            set { numero = value; }
        }

        public LIFO Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public LIFO (int nuevo)
        {
            this.numero = nuevo;
        }
    }
}
