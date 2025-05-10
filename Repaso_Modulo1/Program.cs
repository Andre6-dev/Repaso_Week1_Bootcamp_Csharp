namespace Repaso_Modulo1;

internal class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("==================");
        // Console.WriteLine("Repaso bucles");
        // /*
        //  * *
        //  * * *
        //  * * * *
        //  * * * * *
        //  */
        //
        // // For loop:
        // int i, j, filas;
        // Console.WriteLine("Ingresa el numero de filas");
        // filas = Convert.ToInt32(Console.ReadLine());
        //
        // for (i = 1; i <= filas; i++)
        // {
        //     for (j = 1; j <= i; j++)
        //     {
        //         Console.Write("* ");
        //     }
        //     Console.Write("\n");
        // }
        // Console.WriteLine("Se acabo el bucle");
        //
        // /*
        // * 1
        // * 1 2
        // * 1 2 3
        // * 1 2 3 4
        //  */
        //
        // for (i = 1; i <= filas; i++)
        // {
        //     for (j = 1; j <= i; j++)
        //     {
        //         if (j >= 2)
        //         {
        //             Console.Write(j - 1 + " ");
        //         }
        //         else
        //         {
        //             Console.Write("* ");
        //         }
        //
        //     }
        //     Console.Write("\n");
        // }


        /*
         * -----*
         * ----* *
         * ---* * *
         * --* * * *
         * -* * * * *
         * 
         */
        Console.WriteLine("Segundo Reto");
        int rows;
        int spaces;

        Console.WriteLine("Elegir el numero de filas de la piramide");
        rows = Convert.ToInt32(Console.ReadLine());
        spaces = rows + 3 - 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int k = spaces; k >= 1; k--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
            spaces--; // Restando los espaces para que tome forma de la piramide
        }

        Console.WriteLine("Se acabo el bucle");

        // Ejercicios de arreglos
        // Listar 

        int[] otrosNumeros = new int[] { 10, 20, 30, 40, 50 };

        int total2 = 0;
        for (int i = 0; i < otrosNumeros.Length; i++)
        {
            total2 += otrosNumeros[i];
        }

        Console.WriteLine(total2.ToString());

        // Obtner 
        int total = 0;
        foreach (int valor in otrosNumeros)
            total += valor;
        Console.WriteLine(total.ToString());

        // Contar los duplicados dentro de un arreglo
        // int[] arreglo = new int[] {44, 44, 32, 32, 35}
        // Resultado: Hay 2 valores duplicados en el arreglo.
    }
}
