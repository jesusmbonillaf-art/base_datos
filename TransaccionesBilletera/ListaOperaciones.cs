using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesBilletera
{
    internal class ListaOperaciones
    {
        public Nodo inicio;
        public int comparaciones;   // nodos revisados en la última búsqueda

        // Agrega al final y devuelve el nodo creado (el árbol lo indexa).
        public Nodo Adicionar(string dato)
        {
            Nodo nuevo = new Nodo();

            nuevo.info = dato;
            nuevo.sgte = null;

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo p = inicio;

                while (p.sgte != null)
                {
                    p = p.sgte;
                }

                p.sgte = nuevo;
            }

            return nuevo;
        }

        public string Buscar(string codigo)
        {
            comparaciones = 0;
            Nodo p = inicio;

            while (p != null)
            {
                comparaciones++;

                string[] datos = p.info.Split('|');

                if (datos[0] == codigo)
                {
                    return p.info;
                }

                p = p.sgte;
            }

            return null;
        }

        public int Contar()
        {
            int cantidad = 0;
            Nodo p = inicio;

            while (p != null)
            {
                cantidad++;
                p = p.sgte;
            }

            return cantidad;
        }
    }
}