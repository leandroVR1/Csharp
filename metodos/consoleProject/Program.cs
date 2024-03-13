using System;

namespace consoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Juan", 30);
            Person persona2 = persona1;
            persona1.Saludo();

            persona2.Name = "Pedro";
            Console.WriteLine(persona1.Name);
            Console.WriteLine(persona2.Name);
            Console.WriteLine(persona2.Age);

            Console.WriteLine(OperacionesMatematicas.Suma(5, 4));
        }
    }
}
