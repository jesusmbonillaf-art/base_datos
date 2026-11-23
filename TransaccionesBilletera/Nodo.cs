using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesBilletera
{
    internal class Nodo
    {
        public string info;
        public string codigo;
        public Nodo sgte;
        public Nodo operacion;
        public Nodo izq;
        public Nodo der;
    }
}
