using System;

namespace Exercicio_JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal montante;
            double taxajuros, capital, juros, tempo;
        
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nApós digitar todas as informaões necessárias  o progama ira calcular o montante final de um investimento a juros simples.\n");
            Console.ResetColor();
            
            Console.Write("Digite o seu capital:...... R$ ");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros:......% ");
            taxajuros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo (meses):........");
            tempo = Convert.ToDouble(Console.ReadLine());

            juros= capital * (taxajuros/100) * tempo;
            montante = Convert.ToDecimal(juros + capital);

            Console.WriteLine();
            Console.WriteLine($"Juros:.....R${juros},00");
            Console.WriteLine($"Montante:..R${montante},00");
        }
    }
}
