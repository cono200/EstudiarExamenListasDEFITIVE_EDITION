using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTemporalEliminar
{
    public class NodoClase
    {
        //AHORA ES DE TIPO CLASE DE PERSONA
        //PERO EL SIGUIENTE NO CAMBIA
        private Persona _datos {  get; set; }
        private NodoClase _siguiente { get; set; }

        //UTILIZANDO UN CONTRUCTOR PARA USAR LAS VARIALBES PUBLICAS

       public Persona Datos
        {
            get { return _datos; }
            set { _datos = value; }
        }

        public NodoClase Siguiente
        {
            get { return _siguiente;}
            set { _siguiente = value; }
            
        }

        public NodoClase(Persona Datos)
        {
            _datos= Datos;
            Siguiente = null;
        }   

    }
}
