using Clases;

var builder = WebApplication.CreateBuilder(args);

// Configuración personalizada del servidor web para cambiar el puerto
builder.WebHost.UseUrls("http://localhost:5001");

var app = builder.Build();

app.MapGet("/mensaje", () => "Hello World!");

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
app.Run();


