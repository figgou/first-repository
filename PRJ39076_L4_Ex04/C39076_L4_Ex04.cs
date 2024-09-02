namespace PRJ39076_L4_Ex04
{
    internal class C39076_L4_Ex04
    {
        static void Main(string[] args)
        {
            //int[] op = new int[3];
            int[] valor = new int[10];
            int i = 0;
            int res = 0, maiorV = 0, mediaA = 0;
            string repetir = "S";

            while (string.Equals(repetir, "S", StringComparison.OrdinalIgnoreCase))
            {
                i = 0;

                while (i < valor.Length)
                {
                    //Estudar sobre foreach e for
                    //Como realizar operações gerais em um array
                    //Diferentes tipos de operações em um array
                    Console.WriteLine("Insira o " + (i + 1) + "° número :");
                    valor[i] = int.Parse(Console.ReadLine());
                    i++;
                }


                //valor.Length representa o número de índices no array;
                //é possível realizar operações dentro da condicional de um loop for;
                for (i = 0; i < valor.Length; i++)
                {
                    res += valor[i];
                }


                for (i = 0; i < valor.Length; i++)
                {
                    if (valor[i] > maiorV)
                    {
                        maiorV = valor[i];
                    }
                }

                for (i = 0; i < valor.Length; i++)
                {
                    mediaA += valor[i];
                }

                mediaA = mediaA / valor.Length;


                Console.WriteLine("A soma dos valores é: " + res);
                Console.WriteLine("O maior valor é: " + maiorV);
                Console.WriteLine("A média aritmética é: " + mediaA);
                Console.WriteLine("Deseja repetir? (S/N): ");

                repetir = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}