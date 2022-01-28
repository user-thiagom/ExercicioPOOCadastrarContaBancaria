// See https://aka.ms/new-console-template for more information

using ExercicioPOOCadastrarContaBancaria;

ContaBancaria conta;

Console.WriteLine("Entre o número da Conta: ");
int numeroConta = int.Parse(Console.ReadLine());

Console.WriteLine("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.WriteLine("Haverá deposito inicial? (s/n)");
char opcao = char.Parse(Console.ReadLine());

if (opcao == 's')
{
    Console.WriteLine("Entre o valor do depósito");
    double valor = double.Parse(Console.ReadLine());
    conta = new ContaBancaria(valor, numeroConta, titular);
}
else
{
    conta = new ContaBancaria(numeroConta, titular);
}

Console.WriteLine("\nDados da Conta:");
Console.WriteLine(conta);

Console.WriteLine("\nEntre um valor para deposito: ");
conta.Deposito(double.Parse(Console.ReadLine()));

Console.WriteLine("\nDados da conta atualizados: ");
Console.WriteLine(conta);

Console.WriteLine("\nEntre um valor de saque:");
conta.Saque(double.Parse(Console.ReadLine()));

Console.WriteLine("\nDados da conta atualizado:");
Console.WriteLine(conta);
