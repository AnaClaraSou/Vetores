using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int tam = 31; int var;

            double[] temp = new double[tam];
            /*Infomar a temperatura*/
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("Informe uma temperatura");
                temp[i]=double.Parse(Console.ReadLine());

            }
            /*Informar a temperatura que deseja saber e criar uma variável para armazenar*/
            Console.WriteLine("Qual temperatura que você dejesa saber?");
            var=int.Parse(Console.ReadLine());
            /*Criar outro for para vê em qual dia a temperatuta está, dentro do vetor*/
            for (int i = 0;i<temp.Length ; i++)
            {
                if (temp[i] == var)
                {
                    Console.WriteLine("As temperaturas informadas foram nos dias: " + (i + 1) );
                }
            }
           Console.ReadLine();
        }
    }
}
