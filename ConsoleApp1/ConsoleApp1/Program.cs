using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número de créditos:");
        int creditos = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el estrato (1, 2 o 3):");
        int estrato = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor por crédito:");
        decimal valorCredito = decimal.Parse(Console.ReadLine());

        var estudiante = new Estudiante(creditos, estrato, valorCredito);

        Console.WriteLine($"Costo matrícula: ${estudiante.CalcularMatricula()}");
        Console.WriteLine($"Subsidio: ${estudiante.CalcularSubsidio()}");

        Console.WriteLine("¿Calcular para otro estudiante? (s/n)");
    } while (Console.ReadLine().ToLower() == "s");
    }
}