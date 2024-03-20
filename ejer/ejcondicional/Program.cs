// See https://aka.ms/new-console-template for more information
//Ej1
/* Console.WriteLine("Digite un numero: ");
int num1= int.Parse(Console.ReadLine());

Console.WriteLine("Digite otro numero: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 % 2 == 0 && num2 % 2 == 0)
{
    Console.WriteLine("Ambos numeros son pares");
}else{
    Console.WriteLine("Ambos no son Pares");
} */

//Ej2
/* Console.WriteLine("Digite 'M' para masculino y 'F' para femenino");
string? genero = Console.ReadLine();
Console.WriteLine("Digite la edad: ");
int edad = int.Parse(Console.ReadLine());

if ((genero == "M" && edad >= 60) || (genero == "F" && edad >=55))
{
    Console.WriteLine("Es elegible para jubilarse");
}else{
    Console.WriteLine("No es elegible para jubilarse");
} */

//Ej3
/* Console.WriteLine("Digite un año para determinar si es bisiesto");
int año = int.Parse(Console.ReadLine());

if (año % 4 == 0 && año % 100!= 0 || año % 400 == 0)
{
    Console.WriteLine($"El año {año} es bisiesto");
}else{
    Console.WriteLine("El año no es bisiesto");
} */

//Ej4
/* Console.WriteLine("Digite nombre: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Digite edad: ");
int edad =int.Parse(Console.ReadLine());

if(edad < 18 || edad > 60)
{
    Console.WriteLine($"{nombre} tienes derecho del descuento");
}else
{
    Console.WriteLine($"{nombre} no tienes derecho del descuento");
}
 */

//Ej5
/* Console.WriteLine("Digite Usuario: ");
string? usuario = Console.ReadLine();

Console.WriteLine("Digite contraseña: ");
string? contraseña = Console.ReadLine();

if (usuario == "admin" && contraseña == "1234")
{
    Console.WriteLine("Bienvenido Administrador");
}else{
    Console.WriteLine("Usuario o contraseña incorrectos");
}
 */

//Ej6
/* Console.WriteLine("Digite un numero: ");
int num1= int.Parse(Console.ReadLine());

Console.WriteLine("Digite otro numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite un tercer numero: ");
int num3 = int.Parse(Console.ReadLine());

if(num1<0 ||num2<0 ||num3<0)
{
    Console.WriteLine("Almenos un numero es negativo");
}else
{
    Console.WriteLine("No hay ningun numero negativo");
} */



//Ej7
//Conversion de Celsius a Fahrenheit
/* Console.WriteLine("Digite una temperatura en Celcius para hacer conversion a Fahrenheit:");
int celsius = int.Parse(Console.ReadLine());

double formula = (1.8 * celsius)+32;
Console.WriteLine(formula+"°"); */

//e



//Ej8
/* Console.WriteLine("Digite el numero del mes que desea consultar");
int mes = int.Parse(Console.ReadLine());

if(mes>0 && mes<=12)
{
    if(mes==10)
    {
        Console.WriteLine("Este mes corresponde a hallowen");
    }
    else if(mes==12){
        Console.WriteLine("Este mes corresponde a navidad");
    }else{
        Console.WriteLine("No hay ninguna festividad");
    }
}else{
    Console.WriteLine("El mes introducido no es valido");
} */


//Ej10
/* using System.Data;

Console.WriteLine("Triangulo");
Console.WriteLine("Digite el lado 1 del triangulo");
double lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite el lado 2 del triangulo");
double lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite el lado 3 del triangulo");
double lado3 = double.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1== lado3)
{
    Console.WriteLine("El triangulo es equilatero");
}
//isoceles
if((lado1==lado2 && lado2!=lado3) || (lado1==lado3 && lado1!=lado2) || (lado3==lado2 && lado3 != lado1) )
{
    Console.WriteLine("El triangulo es isósceles");
}
//escaleno
if (lado1 != lado2 && lado1!= lado3 && lado2!= lado3) 
{
    Console.WriteLine("El triangulo es escaleno");
}
 */

//Ej12
/* Console.WriteLine("Ingrese el precio del producto");
double precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de descuento apicable");
double porcentaje = double.Parse(Console.ReadLine());
double descuento = (precio * porcentaje)/100;
Console.WriteLine($"El valor a pagar es de {descuento}"); */


//Ej 13
/* Console.WriteLine("Ingrese el Valor 1");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el Valor 2");
int valor2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el Valor 3");
int valor3 = int.Parse(Console.ReadLine());

double operacion = (valor1 + valor2) * valor3;
            if(valor1 == valor2 && valor2==valor3)
            {
                Console.WriteLine(operacion);
            }else
{
    Console.WriteLine("Los valores no son iguales");
            } */

//Ej 14
/* Console.WriteLine("Ingrese el Valor equivale su sueldo");
int sueldo = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese los años de antiguedad");
int antiguedad = int.Parse(Console.ReadLine());
double sueldoActual=0;
int aumento=0;
if((sueldo<500) && (antiguedad>=10)){
    sueldoActual = ((sueldo * 20)/100)+sueldo;
    aumento = 20;
}else if((sueldo<500) && (antiguedad < 10)){
    sueldoActual = ((sueldo * 5)/100)+sueldo;
    aumento = 5;
}else{
    Console.WriteLine($"Su sueldo es igual a {sueldoActual}");
}
    Console.WriteLine($"Tienes un aumento del {aumento} Su sueldo es igual a {sueldoActual}"); */


/*dynamic dyn = 1;
object obj = 1;

Console.WriteLine(dyn);
Console.WriteLine(dyn.GetType());

Console.WriteLine(obj);
Console.WriteLine(obj.GetType());

dyn = dyn + 3;*/

static void  Hola(){
    Console.WriteLine("Hola");
}
Hola();
