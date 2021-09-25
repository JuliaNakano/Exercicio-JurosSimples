using System;

namespace Exercicio_JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal montante;
            decimal taxajuros, capital, juros, tempo;
        
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nApós digitar todas as informaões necessárias  o progama ira calcular o montante final de um investimento a juros simples.\n");
            Console.ResetColor();
            
            Console.Write("Digite o seu capital:...... R$ ");
            capital = Convert.ToDecimal(Console.ReadLine());
            

            Console.Write("Digite a taxa de juros:......% ");
            taxajuros = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o tempo (meses):........");
            tempo = Convert.ToDecimal(Console.ReadLine());

            juros= capital * (taxajuros/100) * tempo;
            montante = Convert.ToDecimal(juros + capital);

            Console.WriteLine();
            Console.WriteLine($"Juros:.....R${juros}");
            Console.WriteLine($"Montante:..R${montante}");
        }
    }
}
