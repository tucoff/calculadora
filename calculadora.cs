using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main()
        {
            Console.Write("Escolha um número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Escolha outro número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma entre esses números resulta em: " + (num1 + num2));
            Console.WriteLine("A subtração entre esses números resulta em: " + (num1 - num2));
            Console.WriteLine("A multiplicação entre esses números resulta em: " + (num1 * num2));
            if (num2 != 0)
            {
                Console.WriteLine("A divisão entre esses números resulta em: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("A divisão entre esses números é impossível, já que o segundo número dado foi 0");
            }
        }
    }
}
