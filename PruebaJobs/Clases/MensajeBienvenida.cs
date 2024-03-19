namespace Clases {
    public class MensajeBienvenida {
        public static string Mensaje(string nombre, string apellido) =>
            $"Hola Bienvenido {nombre} {apellido}!";
    }
    
    public class contadorLetras {
        public static int Letras(string palabra) =>
            palabra.Length;
    }

     public class verificacionPassword{
        public static bool Contraseña(string contraseña) =>
        if (contraseña.Length <=10)
        {
            return true;
        }
    }
}
