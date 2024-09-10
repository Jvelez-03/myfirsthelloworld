public class Program
{
    private static void Main(string[] args)
    {
    //10. construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números registrados
       
        Console.WriteLine("Hello, World!");

        // aqui ingresamos las variables 
        Console.WriteLine("Ingrese el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        // Declaramos variables para los valores mayor, medio y menor
        int mayor, medio, menor;

        // en esta parte comparamos los números para encontrar el mayor, el medio y el menor
        if (numero1 > numero2 && numero1 > numero3)
        {
            mayor = numero1;
            if (numero2 > numero3)
            {
                medio = numero2;
                menor = numero3;
            }
            else
            {
                medio = numero3;
                menor = numero2;
            }
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            mayor = numero2;
            if (numero1 > numero3)
            {
                medio = numero1;
                menor = numero3;
            }
            else
            {
                medio = numero3;
                menor = numero1;
            }
        }
        else
        {
            mayor = numero3;
            if (numero1 > numero2)
            {
                medio = numero1;
                menor = numero2;
            }
            else
            {
                medio = numero2;
                menor = numero1;
            }
        }

        // en esta parte mostramos los resultados solicitados 
        Console.WriteLine($"El numero mayor es: {mayor}");
        Console.WriteLine($"El numero medio es: {medio}");
        Console.WriteLine($"El numero menor es: {menor}");
    }
}