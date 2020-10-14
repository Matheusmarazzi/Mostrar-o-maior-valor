using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            if (A > B)
                Console.WriteLine(" o maior valor é: " + A);
            else
                Console.WriteLine(" o maior valor é: " + B);
            Console.ReadKey();

        
        }
    }
}
