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

        int primerNumero;
        int segundoNumero;
        int tercerNumero;
        Console.WriteLine("");
        Console.WriteLine("============================");
        Console.WriteLine("Cual es el numero mayor de 3 numeros ");
        Console.WriteLine("============================");
        Console.WriteLine("Escribe el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el tercer numero: ");
        tercerNumero = Convert.ToInt32(Console.ReadLine());

        if (primerNumero > segundoNumero)
        {
            if (primerNumero > tercerNumero)
            {
                Console.WriteLine("El primer numero es el mayor");
            }
            else
            {
                Console.Write("El tercer numero es el mayor");
            }
        }
        else if (segundoNumero > tercerNumero)
        {
            Console.WriteLine("El segundo numero es el mayor");
        }
        else
        {
            Console.WriteLine("El tercer numero es el mayor");
        }

        // Obtener el area del circulo o del cuadrado
        Console.WriteLine("");
        Console.WriteLine("============================");
        Console.WriteLine("Dame la opcion de que area es para comprobar ");
        Console.WriteLine("============================");

        // Comprobar si has escogido circulo o rectangulo
        // Si es circulo necesito que me pidas el radio
        // Si has elegido rectangulo, te tendria que pedir largo y ancho
        // Si has escogido una opcion que no es circulo o rectangulo un mensaje de error
        int opcionArea;
        int r;
        int largo;
        int ancho;
        double pi;
        double area;
        Console.WriteLine("Ingresa la opcion del area a calcular");
        Console.WriteLine("1. Area del circulo");
        Console.WriteLine("2. Area del rectangulo");
        opcionArea = Convert.ToInt32(Console.ReadLine());

        switch (opcionArea)
        {
            case 1:
                Console.WriteLine("Ingresa el radio del circulo");
                r = Convert.ToInt32(Console.ReadLine());
                pi = 3.14;
                area = pi * r * r;
                Console.WriteLine("El area del circulo es: " + area);
                break;
            case 2:
                Console.WriteLine("Ingresa el largo del rectangulo");
                largo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el ancho del rectangulo");
                ancho = Convert.ToInt32(Console.ReadLine());
                area = largo * ancho;
                Console.WriteLine("El area del rectangulo es: " + area);
                break;
            default:
                Console.WriteLine("La opcion es incorrecta: ");
                break;
        }

        Console.WriteLine("La opcion es incorrecta: ");
        Console.WriteLine("La opcion es incorrecta: ");
        Console.WriteLine("La opcion es incorrecta: ");
        Console.WriteLine("La opcion es incorrecta: ");

    }
}
