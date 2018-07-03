using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario
{
    class Caracteres
    {
        //FIFO inicio;
        Queue<string> cola = new Queue<string>();

        public string Peek
        {
            get { return cola.Peek(); }
        }

        public string Pop
        {
            get { return cola.Dequeue(); }
        }

        public string Push
        {
            set { cola.Enqueue(value); }
        }

        //public char Peek()
        //{
        //    if (inicio != null)
        //    {
        //        return inicio.Caracter;

        //    }
        //    else
        //    {
        //        return ' ';
        //    }
        //}

        //public void Push(FIFO nuevo)
        //{
        //    if (inicio == null)
        //    {
        //        inicio = nuevo;
        //    }
        //    else
        //    {
        //        FIFO temp = inicio;
        //        while (temp.Siguiente != null)
        //        {
        //            temp = temp.Siguiente;
        //        }
        //        temp.Siguiente = nuevo;
        //    }
        //}

        //public char Pop()
        //{
        //    if (inicio != null)
        //    {
        //        if (inicio.Siguiente == null)
        //        {
        //            char temp = inicio.Caracter;
        //            inicio = null;
        //            return temp;
        //        }
        //        else
        //        {
        //            char temp = inicio.Caracter;
        //            inicio = inicio.Siguiente;
        //            return temp;
        //        }
        //    }
        //    else
        //    {
        //        return ' ';
        //    }
        //}
    }
}
