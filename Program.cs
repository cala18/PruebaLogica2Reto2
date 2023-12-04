internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el multiplicando:");
        int multiplicando = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el multiplicador:");
        int multiplicador = Convert.ToInt32(Console.ReadLine());
        int resultado = MultiplicacionRusa(multiplicando, multiplicador);
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
    }
    static int MultiplicacionRusa(int multiplicando, int multiplicador)
    {
        int resultado = 0;

        while (multiplicador > 0)
        {
            if (multiplicador % 2 != 0)
            {
                resultado += multiplicando;
            }
            multiplicando *= 2;
            multiplicador /= 2;
        }
        return resultado;

    }
}