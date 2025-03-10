using System;
using System.Globalization;

namespace Aula60
{
    internal class BankAccount
    {
        public string AccountNumber
        {
            get; private set;
        }

        public string NameAccountOwner
        {
            get; private set;
        }

        public double Balance
        {
            get; private set;
        }

        public double Tax = 5.00;


        public void CreateAccount()
        {
            Console.Write("Entre com o número da conta: ");
            AccountNumber = Console.ReadLine();

            Console.Write("Entre o nome do titular da conta: ");
            NameAccountOwner = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string char_validation = Console.ReadLine();

            if (char_validation == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                Balance += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("\nDados da conta:");
            GetAccountData();
        }


        private void GetAccountData()
        {
            Console.WriteLine($"Conta: {AccountNumber}, Titular: {NameAccountOwner}, Saldo: R${Balance.ToString("F2", CultureInfo.InvariantCulture)}\n");
        }


        public void Deposit()
        {
            Console.Write("Entre um valor para depósito: ");
            double deposit_value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Balance += deposit_value;

            Console.WriteLine("Dados da conta atualizados: ");
            GetAccountData();

        }

        public void Withdrawal()
        {
            Console.Write("Entre um valor para saque: ");
            double withdrawal_value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Balance -= (withdrawal_value + 5);

            Console.WriteLine("Dados da conta atualizados:");
            GetAccountData();

        }
    }
}
