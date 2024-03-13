/* using System;

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
 */



OperationClass.Operation add = (x,y) => x + y;
OperationClass.Operation subtract = (x,y) => x - y;
OperationClass.Operation multiply = (x,y) => x * y;

List<int> numbers = new List<int>{1,2,3,4,5};

Func<List<int>, OperationClass.Operation, int> applyOperation = (list, operation) =>{
    int result = list[0];
    for (int i = 1; i < list.Count; i++)
    {
        result = operation(result, list[i]);
    }
    return result;
};

int additionResult = applyOperation(numbers, add);
Console.WriteLine("El resultado de la operación add es " + additionResult);

int subtractionResult = applyOperation(numbers, subtract);
Console.WriteLine("El resultado de la operación subtract es " + subtractionResult);

int multiplicationResult = applyOperation(numbers, multiply);
Console.WriteLine("El resultado de la operación multiply es " + multiplicationResult);
class OperationClass{
    public delegate int Operation(int x, int y);    
}