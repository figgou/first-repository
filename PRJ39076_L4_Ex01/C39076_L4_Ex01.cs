﻿namespace PRJ39076_L4_Ex01
{
    internal class C39076Ex01
    {
        static void Main(string[] args)
        {
            int valor1, valor2;

            string repetir = "S";

            while (repetir?.ToUpper() == "S")
            {
                try
                {
                    Console.Write("Insira o primeiro valor: ");
                    valor1 = int.Parse(Console.ReadLine());

                    Console.Write("Insira o segundo valor: ");
                    valor2 = int.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.Write("Insira um número!");
                    Console.ReadKey();
                    return;
                }

                while (valor1 >= valor2)
                {
                    Console.Write("Insira um valor maior que o anterior: ");
                    valor2 = int.Parse(Console.ReadLine());

                }

                Console.Write("Deseja repetir? (S/N)");
                repetir = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
