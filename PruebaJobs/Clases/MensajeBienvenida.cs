using System;
namespace Clases {
   /*  public class MensajeBienvenida {
        public static string Mensaje(string nombre, string apellido) =>
            $"Hola Bienvenido {nombre} {apellido}!";
    }
    
    public class contadorLetras {
        public static int Letras(string palabra) =>
            palabra.Length;
    }

   public class verificacionPassword {
        public static bool Contraseña(string contraseña) {
            if (contraseña.Length <= 10) {
                Console.WriteLine("¡La contraseña cumple con la condición!");
                return true;
            } else {
                Console.WriteLine("¡La contraseña NO cumple con la condición!");
                return false;
            }
        }
    } */


    //------------------------------------------------------------------------------------------------
    
//heredar
 /*    public class Empleado : Persona {  
        
       
       public int Salario=1000000;
        public int Codigo_Empleado = 0;

           public string CalcularSalario(){
            return $"su salario es de: {Salario}";
            
           }



     
}

    public class Persona{
        public string Nombre = "leandro";
        public string Apellido = "vargas";

        public string Correo = "yeifry.@example.com";

        public int Edad = 22;
        public string MostrarDatos(){
            return $"Nombre: {Nombre} Apellido: {Apellido} Correo: {Correo} Edad: {Edad}";
        }
        public string actualizarDatos(){
            return $"Nombre: {Nombre} Apellido: {Apellido} Correo: {Correo} Edad: {Edad}";
        }

       

    }

    public class Cliente: Persona {
      
        public string tipoCliente = "Tipo Cliente";
        public int puntos=10;

        
        public string calcularPuntos(){
            return $"Nombre: {Nombre} Apellido: {Apellido} Correo: {Correo} Edad: {Edad} tipoCliente: {tipoCliente} puntos: {puntos}";
        }
    }
}

 */
//------------------------------------------------------------------------------------------------
public class Perro: Animal {
  
  public string Ladrar() {
   
      return "Ladrando";
    
  }

}

public class Gato: Animal {

    public string Maullar() {

     return "Maulleando";
   
    }
}


public class Animal{
    public string Especie = "Gato";
    public string Raza = "Animal";
    public string Color="Rojo";
    public int Edad = 4;
    public string Sexo ="Masculino";
    public double Altura =25.5;



}
}
