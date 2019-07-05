using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var nuevoStruct = new TestStruct();

            nuevoStruct.cadenaTexto ="Hola";
            nuevoStruct.numero = 1;

            Console.WriteLine($"{nuevoStruct.numero}");

        }
    }
}
