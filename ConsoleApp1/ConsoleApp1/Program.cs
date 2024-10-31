internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número de créditos:");
        int creditos = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el estrato (1, 2 o 3):");
        int estrato = int.Parse(Console.ReadLine());
    }
}