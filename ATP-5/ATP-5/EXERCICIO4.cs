using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] votos = new int[5];
            int maisvot = int.MinValue, menosvot = int.MaxValue, votnulos = 0;int posi = 0; 
            int cont0 = 0 ; int cont1 = 0;  int cont2 = 0; int cont3 = 0; int cont4 = 0 ;
            string nome;
            nome = "n";

            for (int i = 0; i < votos.Length; i++)
            {
                 
                    
                    Console.WriteLine("Canditados: \n 0. Perna Longa \n 1. Pluto \n 2.Mickey \n 3.Bob Esponja \n 4.Cebolinha");

                    Console.WriteLine("Escolha uma opção");
                    votos[i]=int.Parse(Console.ReadLine());
                
                
                    switch (votos[i])
                    {
                        case 0:
                             cont0++;
                            if (cont0 > maisvot)
                            {
                                maisvot = cont0;
                                 posi = i;
                            }
                           
                           else if (cont0 < menosvot)
                           {
                                menosvot = cont0;
                                nome = "Perna Longa";
                           }
                           
                           
                        break;

                        case 1:
                            cont1++;
                            if (cont1 > maisvot)
                            {
                                maisvot = cont1;
                                posi = i;
                            }

                            else if (cont1 < menosvot)
                            {
                                menosvot = cont1;
                                nome = "Pluto";
                            }

                          
                        break;

                        case 2:
                            cont2++;
                            if (cont2 > maisvot)
                            {
                                maisvot = cont2;
                                posi = i;
                            }

                            else if (cont2 < menosvot)
                            {
                                menosvot = cont2;
                                nome = "Mickey";
                            }
                           
                         
                        break;

                        case 3:
                            cont3++;
                            if (cont3 > maisvot)
                            {
                                maisvot = cont3;
                                posi = i;
                            }

                            else if (cont3 < menosvot)
                            {
                                menosvot = cont3;
                                nome = "Bob Esponja";
                            }
                           
                        
                        break;

                        case 4:
                           cont4++;
                            if (cont4 > maisvot)

                            {
                                maisvot = cont4;
                                posi = i;
                            }

                            else if (cont4 < menosvot)
                            {
                                menosvot = cont4;
                                nome = "Cebolinha";
                            }
                         
                            
                        break;

                        
                    }
                if ( votos[i] > 4)
                {
                    votnulos++;
                }

            }
            Console.WriteLine($"A quantidade de votos do canditado mais votado é: {maisvot} na {posi} posição");
            Console.WriteLine($"A quantidade de votos do canditado menos votado é: {nome} com {menosvot}");
            Console.WriteLine($"A quantidade de votos nulos é: {votnulos}");

            Console.ReadLine();
        }
    }
}
