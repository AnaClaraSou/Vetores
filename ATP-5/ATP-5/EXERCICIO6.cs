using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetA = new int[10];
            int[] vetB = new int[10];
            char[] vetC = new char[10];
            double[] vetD = new double[10];

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine("Informe dois valores inteiros e uma operação: (+ , - , * , /): ");
                vetA[i] = int.Parse(Console.ReadLine());
                vetB[i]= int.Parse(Console.ReadLine());
                vetC[i]= char.Parse(Console.ReadLine());

                switch (vetC[i])
                {
                    case '/' :
                        {
                            
                            if (vetB[i] != 0)
                            {
                                vetD[i] = (double)vetA[i] / vetB[i];
                                
                            }
                            else
                            {
                                Console.WriteLine("Denominador tem que ser diferente de 0");
                                i--;
                            }
                           
                        }
                        Console.WriteLine($"O resultado é: {vetD[i]}");
                    break;
                    case '*':
                        {
                            vetD[i] = vetA[i] * vetB[i];

                        }
                        Console.WriteLine($"O resultado é: {vetD[i]}");
                    break;
                    case '+':
                        {
                            vetD[i] = vetA[i] + vetB[i];

                        }
                        Console.WriteLine($"O resultado é: {vetD[i]}");
                    break;
                    case '-':
                        {
                            vetD[i] = (double)vetA[i] - vetB[i];

                        }
                        Console.WriteLine($"O resultado é: {vetD[i]}");
                    break;
                    
                }
                Console.ReadLine();
            }
        }
    }
}
