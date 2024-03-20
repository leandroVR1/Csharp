using Clases;

var builder = WebApplication.CreateBuilder(args);

// Configuración personalizada del servidor web para cambiar el puerto
builder.WebHost.UseUrls("http://localhost:5001");

var app = builder.Build();

/* app.MapGet("/mensaje", () => "Hello World!");

app.MapGet("/calculadora/sumar", () => {
    return Clases.Calculadora.Suma(10, 20);
}); 

app.MapGet("/calculadora/restar", () => {
    return Clases.Calculadora.Resta(20, 10); 
});

app.MapGet("/calculadora/multiplicar", () => {
    return Clases.Calculadora.Multiplicacion(10, 20);
});

app.MapGet("/calculadora/dividir", () => {
    return Clases.Calculadora.Division(10, 20);
});

app.MapGet("/bienvenida",()=>{
    return Clases.MensajeBienvenida.Mensaje("Yeifry","Vargas");
});

app.MapGet("/contador",()=>{
    return Clases.contadorLetras.Letras("palo palo");
});

app.MapGet("/comprobacional", () =>
{
    return verificacionPassword.Contraseña("iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii").ToString(); // Convierte el resultado booleano a string
}); */


//----------------------------------------------------------------
/* app.MapGet("/cliente", () => {
    Cliente cliente = new Cliente();
    return cliente.MostrarDatos();
});

app.MapGet("/salario", () =>
{
    // Crear una instancia de Empleado
    Empleado empleado = new Empleado();
    
    // Cambiar el valor del salario
    empleado.Salario = 2000;

    // Calcular y devolver el salario actualizado
    return empleado.CalcularSalario();
}); */

//----------------------------------------------------------------
app.MapGet("/Animal", () =>
{
    Animal animal = new Animal();
    if(animal.Especie == "Perro")
    {
        Perro perro = new Perro();
        return perro.Ladrar();
    }
    else if(animal.Especie == "Gato")
    {
        Gato gato = new Gato();
        return gato.Maullar();
    }
    else
    {
        return "No se pudo determinar el sonido del animal.";
    }
});





app.Run();