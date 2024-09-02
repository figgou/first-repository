namespace PRJ39076_L4_Ex03
{
    internal class C39076_L4_Ex03
    {
        static void Main(string[] args)
        {
            string resposta = "S";

            int n1, n2, res;

            while (resposta == "S")
            {
                Console.Write("Insira o primeiro valor entre 1 e 100: ");
                n1 = int.Parse(Console.ReadLine());

                while (n1 < 0 || n1 > 100)
                {
                    Console.Write("Insira um valor válido: ");
                    n1 = int.Parse(Console.ReadLine());
                }

                Console.Write("Insira o segundo valor entre 1 e 100: ");
                n2 = int.Parse(Console.ReadLine());

                while (n2 < 0 || n2 > 100)
                {
                    Console.Write("Insira um valor válido: ");
                    n2 = int.Parse(Console.ReadLine());
                }

                res = n1 + n2;

                Console.WriteLine("A soma dos números é: " + res);

                Console.Write("Deseja repetir? (S/N): ");
                resposta = Console.ReadLine();
            }
        }
    }
}
