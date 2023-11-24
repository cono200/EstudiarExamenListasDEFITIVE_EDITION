using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTemporalEliminar
{
    public class ListaPersona
    {
        public NodoClase primerNodo;
        public NodoClase ultimoNodo;


        //INICIALIZANDO LA LISTA
        public ListaPersona()
        {
            primerNodo = null;
            ultimoNodo = null;
        }

        //METODO DE CHECAR SI LA LISTA ESTA VACIA
        public bool ListaVacia()
        {
            return primerNodo == null;
        }

        //METODO PARA INSERTAR AL INICIO
        //EL CUAL SE DEBE DE HACER UNA INSTANCIA DE LA CLASE PERSONA
        //POR QUE RECORDAR EN CLASE PERSONA SE GUARDARAN LOS DATOS
        public void InsertarInicio(Persona persona)
        {
            NodoClase nuevoNodo = new NodoClase(persona);
            if (ListaVacia())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                //SE DEBE DE USAR EL NUEVO NODO
                nuevoNodo.Siguiente = primerNodo;
                primerNodo = nuevoNodo;
            }
        }

        public void InsertarFinal(Persona persona)
        {
            NodoClase nuevoNodo = new NodoClase(persona);
            if (ListaVacia())
            {
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                ultimoNodo.Siguiente = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
        }

        public void Imprimir()
        {
            NodoClase actual= primerNodo;
            while (actual != null)
            {
                Console.WriteLine("EL nombre es :  " + actual.Datos._nombre);
                Console.WriteLine("La edad es: " + actual.Datos._edad);
                actual = actual.Siguiente;
            }
        }
        
    }
}
