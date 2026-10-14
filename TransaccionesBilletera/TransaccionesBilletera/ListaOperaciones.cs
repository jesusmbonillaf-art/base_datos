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

        public void Adicionar(string dato)
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
        }

        public string Buscar(string codigo)
        {
            Nodo p = inicio;

            while (p != null)
            {
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
