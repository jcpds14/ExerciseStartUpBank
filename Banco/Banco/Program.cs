using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();

            Console.Write("Digite o nome do titular: ");
            conta1.titular = Console.ReadLine();

            Console.Write("Digite a agência (Ex: xxxx-x): ");
            conta1.agencia = Console.ReadLine();
            Console.Write("Digite o número da conta (Ex: xxxx-x): ");
            conta1.numero = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            conta1.saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEstas são as informações da conta:\n");

            Console.WriteLine($"Titular da conta: {conta1.titular}");
            Console.WriteLine($"Agência: {conta1.agencia}");
            Console.WriteLine($"Número da conta: {conta1.numero}");
            Console.WriteLine($"Saldo Total: {conta1.saldo}");
        }
    }
}
