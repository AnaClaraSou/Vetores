using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            double notastodos = 0, acimamedia,contmedia = 0;

            Console.WriteLine("Informe as notas");

            for (int i = 0; i < notas.Length; i++)
            {
                
                notas[i] = int.Parse(Console.ReadLine());
                
                if (notas[i] < 0)
                {
                    
                    i = notas.Length;
                   
                }
                
            }
            for (int i = 0; i < notas.Length; i++)
            {
                notastodos += notas[i];

                Console.WriteLine($"A nota do aluno é: {i + 1} equivale a {notas[i]}");
            }
                acimamedia = notastodos / notas.Length;

            for (int i = 0; i < notas.Length; i++)
            {
                if(acimamedia < notas[i])
                {
                    contmedia++;
                }

            }
           
            Console.WriteLine($"As notas acima da média é: {contmedia}");
            Console.WriteLine($"A média das notas é: {acimamedia}");
            Console.ReadLine();
        }
    }
}
