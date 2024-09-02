namespace PRJ39076_L4_Ex04
{
    internal class C39076_L4_Ex04
    {
        static void Main(string[] args)
        {
            //Original();
            Linq();
        }

        static void Original()
        {
            string repetir = "S";

            while (repetir.ToUpper() == "S")
            {
                Console.Clear();
                int[] valores = new int[10];
                int maiorValor = int.MinValue;
                int somaValores = 0;
                int mediaValores;

                for (int num = 1; num <= valores.Length; num++)
                {
                    Console.Write($"Insira o {num}° número: ");
                    int valor = int.Parse(Console.ReadLine());
                    valores[num - 1] = valor;
                    somaValores += valor;
                    maiorValor = valor > maiorValor
                                    ? valor
                                    : maiorValor; // Notação ternária. Equivale a `if valores[num-1] > maiorValor { maiorValor = valores[num-1] }`
                }

                mediaValores = somaValores / valores.Length;

                Console.WriteLine($"A soma dos valores é: {somaValores}");
                Console.WriteLine($"O maior valor é: {maiorValor}");
                Console.WriteLine($"A média aritmética é: {mediaValores}");
                Console.Write("Deseja repetir? (S/N): ");
                repetir = Console.ReadLine();
            }
        }

        static void Linq()
        {
            string repetir = "S";

            while (repetir.ToUpper() == "S")
            {
                Console.Clear();
                int[] valores = new int[10];

                for (int num = 1; num <= valores.Length; num++)
                {
                    Console.Write($"Insira o {num}° número: ");
                    valores[num - 1] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"A soma dos valores é: {valores.Sum()}");
                Console.WriteLine($"O maior valor é: {valores.Max()}");
                Console.WriteLine($"A média aritmética é: {Math.Ceiling(valores.Average())}"); // Math.Ceiling é para pegar o maior número inteiro mais próximo caso o resultado seja decimal (ex: se o resultado da média for 1,3, Math.Ceiling retorna 2)
                Console.Write("Deseja repetir? (S/N): ");
                repetir = Console.ReadLine();
            }
        }
    }
}