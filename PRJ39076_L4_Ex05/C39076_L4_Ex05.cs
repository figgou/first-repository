using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PRJ39076_L4_Ex05
{
    internal class C39076Ex05
    {
        static void Main(string[] args)
        {            
            List<int> valores = [];
            
            string resposta = "S";

            while (resposta?.ToUpper() == "S")
            {
                Console.Clear();                

                while((valores.Sum()) < 100)
                {   
                    Console.Write($"Insira um valor: ");
                    valores.Add(int.Parse(Console.ReadLine()));                    
                }
            
                Console.WriteLine($"Soma dos valores: {valores.Sum()}");
                Console.WriteLine($"Média dos valores: {valores.Average()}");
                Console.WriteLine($"Maior valor: {valores.Max()}");

                Console.WriteLine("Deseja repetir? (S/N): ");
                resposta = Console.ReadLine();

            }
        }
    }
}