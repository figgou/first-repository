using System;
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
            int i = 0;
            int[] valores = new int[100]; // eu sei que deve ter uma maneira mais fácil do que essa, mas não consegui pensar em 
            //como alterar o número de índices com base nas respostas do usuário
            string resposta = "S";

            //ele não tá compilando... não sei o pq

            while (resposta?.ToUpper() == "S")
            {
                Console.Clear();
                i = 0;

                while((valores.Sum()) < 100)
                {   

                    Console.Write($"Insira um valor: ");
                    valores[i] = int.Parse(Console.ReadLine());
                    i++;
                }
            
                Console.WriteLine($"Soma dos valores: {valores.Sum()}");
                Console.WriteLine($"Média dos valores: {valores.Sum() / i}");
                Console.Write($"Maior valor: {valores.Max()}");

                Console.WriteLine("Deseja repetir? (S/N): ");
                resposta = Console.ReadLine();

            }
        }
    }
}

