﻿using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays em C#

//int idade0 = 30;
//int idade1 = 40;
//int idade2 = 17;
//int idade3 = 21;
//int idade4 = 18;

//TestaArrayInt();
//TestaBuscarPalavra();

void TestaArrayInt()
{
    int[] idades = new int[5];

    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array: {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Índice [{i}] = {idade}");
        acumulador += idade;

    }

    int media = acumulador / idades.Length;

    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}


//Array amostra = Array.CreateInstance(typeof(double), 5);

//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

//// [5.9] [1.8] [7.1] [10] [6.9]

//TesteMediana(amostra);

void TesteMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para calculo mediana está vazio ou nulo");
    }
    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                            (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana é = {mediana}");

}

//int[] valores = { 10, 58, 36, 47 };

//for (int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}


//void TestaArrayDeContasCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

//    listaDeContas.Adicionar(new ContaCorrente(874, "5679798-A"));
//    listaDeContas.Adicionar(new ContaCorrente(875, "5679798-B"));
//    listaDeContas.Adicionar(new ContaCorrente(876, "5679798-C"));
//    listaDeContas.Adicionar(new ContaCorrente(876, "5679798-C"));
//    listaDeContas.Adicionar(new ContaCorrente(876, "5679798-C"));
//    listaDeContas.Adicionar(new ContaCorrente(876, "5679798-C"));

//    var contaDoAndre = new ContaCorrente(963, "123456-X");

//    listaDeContas.Adicionar(contaDoAndre);
//    //listaDeContas.ExibeLista();

//    //Console.WriteLine("===================");

//    //listaDeContas.Remover(contaDoAndre);
//    //listaDeContas.ExibeLista();


//    for (int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
//    }

//}

//TestaArrayDeContasCorrentes();

#endregion Exemplo


#region Interface sistema

ArrayList _listaDeContas = new ArrayList()
{
    new ContaCorrente(95, "123456-X"){Saldo=100},
    new ContaCorrente(95, "951258-X"){Saldo=200},
    new ContaCorrente(94, "987321-W"){Saldo=60}
};

void AtendimentoCliente()
{
    char opcao = '0';
    while (opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("=================================================");
        Console.WriteLine("===                Atendimento                ===");
        Console.WriteLine("===  1 - Cadastrar Contas                     ===");
        Console.WriteLine("===  2 - Listar Contas                        ===");
        Console.WriteLine("===  3 - Remover Conta                        ===");
        Console.WriteLine("===  4 - Ordenar Contas                       ===");
        Console.WriteLine("===  5 - Pesquisar Contas                     ===");
        Console.WriteLine("===  6 - Sair do Sistema                      ===");
        Console.WriteLine("=================================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];

        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;

            case '2':
                ListarContas();
                break;

            case '3':
                RemoverConta();
                break;

            case '4':
                //CadastrarConta();
                break;

            case '5':
                //CadastrarConta();
                break;

            case '6':
                //CadastrarConta();
                break;

            default:
                Console.WriteLine("Opção não implementada.");
                break;
        }


    }
}

void RemoverConta()
{
    throw new NotImplementedException();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("=================================================");
    Console.WriteLine("===             LISTA DE CONTAS               ===");
    Console.WriteLine("=================================================");
    Console.WriteLine("\n\n");

    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine(" ... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }

    foreach(ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("=== Dados da Conta ===");
        Console.WriteLine($"Número da Conta: {item.Conta}");
        Console.WriteLine($"Saldo da Conta: {item.Saldo}");
        Console.WriteLine($"Titular da Conta: {item.Titular.Nome}");
        Console.WriteLine($"CPF do titular: {item.Titular.Cpf}");
        Console.WriteLine($"Profissão do titular: {item.Titular.Profissao}");
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();

    }

}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("=================================================");
    Console.WriteLine("===            CADASTRO DE CONTA              ===");
    Console.WriteLine("=================================================");
    Console.WriteLine("\n");
    Console.WriteLine("===          Informe dados da conta           ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Informe nome do titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Informe CPF do titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Informe Profissão do titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");

    Console.ReadKey();


}

AtendimentoCliente();

#endregion