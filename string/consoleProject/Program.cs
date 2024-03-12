
using System.Globalization;

/* string stringSencillo= "esto es un string sencillo";
Console.WriteLine(stringSencillo);

string stringSinEscape= "Esta es una ruta window C:\\Public";
Console.WriteLine(stringSinEscape);

string stringConCaracteresEspeciales= @"Esta es una ruta en window C:\\Public";
Console.WriteLine(stringConCaracteresEspeciales);

char[] chars = {'w','o','r','d'};

string stringConstructor = new string(chars);
Console.WriteLine(stringConstructor);

string stringRepetido = new string('c',10);
Console.WriteLine(stringRepetido);
Console.WriteLine('c'*10);

string stringConcatenado = "Hoy es: " + DateTime.Now;
Console.WriteLine(stringConcatenado);

string concatenarStrings = "frase 1" + "frase 2" + "frase 3" ;
Console.WriteLine(concatenarStrings);

string oracion = "Ingrese otra oracion";
int posicion = oracion.IndexOf(" ") + 1;
int nuevePosicion = oracion.IndexOf(" ",posicion);
Console.WriteLine(nuevePosicion);
string nuevaPalabra = oracion.Substring(posicion,nuevePosicion - posicion);
int cantidad = nuevaPalabra.Length;
Console.WriteLine(cantidad);
Console.WriteLine(nuevaPalabra); */


//-----------------
/* DateTime fecha = new DateTime(2024, 3, 8, 16, 6, 12);//DateTime.Now
double temperatura = 28.5;
string[] estados =["despejado","nublado","lluvioso"];

string resultado = String.Format("A las {1:t} en {1:D}, la temperatura fue {0:F3} Celsius con cielo {2}",temperatura, fecha, estados[1]);
Console.WriteLine(resultado); */



//--------------------
/* string stringPrueba = "          ";
if(stringPrueba == null || stringPrueba.Equals(String.Empty))
{
    Console.WriteLine("El campo es nulo o esta vacio");

}

bool nuloVacio = String.IsNullOrEmpty(stringPrueba);
Console.WriteLine(nuloVacio);

if(stringPrueba == null || stringPrueba.Equals(string.Empty) || stringPrueba.Trim().Equals(String.Empty)) 
{
    Console.WriteLine("El campo es nulo o tiene espacios en blanco");

}

bool whitespace = String.IsNullOrWhiteSpace(stringPrueba);
Console.WriteLine(whitespace); */


//-------------------------------------Ordenar de forma alfabetica
string[] estudiantes = ["Carlos", "Pedro", "Juan", "ana"];
Array.Sort(estudiantes/*,StringComparer.Ordinal tiene en cuenta las mayusculas */);
int valorAscci = Console.Read();
Console.WriteLine(valorAscci);
foreach(var estudiante in estudiantes)
{
    Console.WriteLine(estudiante);
}


//-----------------------------------------------
DateTime fecha = DateTime.Now;
CultureInfo[] culturas= {
    CultureInfo.InvariantCulture,
    new CultureInfo("en-US"),
    new CultureInfo("es-ES")
};

foreach(var cultura in culturas)
{
    Console.WriteLine("{0} {1}",
    string.IsNullOrEmpty(cultura.Name) ? "Invariant" :cultura.Name,
    fecha.ToString("d", cultura)
    );
}






