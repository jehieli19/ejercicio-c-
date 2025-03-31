
using System; 

public class MultiplicarPorDos 
 {
    public static void Main(string[] args) 
    {
        Console.WriteLine("Ingrese un número :"); 
        int numero = Convert.ToInt32(Console.ReadLine()); 

        int resultado = numero * 2; 
        Console.WriteLine("El resultado de multiplicar por 2 es: " + resultado); 
    }
}