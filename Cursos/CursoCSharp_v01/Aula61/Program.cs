using System.Globalization;

namespace Aula61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double initial_deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(number, name, initial_deposit);
            }

            else
            {
                account = new BankAccount(number, name);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposit_value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            account.Deposit(deposit_value);

            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double withdrawal_value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdrawal(withdrawal_value);

            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(account);
            Console.WriteLine();

        }
    }
}
