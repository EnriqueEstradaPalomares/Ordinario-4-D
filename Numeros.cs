using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinario
{
    class Numeros
    {
        LIFO inicio;

        Stack<int> pila = new Stack<int>();
        public int Peek()
        {
            return pila.Peek();
        }

        public int Pop()
        {
            return pila.Pop(); 
        }

        public void Push (int numero)
        {
            pila.Push(numero);
        }
        //public int Peek()
        //{
        //    if (inicio != null)
        //    {
        //        if (inicio.Siguiente == null)
        //        {
        //            return inicio.dato;
        //        }
        //        else
        //        {
        //            LIFO temp = inicio;
        //            while(temp.Siguiente != null)
        //            {
        //                temp = temp.Siguiente;
        //            }
        //            return temp.dato;
        //        }

        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        //public void Push(LIFO nuevo)
        //{
        //    if(inicio == null)
        //    {
        //        inicio = nuevo;
        //    }
        //    else
        //    {
        //        LIFO temp = inicio;
        //        while (temp.Siguiente != null)
        //        {
        //            temp = temp.Siguiente;
        //        }
        //        temp.Siguiente = nuevo;
        //    }
        //}

        //public int Pop()
        //{
        //    if (inicio != null)
        //    {
        //        if (inicio.Siguiente == null)
        //        {
        //            int temp = inicio.dato;
        //            inicio = null;
        //            return temp;
        //        }
        //        else
        //        {
        //            LIFO temp = inicio;
        //            while (temp.Siguiente.Siguiente != null)
        //            {
        //                temp = temp.Siguiente;
        //            }
        //            int ultimo = temp.Siguiente.dato;
        //            temp = null;
        //            return ultimo;
        //        }
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
