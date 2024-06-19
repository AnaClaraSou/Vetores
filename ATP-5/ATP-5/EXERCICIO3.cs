using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[200];
            double menornota, maiornota, pesqnota, medianota, quantnota = 0, soma = 0;
            int op;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Informe o valor da nota");
                notas[i] = double.Parse(Console.ReadLine());
                while (notas[i] < 0 || notas[i] > 100)
                {
                    Console.WriteLine("Erro!Nota inválida \n Digite novamente");
                    notas[i] = double.Parse(Console.ReadLine());
                }
                soma += notas[i];
            }
            

            do
            {
                Console.WriteLine("Opcões: \n 1.Mostrar a menor nota \n 2.Mostrar a maior nota \n 3.Pesquisar nota \n " +
                    "4. Mostrar média das notas e quantidade de notas acima da média \n 5. Sair");
                op=int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        menornota = notas[0];
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (menornota > notas[i])
                            {
                                menornota = notas[i];

                            }
                           
                        }
                        Console.WriteLine($"A menor nota é: {menornota} ");
                        break;
                    case 2:
                        maiornota = notas[0];
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (maiornota < notas[i])
                            {
                                maiornota = notas[i];

                            }
                        }
                        Console.WriteLine($"A maior nota é: {maiornota} ");
                    break;
                       
                    case 3:
                        Console.WriteLine("Qual nota deseja pesquisar?");
                        pesqnota = double.Parse(Console.ReadLine());
                       
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (notas[i] == pesqnota)
                            {
                                Console.Write($"A nota {pesqnota} consta nas posições: {i} \n");
                                i++;

                            }
                                
                            
                            
                        }
                    
                    break;
                    case 4:
                        medianota = soma / notas.Length;
                        Console.WriteLine($"A média das notas é: {medianota}");
                        for (int i = 0; i < notas.Length; i++)
                        {
                            if (medianota < notas[i])
                            {
                                quantnota++;
                               
                            }
                           
                        }
                        Console.WriteLine($"A quantidade de notas acima da média é {quantnota}");
                    break;





                }
            }
            while (op != 5);
            {
                Console.WriteLine("Você saiu do Programa");
            }
           
            Console.ReadLine();
        }
    }
}

