using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordinario
{
    public partial class Form1 : Form
    {
        string expresion = " ";
        Caracteres fifo = new Caracteres();
        Numeros lifo = new Numeros();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expresion = textBox1.Text;
            for(int i=0; i < expresion.Length; i++)
            {
                fifo.Push = expresion[i].ToString(); ; 
            }

            for (int i = 0; i < expresion.Length; i++)
            {
                if (char.IsNumber(Convert.ToChar(fifo.Peek)))
                {
                    lifo.Push(int.Parse(fifo.Pop));
                }
                else
                {
                    string elemento = fifo.Pop;
                    if (elemento == "s" || elemento == "S")
                        lifo.Push(lifo.Pop() + lifo.Pop());

                    if (elemento == "r" || elemento == "R")
                    {
                        int a = lifo.Pop();
                        lifo.Push(lifo.Pop() - a);
                    }

                    if (elemento == "m" || elemento == "M")
                    {
                        lifo.Push(lifo.Pop() * lifo.Pop());
                    }

                    if (elemento == "d" || elemento == "D")
                    {
                        int a = lifo.Pop();
                        lifo.Push(lifo.Pop() / a);
                    }
                    label1.Text = "";
                    label1.Text = lifo.Peek().ToString();
                }
            }
        }
    }
}
