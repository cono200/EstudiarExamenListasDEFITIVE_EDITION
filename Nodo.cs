using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTemporalEliminar
{
    public class Nodo
    {
        private int _valor;
        private Nodo? _siguiente;

        public Nodo(int Valor)
        {
            _valor = Valor;
            _siguiente = null;
        }
        public Nodo(int Valor, Nodo Siguiente)
        {
            _valor = Valor;
            _siguiente = Siguiente;
        }
        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }








    }
}
