namespace WhileLoop;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a los while loops");
        // Escribir un bucle infinito
        // int contador = 0;
        // while (contador <= 10)
        // {
        //     Console.WriteLine("El valor es: " + contador);
        //     contador++;
        // }
        // Console.WriteLine("Se acabo el bucle");

        // Tabla de multiplicar
        // 10 = 10x1, 10x2, 10x3.... 10x12
        int contadorTabla = 1;
        Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
        int valorTabla;
        int resultado;
        valorTabla = Convert.ToInt32(Console.ReadLine());
        while (contadorTabla <= 12)
        {
            resultado = valorTabla * contadorTabla;
            Console.WriteLine("La tabla del numero: " + valorTabla + " es igual a " + valorTabla + "x" + contadorTabla + " = " + resultado);
            contadorTabla++;
        }
    }
}
