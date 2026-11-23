using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesBilletera
{
    internal class PilaReversiones
    {
        public Nodo cima;

        public void Apilar(string codigo)
        {
            Nodo nuevo = new Nodo();

            nuevo.info = codigo;
            nuevo.sgte = cima;

            cima = nuevo;
        }

        public string Desapilar()
        {
            if (cima == null)
            {
                return null;
            }

            string codigo = cima.info;
            cima = cima.sgte;

            return codigo;
        }

        public bool Vacia()
        {
            return cima == null;
        }

        public int Contar()
        {
            int cantidad = 0;
            Nodo p = cima;

            while (p != null)
            {
                cantidad++;
                p = p.sgte;
            }

            return cantidad;
        }
    }
}
