using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTemporalEliminar
{
    public  class Persona
    {
        public string _nombre { get; set; }
        public string _edad {  get; set; }  

        //HACIENDO UN CONTRUCTOR PARA UTILIZAR 
        //VARIABLES PUBLICAS SIN USAR LAS ORIGINALES
        public Persona(string nombre, string edad)
        {
            _nombre = nombre;
            _edad = edad;
        }




    }
}
