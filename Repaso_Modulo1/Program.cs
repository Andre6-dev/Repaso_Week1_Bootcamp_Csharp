namespace Repaso_Modulo1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================");
        Console.WriteLine("Repaso bucles");
        /*
         * *
         * * *
         * * * *
         * * * * *
         */

        // For loop:
        int i, j, filas;
        Console.WriteLine("Ingresa el numero de filas");
        filas = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= filas; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("Se acabo el bucle");

        /*
         * 1
         * 1 2
         * 1 2 3
         * 1 2 3 4
         */
    }
}
