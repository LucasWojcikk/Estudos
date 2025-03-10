using System.Globalization;

namespace Aula61
{
    class BankAccount
    {
        public int NumberAccount
        {
            get; private set;
        }

        public string NameAccountOwner
        {
            get; set;
        }

        public double Balance
        {
            get; private set;
        }


        public BankAccount(int numberAccount, string nameAccountOwner)
        {
            NumberAccount = numberAccount;
            NameAccountOwner = nameAccountOwner;
        }


        public BankAccount(int numberAccount, string nameAccountOwner, double deposit_value) : this(numberAccount, nameAccountOwner)
        {
            Deposit(deposit_value);
        }


        public override string ToString()
        {
            return $"Conta: {NumberAccount}, Tituar: {NameAccountOwner}, Saldo: R${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void Deposit(double deposit_value)
        {
            Balance += deposit_value;
        }

        public void Withdrawal(double withdrawal_value)
        {
            Balance -= withdrawal_value + 5.0;
        }

    }
}
