using System;
using System.Collections;
using System.Linq;

namespace pilas_actualizarelemento
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cambiando elementos de una Pila");      
            // Mi pila
            Stack miPila = new Stack();
            miPila.Push("hola");
            miPila.Push("buenos");
            miPila.Push("días");
            // Datos actuales de la pila
            Console.WriteLine("Datos actuales");
            foreach (string items in miPila)
            {                         
                Console.WriteLine(items);
            }

            // Datos nuevos
            string reemplazar = ""; // Escribir palabra a reemplazar
            string nuevaPalabra = ""; // Escribir palabra nueva
            Console.WriteLine("Escriba la palabra a reemplazar");
            reemplazar = Console.ReadLine();
            Console.WriteLine("Escriba la nueva palabra");
            nuevaPalabra = Console.ReadLine();
            // pasamos nuestra pila a un array
            object[] miPilaArray = miPila.ToArray();
            string palabraAntigua = ""; // para obtener los de la pila por metodo Pop()
            for (int i = 0; i < miPilaArray.Length; i++) {
                palabraAntigua = (string)miPila.Pop(); // Obtenemos los datos de la pila
                if (palabraAntigua == reemplazar) { // verificamos los datos si coinciden
                    miPila.Push(nuevaPalabra);// agregamos los nuevos
                    break; // detenemos 
                }
            }
            Console.WriteLine("*************");
            Console.WriteLine("Palabra "+ reemplazar + " Reemplazada por "+nuevaPalabra);
            // Mostramos el dato reemplazado
            foreach (string items in miPila) {
                Console.WriteLine(items);
            }
     
        }
    }
}
