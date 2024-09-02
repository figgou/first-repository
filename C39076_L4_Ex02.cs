using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj39076_39086_L4_Ex02
{
    internal class C39076_L4_Ex02
    {
        static void Main(string[] args)
        {
            char sexo = 'F';

            string repetir = "S";

            while (repetir == "S")
            {
                
                Console.Write("Insira o sexo (F/M): ");
                sexo = char.Parse(Console.ReadLine());                

                if (sexo != 'F' && sexo != 'M')
                {                   
                    Console.Write("Insira um valor válido!");                   
                    Console.ReadKey();
                    return;
                }

                Console.Write("Deseja repetir? (S/N): ");
                repetir = Console.ReadLine();
                Console.Clear();
            }





        }
    }
}
