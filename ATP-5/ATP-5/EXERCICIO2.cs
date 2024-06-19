using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, val;
            bool T = false;
            Console.WriteLine("Informe um número positivo");
            val=int.Parse(Console.ReadLine());
            /*Entrar com o vetor*/
            int[]dig = new int[val];
            /*Usando para receber os números*/
            for(int i = 0; i <dig.Length; i++)
            {
                Console.WriteLine("Informe quantos digitos terá o número");
                num=int.Parse(Console.ReadLine());

            }
            /*Verificar se é*/
            for (int i = 0; i < dig.Length; i++)
            {
                for (int j = dig.Length - 1; j >= 0; j--)
                {
                    num = dig[j];
                    if (dig[i] == num)
                    {
                        T = true;
                    }
                    else
                    {
                        T = false;
                    }
                }
            }
            if (T == true)
            {
                Console.WriteLine("O número é um palíndromo");
            }
            else
            {
                Console.WriteLine("O número não é um palíndromo");
            }
            Console.ReadLine();
        }
    }
}
