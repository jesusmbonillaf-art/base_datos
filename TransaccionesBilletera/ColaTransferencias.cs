using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesBilletera
{
    // Cola (FIFO) de transferencias: se atiende en el mismo orden en que llegaron.
    internal class ColaTransferencias
    {
        public Nodo frente;   // primero en llegar (el próximo a atender)
        public Nodo fin;      // último en llegar (permite encolar en O(1))

        // Encola el código de una transferencia al final de la cola.
        public void Adicionar(string codigo)
        {
            Nodo nuevo = new Nodo();

            nuevo.info = codigo;
            nuevo.sgte = null;

            if (frente == null)
            {
                frente = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.sgte = nuevo;
                fin = nuevo;
            }
        }

        // Desencola y devuelve el código del frente (null si la cola está vacía).
        public string Atender()
        {
            if (frente == null)
            {
                return null;
            }

            string codigo = frente.info;
            frente = frente.sgte;

            if (frente == null)
            {
                fin = null;
            }

            return codigo;
        }

        public bool Vacia()
        {
            return frente == null;
        }

        public int Contar()
        {
            int cantidad = 0;
            Nodo p = frente;

            while (p != null)
            {
                cantidad++;
                p = p.sgte;
            }

            return cantidad;
        }
    }
}