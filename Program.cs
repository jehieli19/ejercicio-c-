using System; 
// Importa el espacio de nombres System para usar Console y Math

public class AreaTriangulo 
// Define una clase llamada AreaTriangulo
{
    public static void Main(string[] args) 
    // Método principal, punto de entrada del programa
    {
        Console.WriteLine("Ingrese los lados del triángulo (a, b, c):"); // Pide al usuario los lados del triángulo
        double a = Convert.ToDouble(Console.ReadLine()); // Lee el lado a y lo convierte a double
        double b = Convert.ToDouble(Console.ReadLine()); // Lee el lado b y lo convierte a double
        double c = Convert.ToDouble(Console.ReadLine()); // Lee el lado c y lo convierte a double

        double p = (a + b + c) / 2; // Calcula el semiperímetro
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
         // Calcula el área usando la fórmula de Herón

        Console.WriteLine("El área del triángulo es: " + area); 
        // Muestra el área calculada
    }
}