using Caixa.eletronico;

Conta conta = new Conta();

conta.Saldo = 1000;
string opcao;
bool menu = true;

Console.WriteLine("Caixa Eletrônico\n");

while (menu) 
{
    Console.Clear();

    Console.WriteLine("Menu:\n");
    Console.WriteLine("1 - Ver Saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("4 - Sair\n");

    Console.WriteLine("Digite a opção desejada: ");
    opcao = Console.ReadLine();


    if (opcao == "1")
    {
        Console.WriteLine($"Saldo atual é de: {conta.Saldo}\n");

        Console.WriteLine("\nPressione uma tecla para continuar");
        Console.ReadKey();
    }

    else if (opcao == "2")
    {
        Console.WriteLine("Informe o valor a ser depositado: \n");
        conta.Deposito = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Saldo atual é de: {conta.Saldo = conta.Saldo + conta.Deposito}\n");

        Console.WriteLine("\nPressione uma tecla para continuar");
        Console.ReadKey();

    }
        
    else if (opcao == "3")
    {

        Console.WriteLine("Informe o valor do saque:");
        conta.Saque = Convert.ToInt32(Console.ReadLine());

        if (conta.Saldo < conta.Saque)
        {
            Console.WriteLine($"Saldo insuficiente. Seu limite de saque é: {conta.Saldo}\n");
        }
        else
        {
            Console.WriteLine($"Saque realizado \nSaldo atual é de: {conta.Saldo = conta.Saldo - conta.Saque}\n");

            Console.WriteLine("\nPressione uma tecla para continuar");
            Console.ReadKey();

        }


    }
    else if (opcao == "4")
    {
        menu = false;
    }
}