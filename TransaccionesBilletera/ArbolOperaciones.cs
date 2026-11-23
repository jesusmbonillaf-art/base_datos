using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesBilletera
{
    // Árbol binario de búsqueda ordenado por código de operación.
    // Funciona como índice: encuentra una operación sin recorrer toda la lista.
    internal class ArbolOperaciones
    {
        public Nodo raiz;
        public int comparaciones;   // comparaciones hechas en la última búsqueda

        public void Insertar(string codigo, Nodo operacion)
        {
            Nodo nuevo = new Nodo();

            nuevo.codigo = codigo;
            nuevo.operacion = operacion;
            nuevo.izq = null;
            nuevo.der = null;

            if (raiz == null)
            {
                raiz = nuevo;
                return;
            }

            Nodo p = raiz;

            while (true)
            {
                int cmp = string.CompareOrdinal(codigo, p.codigo);

                if (cmp == 0)
                {
                    return;   // el código ya existe: no se duplica
                }

                if (cmp < 0)
                {
                    if (p.izq == null)
                    {
                        p.izq = nuevo;
                        return;
                    }

                    p = p.izq;
                }
                else
                {
                    if (p.der == null)
                    {
                        p.der = nuevo;
                        return;
                    }

                    p = p.der;
                }
            }
        }

        // Devuelve el nodo de la lista con la operación, o null si no existe.
        public Nodo Buscar(string codigo)
        {
            comparaciones = 0;
            Nodo p = raiz;

            while (p != null)
            {
                comparaciones++;

                int cmp = string.CompareOrdinal(codigo, p.codigo);

                if (cmp == 0)
                {
                    return p.operacion;
                }

                if (cmp < 0)
                {
                    p = p.izq;
                }
                else
                {
                    p = p.der;
                }
            }

            return null;
        }
    }
}