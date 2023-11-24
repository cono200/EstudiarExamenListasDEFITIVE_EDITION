namespace ListaTemporalEliminar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSimple listaSimple1 = new ListaSimple();

            //listaSimple1.InsertarInicio(10);
            //listaSimple1.InsertarFinal(2);

            //listaSimple1.ImprimirLista();

            ListaPersona listaPersona1 = new ListaPersona();
            //EN CADA UNO SE TIENE QUE HACER UNA NUEVA INSTANCIA DE LA CLASE PERSONA
            listaPersona1.InsertarInicio(new Persona("asdd","10"));
            listaPersona1.InsertarInicio(new Persona("qwqqw", "10"));
            listaPersona1.InsertarInicio(new Persona("ewe", "10"));
            listaPersona1.InsertarInicio(new Persona("uwu", "10"));
            listaPersona1.InsertarFinal(new Persona("zzzzz", "12122"));
            listaPersona1.InsertarFinal(new Persona("aazzzzzzzaaa", "12121"));

            listaPersona1.Imprimir();



        }
    }
}