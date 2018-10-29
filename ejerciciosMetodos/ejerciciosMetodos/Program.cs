using System;
using Metodos;
namespace ejercicioMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio:
            string menu = @"Menu de ejercicios:
1. Implementar un método que me permita sacar el promedio de N calificaciones de un
    alumno, una vez calculado el promedio, Crear otro método que me permita saber si el
    alumno aprobó “mayo a 10.5” o desaprobó “menor a 10.5”.
2. Implementar Métodos que me permita saber de 3 números cual es el mayor y el menor.
3. Implementar un método que me permita saber cuál es el factorial de un número
    cualquiera.
4. Implementar el Método anterior usando una función recursiva.
5. Implementar un método que me permita saber la suma de todos los números anteriores
    de un número ingresado por teclado.
6. Implementar el ejercicio anterior usando recursividad.
7. Implementar un método que calcule la potencia de un número, ingresando por teclado la
    base y el exponente.
8. Implementar el ejercicio anterior usando recursividad.";
            MetodosRecursividad metodo = new MetodosRecursividad();
            Console.WriteLine(menu);
            Console.WriteLine("Ingrese el item del ejercicio a revisar:");
            int ejercicio = Convert.ToInt16(Console.ReadLine());
            int salir = 0;
            switch (ejercicio)
            {
                case 1:
                    Console.WriteLine("Ingrese numero de notas");
                    int nroNotas = Convert.ToInt32(Console.ReadLine());
                    int[] puntuaciones = new int[nroNotas];
                    for (int i = 0; i < puntuaciones.Length; i++)
                    {
                        Console.WriteLine($"Ingrese nota {i + 1}");
                        puntuaciones[i] = Convert.ToInt32(Console.ReadLine());
                        if (puntuaciones[i] < 0 || puntuaciones[i] > 20)
                        {
                            Console.WriteLine("Ingrese un numero entre 0 y 20");
                            puntuaciones[i] = Convert.ToInt32(Console.ReadLine());
                        }

                    }
                    int promedio = metodo.PromedioNotas(puntuaciones);
                    Console.WriteLine($"El promedio es: {promedio}");
                    metodo.EstaAprobado(promedio);

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 1; }
                    break;
                case 2:
                    //2) SABER DE TRES NUMERO CUAL ES EL MAYOR O EL MENOR
                    double[] numero = new double[3];
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Ingrese numero {i + 1}");
                        numero[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    if (numero[0] < numero[1])
                    {
                        if (numero[0] < numero[2])
                        {
                            Console.WriteLine($"{numero[0]} el menor numero");
                        }
                        else { Console.WriteLine($"{numero[2]} el menor numero"); }
                    }
                    else { Console.WriteLine($"{numero[1]} el menor numero"); }

                    if (numero[2] > numero[1])
                    {
                        if (numero[2] > numero[0])
                        {
                            Console.WriteLine($"{numero[2]} el mayor numero");
                        }
                        else { Console.WriteLine($"{numero[0]} el mayor numero"); }
                    }
                    else { Console.WriteLine($"{numero[1]} el mayor numero"); }

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 2; }
                    break;
                case 3:
                    // 3) FACTORIAL SIN RECURSIVIDAD
                    Console.WriteLine("Ingrese numero a calcular: ");
                    int numero3 = Convert.ToInt32(Console.ReadLine());
                    if(numero3 < 0) { goto case 3; }
                    int resFactorial = 1;
                    for(int i = 1; i <= numero3; i++)
                    {
                        resFactorial = resFactorial * i;
                    }
                    Console.WriteLine($"El factorial de {numero3} es: {resFactorial}");

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 3; }
                    break;
                case 4:
                    //4) FACTORIAL
                    Console.WriteLine("Ingrese numero a calcular: ");
                    int numero4 = Convert.ToInt32(Console.ReadLine());
                    if (numero4 < 0) { goto case 4; }
                    Console.WriteLine($"El factorial de {numero4} es: {metodo.Factorial(numero4)}");

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 4; }
                    break;

                case 5:
                    // 5) SUMA DE NUMEROS ANTERIORES AL NUMERO INGRESADO
                    Console.WriteLine("Ingrese numero a calcular: ");
                    uint numero5 = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine($"La suma de numeros anteriores a {numero5} es: {metodo.SumaNumerosAnteriores(numero5)}");

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 5; }
                    break;

                case 6:
                    // 6) SUMA DE NUMEROS ANTERIORES SIN USAR RECURSIVIDAD
                    Console.WriteLine("Ingrese numero a calcular: ");
                    uint numero6 = Convert.ToUInt32(Console.ReadLine());
                    int resSuma = 0;
                    for(int i = 1; i < numero6; i++)
                    {
                        resSuma = resSuma + i;
                    }
                    Console.WriteLine($"La suma de numeros anteriores a {numero6} es: {resSuma}");

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 6; }
                    break;
                case 7:
                    //7) POTENCIA DE UN NUMERO INGRESANDO BASE Y EXPONENTE
                    Console.WriteLine("Ingrese base: ");
                    int numeroBase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese exponente: ");
                    int exponente = Convert.ToInt32(Console.ReadLine());
                    int potencia = 1;
                    for (int i = 1; i <= exponente; i++)
                    {
                        potencia = potencia * numeroBase;
                    }
                    Console.WriteLine($"La potencia de base {numeroBase} elevado a {exponente} es: {potencia} ");

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 7; }
                    break;

                case 8:
                    // 8) POTENCIA DE UN NUMERO RE FORMA RECURSIVA
                    Console.WriteLine("Ingrese numero a calcular: ");
                    Console.WriteLine("Ingrese base: ");
                    int numeroBase2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese exponente: ");
                    int exponente2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"La potencia de base {numeroBase2} elevado a {exponente2} es: {metodo.PotenciaNumero(numeroBase2, exponente2)}");

                    Console.WriteLine("¿Desea salir? Si=1/No=2");
                    salir = Convert.ToInt16(Console.ReadLine());
                    if (salir == 2) { goto case 8; }
                    break;
            }
            goto inicio;
        }
    }
}
