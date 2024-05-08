// ESSE É UM EXERCÍCIO DE FIXAÇÃO DO MÓDULO, É MINHA MANEIRA DE FAZER
// PRÓXIMO ARQUIVO EU IREI COPIAR A CORREÇÃO DO PROFESSOR

namespace Aula60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.CreateAccount();
            account.Deposit();
            account.Withdrawal();

        }
    }
}
