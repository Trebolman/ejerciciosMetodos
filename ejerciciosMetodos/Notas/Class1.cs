using System;

namespace notas
{
    public class Metodos
    {
        public int promedioNotas(int[] notas)
        {
            int promedio = 0;
            for (int i=0; i < notas.Length; i++)
            {
                
                promedio = promedio + notas[i]; 
            }
            return promedio/ notas.Length;
        }
        public void EstaAprobado(int promedio)
        {
            if(promedio >= 11)
            {
                Console.WriteLine("Esta aprobado");
            }else{ Console.WriteLine("Esta desaprobado"); }
        }

        public uint SumaNumerosAnteriores(uint numero)
        {
            uint SumaNumeros(uint n)
            {
                if (n == 0)
                {
                    return 0;
                }
                return n + SumaNumeros(n - 1);
            }
            return SumaNumeros(numero - 1);
        }

        public int potenciaNumero(int numero, int exponente)
        {
            int multiplicador(int exp)
            {
                if(exp == 0)
                {
                    return 1;
                }
                return numero * multiplicador(exp - 1);
            }
            return multiplicador(exponente);
        }

        //public int numeroMayor(int[] num)
        //{

        //}
    }
}
