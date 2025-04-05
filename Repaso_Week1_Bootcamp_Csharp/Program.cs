namespace Repaso_Week1_Bootcamp_Csharp;

internal class Program
{
    static void Main(string[] args)
    {
        int dni = 2233333;
        int edad = 8;
        double numeroDecimal = 10.00;
        char caracter = '1';
        bool esMayordeEdad = true;
        string nombre = "Andre"; // referencia

        if (dni != 2233333 || !esMayordeEdad)
        {
            Console.WriteLine("No es mi numero de dni");
            if (esMayordeEdad)
            {
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("Si es mi numero de dni");
        }

        // Dias de la semana
        Console.WriteLine("=============================");
        Console.WriteLine("Dias de la semana");
        String diaSemana = "Lunes";

        switch (diaSemana)
        {
            case "Lunes":
                Console.WriteLine("El dia es lunes");
                break;
            case "Martes":
                Console.WriteLine("El dia es martes");
                break;
            default:
                Console.WriteLine("No es un dia de la semana");
                break;
        }

        Console.WriteLine("Saliendo de la aplicacion");

        // Comprobar si un numero es impar o par
        int numeroAComprobar;
        Console.WriteLine("");
        Console.WriteLine("============================");
        Console.WriteLine("Ingresa el valor a comprobar: ");
        Console.WriteLine("============================");
        numeroAComprobar = Convert.ToInt32(Console.ReadLine());

        if (numeroAComprobar % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }
    }
}
