public class Program
{
    private static void Main(string[] args)
    {
    //10. construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números registrados
       
        Console.WriteLine("Hello, World!");

        // aqui ingresamos las variables 
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Declaramos variables para los valores mayor, medio y menor
        int mayor, medio, menor;

        // en esta parte comparamos los números para encontrar el mayor, el medio y el menor
        if (num1 > num2 && num1 > num3)
        {
            mayor = num1;
            if (num2 > num3)
            {
                medio = num2;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            mayor = num2;
            if (num1 > num3)
            {
                medio = num1;
                menor = num3;
            }
            else
            {
                medio = num3;
                menor = num1;
            }
        }
        else
        {
            mayor = num3;
            if (num1 > num2)
            {
                medio = num1;
                menor = num2;
            }
            else
            {
                medio = num2;
                menor = num1;
            }
        }

        // en esta parte mostramos los resultados solicitados 
        Console.WriteLine($"El mayor es: {mayor}");
        Console.WriteLine($"El número intermedio es: {medio}");
        Console.WriteLine($"El menor es: {menor}");
    }
}