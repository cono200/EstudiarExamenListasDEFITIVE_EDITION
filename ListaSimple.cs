using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTemporalEliminar
{
    public class ListaSimple
    {
        Nodo primerNodo;
        Nodo ultimoNodo;

        public ListaSimple()
        {
            //ESTO ES PARA CREAR UNA LISTA VACIA
            primerNodo = ultimoNodo = null;
        }
        public bool ListaVacia()
        {
           return (primerNodo == null);
        }

        public int LongitudLista()
        {
            int contador = 0; //PARA VER CUANTAS VECES SE RECORRE
            Nodo actual = primerNodo; //HACIENDO UN ACTUAL PARA SABER ON TOI

            while(actual != null) //MIENTRAS QUE EL SIGUIENTE NUMERO
                //SEA DIFERENTE DE NULLO (ES DECIR QUE HAIGA)
                //VA A ENTRAR AKI PARA CONTAR CUANTAS VECES ENTRO
            {
                contador++;
                //RECORRIENDO LA LISTA 
                actual = actual.Siguiente;
            }
            return contador; //RETORNANDO EL CONTADOR 
            //Y ASI SABEMOS CUANTO ES LA LONGITUD
        }

        public void InsertarInicio(int elemento)
        {
            //HACIENDO UNA INSTANCIA NODO PARA INSERTAR
            Nodo nuevoNodo = new Nodo(elemento);


            if (ListaVacia())
            {
                //COMO TENEMOS LA LISTA VACIA NO TENEMOS SEGUNDO NUMERO
                //LO QUE FACILITA YA QUE EL PRIMERO VA A HACER EL PRIMERO
                //Y EL ULTIMO, EN OTRAS PALABRAS
                //EL NUMERO DEL PRIMERO SERA AL NUEVO NODO
                
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                //EL NUMERO QUE TIENE ACTUAL EL NODO
                //VA A HACER IGUAL AL SIGUIENTE Y SE GUARDARA
                //EN PRIMER NODO
                nuevoNodo.Siguiente = primerNodo;
            }
        }


        public void InsertarFinal(int elemento)
        {
            Nodo nuevoNodo = new Nodo(elemento);
            if (ListaVacia())
            {

                //ES EXACTAMENTE LO MISMO QUE INSERTAR AL INICIO
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
            else
            {
                
                ultimoNodo.Siguiente = nuevoNodo;
                ultimoNodo = nuevoNodo;
            }
        }


        


            public void ImprimirLista()
        {
            //HACEMOS UN NODO ACTUAL QUE SERA AL PRIMERO NOOD
            //PARA USARLO COMO VARIABLE TEMPORAL
            Nodo actual = primerNodo;

            //SI ESTA VACIA MANDAMOS UN MENSAJE DICIENDO 
            //LO MISMO
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia karnal");
            }
            else
            {
                while (actual != null)
                {
                    //IMPRIMIENDO EL VALOR QUE TIENE EL NODO
                    Console.WriteLine(actual.Valor);
                    //MOVIENDOSE AL SIGUIENTE NUMERO DE LA LISTA
                    actual = actual.Siguiente;
                }
            }
        }


        public void BuscarNumero(int buscarNumero)
        {
            bool encontrado = false;
            if (ListaVacia())
            {
                Console.WriteLine("La lista esta vacia karnal");
            }
            else
            {
                Nodo actual = primerNodo;
                while (actual != null)
                {
                    //SIEMPRE EL ACTUAL.VALOR TIENE EL VALOR ACTUAL
                    if (actual.Valor == buscarNumero)
                    {
                        encontrado = true;
                        break;
                    }
                    else
                    {
                        //MOVIENDOSE AL SIGUIENTE NUMERO
                        actual = actual.Siguiente;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("El numero no se encuentra ");
                }
            }
            
        }






    }
}
