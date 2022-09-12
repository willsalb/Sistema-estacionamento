using System;
using sistema_estacionamento_dotnet.Models;

//Permite uso de acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
bool exibirMenu = true;


DateTime dataAtual = DateTime.Now;

try
{
    Console.WriteLine($"Olá, Seja bem vindo ao sistema de estacionamento! Hoje é {dataAtual} \n" + "Digite o preço inicial: ");
    precoInicial = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o preço por hora: ");
    precoPorHora = Convert.ToDecimal(Console.ReadLine());

} catch(Exception error_menssage)
{
    Console.WriteLine($"Voçe deve digitar um número!!\n{error_menssage}");
    exibirMenu = false;
}

//Instanciando a classe estacionamento
Estacionamento Est = new Estacionamento(precoInicial, precoPorHora);

//Cadeia de caracteres vazia, somente para leitura
string opcao = string.Empty;

while(exibirMenu)
{
    //Console.Clear();
    Console.WriteLine("Digite sua opção: ");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Sair");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Est.AdcionarVeiculo();
            break;

        case "2":
            Est.RemoverVeiculo();
            break;

        case "3":
            Est.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa fechou...");