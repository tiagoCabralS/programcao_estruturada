using System.ComponentModel.Design;

namespace exemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração as variaveis
            double n1, n2, soma, sub, mult, div;
            // exibir mensagens e ler números de entrada
            Console.Write("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro: ");
            n2 = double.Parse(Console.ReadLine());
            // faço o calculos e atribuo o valores para as variaveis
            soma = n1 + n2;
            sub = n1 - n2;
            mult = n1 * n2;
            div = n1 / n2;
            // exibir saidas
            Console.WriteLine($"A soma é {soma}");
            Console.WriteLine("A subtração é {0}", sub);
            Console.WriteLine("O prouto é {0}", mult);
            Console.WriteLine("A razão é {0}", div);
            Console.WriteLine("o resto é {0}", n1 % n2);

            if (n1 % n2 == 0)
            {
                Console.WriteLine("{0} é multiplo de {1}", n1, n2);
            }
        }
    }
}
